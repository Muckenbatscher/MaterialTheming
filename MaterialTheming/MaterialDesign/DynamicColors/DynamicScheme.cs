using MaterialTheming.ColorDefinitions;
using MaterialTheming.MaterialDesign.HctConversion;
using MaterialTheming.MaterialDesign.Palettes;

namespace MaterialTheming.MaterialDesign.DynamicColors;

internal class DynamicScheme
{
    public enum SpecVersion
    {
        Spec2021,
        Spec2025
    }

    public static readonly SpecVersion DefaultSpecVersion = SpecVersion.Spec2021;
    public static readonly Platform DefaultPlatform = Platform.Phone;

    public RgbColor SourceColorRgb { get; }
    public HctColor HctSourceColor { get; }
    public Variant Variant { get; }
    public bool IsDark { get; }
    public Platform Platform { get; }
    public double ContrastLevel { get; }
    public SpecVersion Version { get; }

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
        Platform platform = Platform.Phone,
        SpecVersion specVersion = SpecVersion.Spec2021)
    {
        SourceColorRgb = sourceColorHct.ToRgbColor();
        HctSourceColor = sourceColorHct;
        Variant = variant;
        IsDark = isDark;
        ContrastLevel = contrastLevel;
        Platform = platform;
        Version = MaybeFallbackSpecVersion(specVersion, variant);

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
            other.Platform,
            other.Version);
    }

    private static SpecVersion MaybeFallbackSpecVersion(SpecVersion specVersion, Variant variant)
    {
        switch (variant)
        {
            case Variant.Expressive:
            case Variant.Vibrant:
            case Variant.TonalSpot:
            case Variant.Neutral:
                return specVersion;
            default:
                return SpecVersion.Spec2021;
        }
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