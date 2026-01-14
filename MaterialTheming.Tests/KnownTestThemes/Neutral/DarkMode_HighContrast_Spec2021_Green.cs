using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_HighContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#E6F4E2";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#B9C6B6";
    public string OnPrimaryContainer => "#040E05";
    // Secondary
    public string Secondary => "#EBF2E7";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#BDC5BA";
    public string OnSecondaryContainer => "#070D07";
    // Tertiary
    public string Tertiary => "#E1F6DE";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#B4C8B2";
    public string OnTertiaryContainer => "#020E03";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#131412";
    public string SurfaceVariant => "#464745";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#131412";
    public string SurfaceBright => "#50504E";
    public string SurfaceTint => "#BDCABA";
    // Background
    public string Background => "#131412";
    public string OnBackground => "#E4E2DF";
    // Outline
    public string Outline => "#F1F0ED";
    public string OutlineVariant => "#C4C2C0";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E4E2DF";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#3F4B3E";
    // Primary Fixed
    public string PrimaryFixed => "#D9E6D5";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#BDCABA";
    public string OnPrimaryFixedVariant => "#09140A";
    // Secondary Fixed
    public string SecondaryFixed => "#DDE5D9";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#C1C9BE";
    public string OnSecondaryFixedVariant => "#0C130C";
    // Tertiary Fixed
    public string TertiaryFixed => "#D4E8D1";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#B8CCB5";
    public string OnTertiaryFixedVariant => "#051407";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1F201E";
    public string SurfaceContainer => "#30312F";
    public string SurfaceContainerHigh => "#3B3C3A";
    public string SurfaceContainerHighest => "#464745";
}
