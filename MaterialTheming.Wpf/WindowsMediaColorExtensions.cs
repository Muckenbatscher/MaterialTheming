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
        /// <returns>A <see cref="Color"/> with the same RGB values.</returns>
        public Color ToColor()
        {
            return Color.FromRgb(rgbColor.Red, rgbColor.Green, rgbColor.Blue);
        }
    }

    extension(HctColor hctColor)
    {
        /// <summary>
        /// Converts the <see cref="HctColor"/> to a native <see cref="Color"/>.
        /// </summary>
        /// <returns>A <see cref="Color"/> converted to RGB color space.</returns>
        public Color ToColor() => hctColor.ToRgbColor().ToColor();
    }

    extension(Color color)
    {
        /// <summary>
        /// Converts the native <see cref="Color"/> to a <see cref="RgbColor"/>.
        /// </summary>
        /// <returns>A <see cref="RgbColor"/> with the same RGB values.</returns>
        public RgbColor ToRgbColor()
        {
            return RgbColor.FromRgb(color.R, color.G, color.B);
        }

        /// <summary>
        /// Converts the native <see cref="Color"/> to a <see cref="HctColor"/>.
        /// </summary>
        /// <returns>A <see cref="HctColor"/> converted from RGB color space.</returns>
        public HctColor ToHctColor()
        {
            return color.ToRgbColor().ToHct();
        }
    }
}