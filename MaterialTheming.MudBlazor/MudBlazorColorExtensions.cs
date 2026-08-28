using MudBlazor.Utilities;

namespace MaterialTheming;

/// <summary>
/// Provides extension methods for converting between 
/// <see cref="RgbColor"/>, <see cref="HctColor"/>, and <see cref="MudColor"/>.
/// </summary>
public static class MudBlazorColorExtensions
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
    }

    extension(HctColor hctColor)
    {
        /// <summary>
        /// Converts the <see cref="HctColor"/> to a <see cref="MudColor"/>.
        /// </summary>
        /// <returns>A <see cref="MudColor"/> converted to RGB color space.</returns>
        public MudColor ToMudColor() => hctColor.ToRgbColor().ToMudColor();
    }

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