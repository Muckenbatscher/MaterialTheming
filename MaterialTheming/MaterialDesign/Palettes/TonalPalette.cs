using MaterialTheming.MaterialDesign.Hct;

namespace MaterialTheming.MaterialDesign.Palettes;

internal class TonalPalette
{
    /// <summary>
    /// The hue of the Tonal Palette, in HCT. Ranges from 0 to 360.
    /// </summary>
    public double Hue { get; }

    /// <summary>
    /// The chroma of the Tonal Palette, in HCT. Ranges from 0 to ~130 (for sRGB gamut).
    /// </summary>
    public double Chroma { get; }

    /// <summary>
    /// The key color is the first tone, starting from T50, that matches the palette's chroma.
    /// </summary>
    public HctColor KeyColor { get; }

    private TonalPalette(double hue, double chroma, HctColor keyColor)
    {
        Hue = hue;
        Chroma = chroma;
        KeyColor = keyColor;
    }


    /// <summary>
    /// Create tones using a HCT color.
    /// </summary>
    /// <param name="hct">HCT representation of a color.</param>
    /// <returns>Tones matching that color's hue and chroma.</returns>
    public static TonalPalette FromHct(HctColor hct)
    {
        return new TonalPalette(hct.Hue, hct.Chroma, hct);
    }

    /// <summary>
    /// Create tones from a defined HCT hue and chroma.
    /// </summary>
    /// <param name="hue">HCT hue</param>
    /// <param name="chroma">HCT chroma</param>
    /// <returns>Tones matching hue and chroma.</returns>
    public static TonalPalette FromHueAndChroma(double hue, double chroma)
    {
        var hctColor = KeyColorCalculation.Create(hue, chroma);
        return new TonalPalette(hue, chroma, hctColor);
    }

    /// <summary>
    /// Create an RGB color with HCT hue and chroma of this Tones instance, and the provided HCT tone.
    /// </summary>
    /// <param name="tone">HCT tone, measured from 0 to 100.</param>
    /// <returns>ARGB representation of a color with that tone.</returns>
    public RgbColor Tone(int tone)
    {
        RgbColor color;
        // IsYellow check assumes Hct class has this static method
        if (tone == 99 && HctColorCategorization.IsYellow(Hue))
        {
            color = AverageRgb(Tone(98), Tone(100));
        }
        else
        {
            color = HctColor.From(Hue, Chroma, tone).ToRgbColor();
        }
        return color;
    }

    /// <summary>
    /// Given a tone, use hue and chroma of palette to create a color, and return it as HCT.
    /// </summary>
    public HctColor GetHct(double tone)
    {
        return HctColor.From(Hue, Chroma, tone);
    }

    private static RgbColor AverageRgb(RgbColor argb1, RgbColor argb2)
    {
        var red = (byte)Math.Round((argb1.Red + argb2.Red) / 2.0);
        var green = (byte)Math.Round((argb1.Green + argb2.Green) / 2.0);
        var blue = (byte)Math.Round((argb1.Blue + argb2.Blue) / 2.0);
        return RgbColor.FromRgb(red, green, blue);
    }
}
