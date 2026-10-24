using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using CaptureApp.Settings;

namespace CaptureApp.App;

/// <summary>
/// Capture's mark: a replay arc and its arrow in grey around a record dot in the theme color, on a rounded plate in the
/// window's grey. Drawn for the settings window and for app.ico (<c>Capture.exe --write-icon</c>).
/// </summary>
public static class AppIconArt
{
    public static readonly int[] Sizes = [16, 20, 24, 32, 40, 48, 64, 128, 256];

    /// <summary>
    /// The arc and the arrow, in a 100-unit box (the same shape as the sidebar's Path in MainWindow.xaml): radius 30
    /// around the centre, from 3 o'clock clockwise through 300 degrees, the arrowhead pointing up into the gap.
    /// </summary>
    /// <param name="box">The 100-unit box, in pixels.</param>
    /// <param name="minStroke">The thinnest the arc may be drawn (small icons).</param>
    public static void DrawMark(Graphics g, Color color, RectangleF box, float minStroke = 0)
    {
        float u = box.Width / 100f;
        float x0 = box.X, y0 = box.Y;
        using (var pen = new Pen(color, Math.Max(11 * u, minStroke)) { StartCap = LineCap.Round, EndCap = LineCap.Round })
            g.DrawArc(pen, x0 + 20 * u, y0 + 20 * u, 60 * u, 60 * u, 0, 300);
        PointF[] head = [new(x0 + 80 * u, y0 + 34 * u), new(x0 + 70 * u, y0 + 50 * u), new(x0 + 90 * u, y0 + 50 * u)];
        using (var fill = new SolidBrush(color))
            g.FillPolygon(fill, head);
        using (var edge = new Pen(color, Math.Max(1, 3 * u)) { LineJoin = LineJoin.Round })
            g.DrawPolygon(edge, head);
    }

    /// <summary>The record dot in the middle of <see cref="DrawMark"/>'s box.</summary>
    public static void DrawDot(Graphics g, Color color, RectangleF box, float minRadius = 0)
    {
        float u = box.Width / 100f, r = Math.Max(13 * u, minRadius);
        float cx = box.X + 50 * u, cy = box.Y + 50 * u;
        using var brush = new SolidBrush(color);
        g.FillEllipse(brush, cx - r, cy - r, 2 * r, 2 * r);
    }

    public static Bitmap Draw(int size, uint accent)
    {
        var bmp = new Bitmap(size, size, PixelFormat.Format32bppArgb);
        using var g = Graphics.FromImage(bmp);
        g.SmoothingMode = SmoothingMode.AntiAlias;
        g.Clear(Color.Transparent);
        float w = size - 1, radius = size * 0.22f, edge = Math.Max(1, size * 0.02f);
        using (var plate = GdiShapes.Rounded(new RectangleF(0, 0, w, w), radius))
        {
            using var rim = new SolidBrush(Opaque(ThemeColors.Stroke));
            g.FillPath(rim, plate);
        }
        using (var inner = GdiShapes.Rounded(new RectangleF(edge, edge, w - 2 * edge, w - 2 * edge), radius - edge))
        {
            using var fill = new SolidBrush(Opaque(ThemeColors.Background));
            g.FillPath(fill, inner);
        }
        var box = new RectangleF(size * 0.17f, size * 0.17f, size * 0.66f, size * 0.66f);
        DrawMark(g, Opaque(ThemeColors.Mark), box, minStroke: 1.5f);
        DrawDot(g, Opaque(accent), box, minRadius: 1.6f);
        return bmp;
    }

    /// <summary>An .ico file (PNG frames) with the mark at every size in <see cref="Sizes"/>.</summary>
    public static byte[] Ico(uint accent = ThemeColors.Accent)
    {
        var frames = Sizes.Select(s =>
        {
            using var bmp = Draw(s, accent);
            using var png = new MemoryStream();
            bmp.Save(png, ImageFormat.Png);
            return png.ToArray();
        }).ToList();
        using var ms = new MemoryStream();
        using var w = new BinaryWriter(ms);
        w.Write((ushort)0);
        w.Write((ushort)1);
        w.Write((ushort)Sizes.Length);
        int offset = 6 + 16 * Sizes.Length;
        for (int i = 0; i < Sizes.Length; i++)
        {
            byte side = (byte)(Sizes[i] >= 256 ? 0 : Sizes[i]);
            w.Write(side);
            w.Write(side);
            w.Write((byte)0);
            w.Write((byte)0);
            w.Write((ushort)1);
            w.Write((ushort)32);
            w.Write((uint)frames[i].Length);
            w.Write((uint)offset);
            offset += frames[i].Length;
        }
        foreach (var f in frames)
            w.Write(f);
        w.Flush();
        return ms.ToArray();
    }

    static Color Opaque(uint rgb) => Color.FromArgb(255, (int)(rgb >> 16) & 0xFF, (int)(rgb >> 8) & 0xFF, (int)rgb & 0xFF);
}
