using MaterialTheming.MaterialDesign.HctConversion;

namespace MaterialTheming.ColorDefinitions;

/// <summary>
/// A color representation in the HCT format.
/// <para>
/// <b>Hue</b> - The general color.<br/>
/// <b>Chroma</b> - How colorful the color appears.<br/>
/// <b>Tone</b> - How light or dark the color appears.<br/>
/// </para>
/// </summary>
public class HctColor
{
    private double hue;
    private double chroma;
    private double tone;

    /// <summary>
    /// The position of the color on the color wheel. <br/>
    /// Values are degrees and therefore range from <c>0</c> to <c>360</c>.
    /// </summary>
    public double Hue
    {
        get => hue;
        set => SetInternalState(HctSolver.SolveToRgb(value, chroma, tone));
    }

    /// <summary>
    /// The perceived colorfulness of the color.<br/>
    /// The maximum is dependendent from the <see cref="Chroma"/> and <see cref="Tone"/>. 
    /// But generally values are between <c>0</c> (least colorful) and <c>120</c> (most colorful).
    /// </summary>
    /// <remarks>If the requested chroma is not reachable based on the set hue and tone 
    /// the actual value for chroma might be lower.</remarks>
    public double Chroma
    {
        get => chroma;
        set => SetInternalState(HctSolver.SolveToRgb(hue, value, tone));
    }

    /// <summary>
    /// The perceived lightness of the color.<br/>
    /// Values range from <c>0</c> (darkest) to <c>100</c> (brightest).
    /// </summary>
    public double Tone
    {
        get => tone;
        set => SetInternalState(HctSolver.SolveToRgb(hue, chroma, value));
    }

    /// <summary>
    /// Create an HCT color from hue, chroma and tone
    /// </summary>
    /// <param name="hue">Target hue between 0 and 360 degrees. Invalid values are corrected.</param>
    /// <param name="chroma">Target chroma between 0 and roughly 120. The color returned may be lower than the target chroma.
    /// Chroma has a different maximum depending on the requested hue and tone.</param>
    /// <param name="tone">Target tone between 0 and 100. Invalid values are corrected.</param>
    /// <returns>A <see cref="HctColor"/> with values for hue, chroma and tone as close to the specified values as possible.</returns>
    public static HctColor From(double hue, double chroma, double tone)
    {
        var rgb = HctSolver.SolveToRgb(hue, chroma, tone);
        return FromRgbColor(rgb);
    }

    /// <summary>
    /// Create a color in HCT representation from a color in RGB representation.
    /// </summary>
    /// <param name="rgb">A color in RGB representation</param>
    /// <returns><see cref="HctColor"/> representation of a color in default viewing conditions.</returns>
    public static HctColor FromRgbColor(RgbColor rgb)
    {
        return new HctColor(rgb);
    }

    private HctColor(RgbColor rgb)
    {
        SetInternalState(rgb);
    }

    /// <summary>
    /// Create color in RGB representation in default viewing conditions.
    /// </summary>
    /// <returns>A color in RGB representation of the <see cref="HctColor"/> in default viewing conditions.</returns>
    public RgbColor ToRgbColor()
    {
        return HctSolver.SolveToRgb(hue, chroma, tone);
    }

    public override string ToString()
    {
        return $"HCT({(int)Math.Round(hue)}, {(int)Math.Round(chroma)}, {(int)Math.Round(tone)})";
    }

    private void SetInternalState(RgbColor rgb)
    {
        Cam16 cam = Cam16.FromRgbColor(rgb);
        hue = cam.GetHue();
        chroma = cam.GetChroma();
        tone = ColorUtils.LstarFromRgb(rgb);
    }

    public static bool operator ==(HctColor? colorOne, HctColor? colorTwo)
    {
        if (colorOne is null && colorTwo is null)
            return true;
        if (colorOne is null || colorTwo is null)
            return false;
        return colorOne.Equals(colorTwo);
    }
    public static bool operator !=(HctColor? colorOne, HctColor? colorTwo)
    {
        if (colorOne is null && colorTwo is null)
            return false;
        if (colorOne is null || colorTwo is null)
            return true;
        return !colorOne.Equals(colorTwo);
    }
    public override bool Equals(object? obj)
    {
        return obj is HctColor color
            && Hue == color.Hue
            && Chroma == color.Chroma
            && Tone == color.Tone;
    }
    public override int GetHashCode() => HashCode.Combine(Hue, Chroma, Tone);
}
