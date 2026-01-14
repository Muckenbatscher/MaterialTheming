using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_HighContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#C5FEC6";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#99D09B";
    public string OnPrimaryContainer => "#000F02";
    // Secondary
    public string Secondary => "#E1F6DE";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#B4C8B2";
    public string OnSecondaryContainer => "#020E03";
    // Tertiary
    public string Tertiary => "#CEF7FF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#9DCAD2";
    public string OnTertiaryContainer => "#000E10";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#101510";
    public string SurfaceVariant => "#424940";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#101510";
    public string SurfaceBright => "#4D514B";
    public string SurfaceTint => "#9CD49F";
    // Background
    public string Background => "#101510";
    public string OnBackground => "#E0E4DB";
    // Outline
    public string Outline => "#EBF2E7";
    public string OutlineVariant => "#BDC5BA";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E0E4DB";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#1F5229";
    // Primary Fixed
    public string PrimaryFixed => "#B8F1B9";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#9CD49F";
    public string OnPrimaryFixedVariant => "#001504";
    // Secondary Fixed
    public string SecondaryFixed => "#D4E8D1";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#B8CCB5";
    public string OnSecondaryFixedVariant => "#051407";
    // Tertiary Fixed
    public string TertiaryFixed => "#BDEAF3";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#A1CED6";
    public string OnTertiaryFixedVariant => "#001417";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1C211C";
    public string SurfaceContainer => "#2D322C";
    public string SurfaceContainerHigh => "#383D37";
    public string SurfaceContainerHighest => "#434842";
}
