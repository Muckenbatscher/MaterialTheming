using MaterialTheming.MaterialDesign.HctConversion;

namespace MaterialTheming.ColorDefinitions;

public class HctColor
{
    private double hue;
    private double chroma;
    private double tone;

    public double Hue
    {
        get => hue;
        set => SetInternalState(HctSolver.SolveToRgb(value, chroma, tone));
    }

    public double Chroma
    {
        get => chroma;
        set => SetInternalState(HctSolver.SolveToRgb(hue, value, tone));
    }

    public double Tone
    {
        get => tone;
        set => SetInternalState(HctSolver.SolveToRgb(hue, chroma, value));
    }

    /**
     * Create an HCT color from hue, chroma, and tone.
     *
     * @param hue 0 <= hue < 360; invalid values are corrected.
     * @param chroma 0 <= chroma < ?; Informally, colorfulness. The color returned may be lower than
     * the requested chroma. Chroma has a different maximum for any given hue and tone.
     * @param tone 0 <= tone <= 100; invalid values are corrected.
     * @return HCT representation of a color in default viewing conditions.
     */
    public static HctColor From(double hue, double chroma, double tone)
    {
        var rgb = HctSolver.SolveToRgb(hue, chroma, tone);
        return FromRgbColor(rgb);
    }
    /**
     * Create an HCT color from a color.
     *
     * @param rgb RGB representation of a color.
     * @return HCT representation of a color in default viewing conditions
     */
    public static HctColor FromRgbColor(RgbColor rgb)
    {
        return new HctColor(rgb);
    }

    private HctColor(RgbColor rgb)
    {
        SetInternalState(rgb);
    }

    public RgbColor ToRgbColor()
    {
        return HctSolver.SolveToRgb(hue, chroma, tone);
    }

    public int ToArgb()
    {
        var rgb = HctSolver.SolveToRgb(hue, chroma, tone);
        return rgb.ToArgb();
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
