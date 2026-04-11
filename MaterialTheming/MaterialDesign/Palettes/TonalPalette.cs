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

    private TonalPalette(double hue, double chroma)
    {
        Hue = hue;
        Chroma = chroma;
    }

    /// <summary>
    /// Create tones using a HCT color.
    /// </summary>
    /// <param name="hct">HCT representation of a color.</param>
    /// <returns>Tones matching that color's hue and chroma.</returns>
    public static TonalPalette FromHct(HctColor hct)
    {
        return new TonalPalette(hct.Hue, hct.Chroma);
    }

    /// <summary>
    /// Create tones from a defined HCT hue and chroma.
    /// </summary>
    /// <param name="hue">HCT hue</param>
    /// <param name="chroma">HCT chroma</param>
    /// <returns>Tones matching hue and chroma.</returns>
    public static TonalPalette FromHueAndChroma(double hue, double chroma)
    {
        return new TonalPalette(hue, chroma);
    }

    /// <summary>
    /// Given a tone, use hue and chroma of palette to create a color, and return it as HCT.
    /// </summary>
    public HctColor GetHct(double tone)
    {
        if (tone == 99.0 && HctColorCategorization.IsYellow(Hue))
            return GetHighToneYellowColor();
        else
            return HctColor.From(Hue, Chroma, tone);
    }

    private HctColor GetHighToneYellowColor() 
    {
        var tone98 = HctColor.From(Hue, Chroma, 98).ToRgbColor();
        var tone100 = HctColor.From(Hue, Chroma, 100).ToRgbColor();
        var average = RgbColor.AverageColor(tone98, tone100);
        return average.ToHct();
    }
}
