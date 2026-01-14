using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_HighContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FFEBF2";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#FEA9D3";
    public string OnPrimaryContainer => "#1F0013";
    // Secondary
    public string Secondary => "#D4F9D9";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#A7CCAD";
    public string OnSecondaryContainer => "#000F04";
    // Tertiary
    public string Tertiary => "#DFF9B6";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#B2CB8C";
    public string OnTertiaryContainer => "#060E00";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#12140B";
    public string SurfaceVariant => "#444937";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#12140B";
    public string SurfaceBright => "#4F5145";
    public string SurfaceTint => "#FFAFD6";
    // Background
    public string Background => "#12140B";
    public string OnBackground => "#E2E4D4";
    // Outline
    public string Outline => "#EEF2D9";
    public string OutlineVariant => "#C1C5AD";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E2E4D4";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#723255";
    // Primary Fixed
    public string PrimaryFixed => "#FFD8E8";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#FFAFD6";
    public string OnPrimaryFixedVariant => "#2A001A";
    // Secondary Fixed
    public string SecondaryFixed => "#C6ECCC";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#ABD0B1";
    public string OnSecondaryFixedVariant => "#001507";
    // Tertiary Fixed
    public string TertiaryFixed => "#D2ECA9";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#B6CF8F";
    public string OnTertiaryFixedVariant => "#0A1400";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1E2117";
    public string SurfaceContainer => "#2F3227";
    public string SurfaceContainerHigh => "#3A3D31";
    public string SurfaceContainerHighest => "#45483C";
}
