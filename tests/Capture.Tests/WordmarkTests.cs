
namespace CaptureApp.Tests;

/// <summary>The name as drawn in the sidebar: "Capture" in Sora Bold, the same Latin name in every language.</summary>
public static class WordmarkTests
{
    static string Assets
    {
        get
        {
            var dir = new DirectoryInfo(AppContext.BaseDirectory);
            while (dir != null && !File.Exists(Path.Combine(dir.FullName, "Capture.sln")))
                dir = dir.Parent;
            return Path.Combine(dir!.FullName, "src", "Capture", "Ui", "Assets");
        }
    }

    [Test]
    public static void The_name_is_drawn_large_in_light_text_on_a_clear_background()
    {
        string path = Path.Combine(Assets, "wordmark.png");
        Assert.True(File.Exists(path), path);
        using var image = new System.Drawing.Bitmap(path);
        Assert.True(image.Height >= 110, $"drawn large enough to stay sharp at 200% and more ({image.Height} px)");
        Assert.Equal(0, (int)image.GetPixel(0, 0).A, "clear background");
        bool light = false;
        for (int x = 0; x < image.Width && !light; x += 2)
            for (int y = 0; y < image.Height && !light; y += 2)
            {
                var p = image.GetPixel(x, y);
                light = p.A > 200 && p.R > 220 && p.G > 215 && p.B > 205;
            }
        Assert.True(light, "the name in the window's light text color");
    }
}
