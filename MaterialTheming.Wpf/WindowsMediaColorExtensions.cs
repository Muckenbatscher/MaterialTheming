using System.Windows.Media;

namespace MaterialTheming;

public static class WindowsMediaColorExtensions
{
    extension(RgbColor rgbColor)
    {
        public Color ToColor()
        {
            return Color.FromRgb(rgbColor.Red, rgbColor.Green, rgbColor.Blue);
        }
    }

    extension(Color color)
    {
        public RgbColor ToRgbColor()
        {
            return RgbColor.FromRgb(color.R, color.G, color.B);
        }
    }

    extension(HctColor hctColor)
    {
        public Color ToColor() => hctColor.ToRgbColor().ToColor();
    }

    extension(Color color)
    {
        public HctColor ToHctColor() => color.ToRgbColor().ToHct();
    }
}