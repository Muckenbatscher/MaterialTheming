using System.Windows.Media;

namespace MaterialTheming;

/// <summary>
/// Provides extension methods for converting between 
/// <see cref="RgbColor"/>, <see cref="HctColor"/>, and the native <see cref="Color"/>.
/// </summary>
public static class WindowsMediaColorExtensions
{
    extension(RgbColor rgbColor)
    {
        /// <summary>
        /// Converts the <see cref="RgbColor"/> to a native <see cref="Color"/>.
        /// </summary>
        /// <returns></returns>
        public Color ToColor()
        {
            return Color.FromRgb(rgbColor.Red, rgbColor.Green, rgbColor.Blue);
        }
    }

    extension(Color color)
    {
        /// <summary>
        /// Converts the native <see cref="Color"/> to a <see cref="RgbColor"/>.
        /// </summary>
        /// <returns></returns>
        public RgbColor ToRgbColor()
        {
            return RgbColor.FromRgb(color.R, color.G, color.B);
        }
    }

    extension(HctColor hctColor)
    {
        /// <summary>
        /// Converts the <see cref="HctColor"/> to a native <see cref="Color"/>.
        /// </summary>
        /// <returns></returns>
        public Color ToColor() => hctColor.ToRgbColor().ToColor();
    }

    extension(Color color)
    {
        /// <summary>
        /// Converts the native <see cref="Color"/> to a <see cref="HctColor"/>.
        /// </summary>
        /// <returns></returns>
        public HctColor ToHctColor() => color.ToRgbColor().ToHct();
    }
}