using System.Diagnostics;
using System.Runtime.InteropServices;

namespace CaptureApp.Engine;

/// <summary>
/// The recording ahead of a game on the CPU. libobs keeps its own audio thread ahead (MMCSS "Audio") but not its video
/// threads, so a game that keeps every core busy (a user's 8 threads in ARC Raiders) left the threads that draw, convert
/// and hand the picture to the encoder waiting while the sound went on: clips froze with sound. Measured 2026-10-24,
/// Capture on two CPUs with busy threads on the same two:
/// <list type="bullet">
/// <item>as before: 29 % of the frames lagged, 32 % skipped (busy threads one level above Capture);</item>
/// <item>the video threads alone time-critical: 0-3 %, but 12-24 % with busier CPUs: they also wait on Capture's other
/// threads (the .NET runtime's among them);</item>
/// <item>these and the process above normal: none lagged or skipped in any run, even with busy threads at its level.</item>
/// </list>
/// Both take no administrator. Capture works a few milliseconds a frame and sleeps the rest, so a game loses no more time
/// than before, only the order changes; the heavy work (Smart Save's model) runs a step lower, at the game's level. With
/// Game first (<see cref="Settings.VideoSettings.GameFirst"/>) the process stays normal: only the video threads go ahead,
/// and the rest of Capture (its timers, the .NET runtime, the replay written to the disk) waits for the game.
/// </summary>
static class CpuPriority
{
    static readonly string[] VideoThreadNames = ["libobs: graphics thread", "obs gpu encode thread", "video-io: video thread"];

    const int TimeCritical = 15; // THREAD_PRIORITY_TIME_CRITICAL
    const uint QueryLimited = 0x0800, SetLimited = 0x0400; // THREAD_QUERY_LIMITED_INFORMATION, THREAD_SET_LIMITED_INFORMATION

    [DllImport("kernel32.dll")]
    static extern IntPtr OpenThread(uint access, bool inherit, int id);

    [DllImport("kernel32.dll")]
    static extern int GetThreadDescription(IntPtr thread, out IntPtr description);

    [DllImport("kernel32.dll")]
    static extern int GetThreadPriority(IntPtr thread);

    [DllImport("kernel32.dll", SetLastError = true)]
    static extern bool SetThreadPriority(IntPtr thread, int priority);

    [DllImport("kernel32.dll")]
    static extern IntPtr LocalFree(IntPtr memory);

    [DllImport("kernel32.dll")]
    static extern bool CloseHandle(IntPtr handle);

    /// <summary>
    /// What the process goes to from <paramref name="now"/>: above normal from normal; null when something else chose
    /// (a test runner started it below normal, the user set it higher).
    /// </summary>
    internal static ProcessPriorityClass? Raised(ProcessPriorityClass now) =>
        now == ProcessPriorityClass.Normal ? ProcessPriorityClass.AboveNormal : null;

    /// <summary>
    /// What the process goes back to from <paramref name="now"/> for Game first: normal from the above normal Capture set
    /// (<paramref name="ownRaise"/>); null otherwise (a class someone else chose stays).
    /// </summary>
    internal static ProcessPriorityClass? Lowered(ProcessPriorityClass now, bool ownRaise) =>
        ownRaise && now == ProcessPriorityClass.AboveNormal ? ProcessPriorityClass.Normal : null;

    /// <summary>Whether the process was last asked raised (null: not asked yet), and whether Capture raised it.</summary>
    static bool? _asked;
    static bool _ownRaise;

    /// <summary>
    /// The engine's process above normal when <paramref name="raised"/> (<see cref="Raised"/>), else back to normal
    /// (<see cref="Lowered"/>); what happened, for the log, or null when nothing was asked anew.
    /// </summary>
    public static string? SetProcess(bool raised)
    {
        if (_asked == raised)
            return null;
        _asked = raised;
        try
        {
            using var self = Process.GetCurrentProcess();
            var now = self.PriorityClass;
            if ((raised ? Raised(now) : Lowered(now, _ownRaise)) is not { } next)
                return !raised && now == ProcessPriorityClass.Normal ? "normal (game first)" : $"left {now}";
            self.PriorityClass = next;
            _ownRaise = raised;
            return raised ? "above normal" : "normal (game first)";
        }
        catch (Exception e) when (e is System.ComponentModel.Win32Exception or InvalidOperationException)
        {
            return $"refused ({e.Message})";
        }
    }

    /// <summary>
    /// After an output's start: <see cref="RaiseVideoThreads"/> now and a few times in the next seconds. The GPU encode
    /// thread that start makes names itself only once it first runs, which a CPU full of a game's threads delays: looked
    /// for at once only, it was missed (a user's log: 2 builds of 3) and handed the picture to the encoder at normal
    /// priority while a quarter of the frames were skipped.
    /// </summary>
    public static void RaiseVideoThreadsSoon()
    {
        RaiseVideoThreads();
        foreach (int at in LaterMs)
            _ = Task.Delay(at).ContinueWith(_ => RaiseVideoThreads(), TaskScheduler.Default); // no thread held meanwhile
    }

    /// <summary>When <see cref="RaiseVideoThreadsSoon"/> looks again, in milliseconds after the start.</summary>
    static readonly int[] LaterMs = [200, 1000, 3000, 10_000];

    static readonly object Looking = new();

    /// <summary>
    /// libobs's video threads not raised yet go time-critical, found by the names libobs gives them; logged. An encoder's
    /// start makes its thread anew, so this runs after every output start (<see cref="RaiseVideoThreadsSoon"/>); one look
    /// at a time.
    /// </summary>
    public static void RaiseVideoThreads()
    {
        lock (Looking)
        {
            var raised = new List<string>();
            using var self = Process.GetCurrentProcess();
            foreach (ProcessThread thread in self.Threads)
            {
                IntPtr handle = OpenThread(QueryLimited | SetLimited, false, thread.Id);
                if (handle == IntPtr.Zero)
                    continue; // it ended
                try
                {
                    if (GetThreadPriority(handle) == TimeCritical || GetThreadDescription(handle, out IntPtr text) < 0)
                        continue;
                    string? name = Marshal.PtrToStringUni(text);
                    LocalFree(text);
                    if (name != null && VideoThreadNames.Contains(name))
                        raised.Add(SetThreadPriority(handle, TimeCritical) ? name : $"{name} refused ({Marshal.GetLastPInvokeError()})");
                }
                finally
                {
                    CloseHandle(handle);
                }
            }
            if (raised.Count > 0)
                ObsLog.Info($"cpu priority: time-critical: {string.Join(", ", raised)}");
        }
    }
}
