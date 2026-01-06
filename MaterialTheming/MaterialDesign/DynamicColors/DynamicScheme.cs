using MaterialTheming.ColorDefinitions;
using MaterialTheming.MaterialDesign.HctConversion;
using MaterialTheming.MaterialDesign.Palettes;

namespace MaterialTheming.MaterialDesign.DynamicColors;

internal class DynamicScheme
{
    public static readonly Platform DefaultPlatform = Platform.Phone;

    public HctColor HctSourceColor { get; }
    public Variant Variant { get; }
    public bool IsDark { get; }
    public Platform Platform { get; }
    public double ContrastLevel { get; }

    public TonalPalette PrimaryPalette { get; }
    public TonalPalette SecondaryPalette { get; }
    public TonalPalette TertiaryPalette { get; }
    public TonalPalette NeutralPalette { get; }
    public TonalPalette NeutralVariantPalette { get; }
    public TonalPalette ErrorPalette { get; }

    public DynamicScheme(
        HctColor sourceColorHct,
        Variant variant,
        bool isDark,
        double contrastLevel,
        TonalPalette primaryPalette,
        TonalPalette secondaryPalette,
        TonalPalette tertiaryPalette,
        TonalPalette neutralPalette,
        TonalPalette neutralVariantPalette,
        TonalPalette? errorPalette = null,
        Platform platform = Platform.Phone)
    {
        HctSourceColor = sourceColorHct;
        Variant = variant;
        IsDark = isDark;
        ContrastLevel = contrastLevel;
        Platform = platform;

        PrimaryPalette = primaryPalette;
        SecondaryPalette = secondaryPalette;
        TertiaryPalette = tertiaryPalette;
        NeutralPalette = neutralPalette;
        NeutralVariantPalette = neutralVariantPalette;
        ErrorPalette = errorPalette ?? TonalPalette.FromHueAndChroma(25.0, 84.0);
    }

    public static DynamicScheme From(DynamicScheme other, bool isDark)
    {
        return From(other, isDark, other.ContrastLevel);
    }

    public static DynamicScheme From(DynamicScheme other, bool isDark, double contrastLevel)
    {
        return new DynamicScheme(
            other.HctSourceColor,
            other.Variant,
            isDark,
            contrastLevel,
            other.PrimaryPalette,
            other.SecondaryPalette,
            other.TertiaryPalette,
            other.NeutralPalette,
            other.NeutralVariantPalette,
            other.ErrorPalette,
            other.Platform);
    }

    /// <summary>
    /// Returns a new hue based on a piecewise function and input color hue.
    /// </summary>
    public static double GetPiecewiseValue(double sourceHue, double[] hueBreakpoints, double[] hues)
    {
        int size = Math.Min(hueBreakpoints.Length - 1, hues.Length);
        for (int i = 0; i < size; i++)
        {
            if (sourceHue >= hueBreakpoints[i] && sourceHue < hueBreakpoints[i + 1])
                return MathUtils.SanitizeDegreesDouble(hues[i]);
        }
        return sourceHue;
    }

    /// <summary>
    /// Returns a shifted hue based on a piecewise function and input color hue.
    /// </summary>
    public static double GetRotatedHue(HctColor sourceColorHct, double[] hueBreakpoints, double[] rotations)
    {
        double sourceHue = sourceColorHct.Hue;
        double calculatedRotation = GetPiecewiseValue(sourceHue, hueBreakpoints, rotations);
        return MathUtils.SanitizeDegreesDouble(sourceHue + calculatedRotation);
    }

    public HctColor GetHct(DynamicColor dynamicColor)
    {
        return dynamicColor.GetHct(this);
    }
}