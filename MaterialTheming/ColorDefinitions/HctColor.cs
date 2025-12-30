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
        set => SetInternalState(HctSolver.SolveToInt(value, chroma, tone));
    }

    public double Chroma
    {
        get => chroma;
        set => SetInternalState(HctSolver.SolveToInt(hue, value, tone));
    }

    public double Tone
    {
        get => tone;
        set => SetInternalState(HctSolver.SolveToInt(hue, chroma, value));
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
        int argb = HctSolver.SolveToInt(hue, chroma, tone);
        return FromArgb(argb);
    }
    /**
     * Create an HCT color from a color.
     *
     * @param rgb RGB representation of a color.
     * @return HCT representation of a color in default viewing conditions
     */
    public static HctColor FromRgbColor(RgbColor rgb)
    {
        var argb = rgb.ToArgb();
        return FromArgb(argb);
    }
    /**
     * Create an HCT color from a color.
     *
     * @param argb ARGB representation of a color.
     * @return HCT representation of a color in default viewing conditions
     */
    public static HctColor FromArgb(int argb)
    {
        return new HctColor(argb);
    }

    private HctColor(int argb)
    {
        SetInternalState(argb);
    }

    public RgbColor ToRgbColor()
    {
        int argb = HctSolver.SolveToInt(hue, chroma, tone);
        return RgbColor.FromArgb(argb);
    }

    public int ToArgb()
    {
        return HctSolver.SolveToInt(hue, chroma, tone);
    }

    public override string ToString()
    {
        return $"HCT({(int)Math.Round(hue)}, {(int)Math.Round(chroma)}, {(int)Math.Round(tone)})";
    }

    private void SetInternalState(int argb)
    {
        Cam16 cam = Cam16.FromInt(argb);
        hue = cam.GetHue();
        chroma = cam.GetChroma();
        tone = ColorUtils.LstarFromArgb(argb);
    }

    public static bool operator ==(HctColor colorOne, HctColor colorTwo)
    {
        return colorOne.Equals(colorTwo);
    }
    public static bool operator !=(HctColor colorOne, HctColor colorTwo)
    {
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
