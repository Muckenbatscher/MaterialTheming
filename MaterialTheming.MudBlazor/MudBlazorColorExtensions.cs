using MudBlazor.Utilities;

namespace MaterialTheming;

/// <summary>
/// Provides conversions between <see cref="RgbColor"/> and <see cref="MudColor"/>.
/// </summary>
public static class RgbColorMudBlazorExtensions
{
    extension(RgbColor rgbColor)
    {
        /// <summary>
        /// Converts the <see cref="RgbColor"/> to a <see cref="MudColor"/>.
        /// </summary>
        /// <returns>A <see cref="MudColor"/> with the same RGB values.</returns>
        public MudColor ToMudColor()
        {
            return new MudColor(r: rgbColor.Red, g: rgbColor.Green, b: rgbColor.Blue, a: byte.MaxValue);
        }

        /// <summary>
        /// Create a new instance of the <see cref="RgbColor"/> 
        /// with the RGB values from an existing <see cref="MudColor"/>.
        /// </summary>
        /// <param name="color">The color with its red, green and blue channel values.</param>
        /// <returns>
        /// A <see cref="RgbColor"/> with the RGB values from the <see cref="MudColor"/>.
        /// </returns>
        public static RgbColor FromMudColor(MudColor color)
        {
            return color.ToRgbColor();
        }
    }
}

/// <summary>
/// Provides conversions between <see cref="HctColor"/> and <see cref="MudColor"/>.
/// </summary>
public static class HctColorMudBlazorExtensions
{
    extension(HctColor hctColor)
    {
        /// <summary>
        /// Converts the <see cref="HctColor"/> to a <see cref="MudColor"/>.
        /// </summary>
        /// <returns>A <see cref="MudColor"/> converted to RGB color space.</returns>
        public MudColor ToMudColor()
        {
            return hctColor.ToRgbColor().ToMudColor();
        }

        /// <summary>
        /// Create a new instance of the <see cref="HctColor"/> 
        /// converted from RGB color space of an existing <see cref="MudColor"/>.
        /// </summary>
        /// <param name="color">The color with its red, green and blue channel values.</param>
        /// <returns>A <see cref="HctColor"/> converted from RGB color space.</returns>
        public static HctColor FromMudColor(MudColor color)
        {
            return color.ToHctColor();
        }
    }
}

/// <summary>
/// Provides conversions from <see cref="MudColor"/> to <see cref="RgbColor"/> or <see cref="HctColor"/>.
/// </summary>
public static class MudColorExtensions
{
    extension(MudColor color)
    {
        /// <summary>
        /// Converts the <see cref="MudColor"/> to a <see cref="RgbColor"/>.
        /// </summary>
        /// <returns>A <see cref="RgbColor"/> with the same RGB values.</returns>
        public RgbColor ToRgbColor()
        {
            return RgbColor.FromRgb(color.R, color.G, color.B);
        }

        /// <summary>
        /// Converts the <see cref="MudColor"/> to a <see cref="HctColor"/>.
        /// </summary>
        /// <returns>A <see cref="HctColor"/> converted from RGB color space.</returns>
        public HctColor ToHctColor()
        {
            return color.ToRgbColor().ToHct();
        }
    }
}