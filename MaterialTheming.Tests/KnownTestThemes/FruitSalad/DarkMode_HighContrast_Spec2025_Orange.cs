using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_HighContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFEBEF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#FFABC4";
    public string OnPrimaryContainer => "#20000C";
    // Secondary
    public string Secondary => "#FFEBEF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#FEABC4";
    public string OnSecondaryContainer => "#20000C";
    // Tertiary
    public string Tertiary => "#FFECE3";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#FFB181";
    public string OnTertiaryContainer => "#190600";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#1D1009";
    public string SurfaceVariant => "#5C4131";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#1D1009";
    public string SurfaceBright => "#5E4C42";
    public string SurfaceTint => "#FFB1C8";
    // Background
    public string Background => "#1D1009";
    public string OnBackground => "#F8DDD0";
    // Outline
    public string Outline => "#FFECE3";
    public string OutlineVariant => "#E1BBA6";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F8DDD0";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#7C2A4A";
    // Primary Fixed
    public string PrimaryFixed => "#FFD9E2";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#FFB1C8";
    public string OnPrimaryFixedVariant => "#2B0012";
    // Secondary Fixed
    public string SecondaryFixed => "#FFD9E2";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#FFB1C8";
    public string OnSecondaryFixedVariant => "#2B0012";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFDBC8";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#FFB68B";
    public string OnTertiaryFixedVariant => "#220A00";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#2A1D14";
    public string SurfaceContainer => "#3D2D24";
    public string SurfaceContainerHigh => "#48382E";
    public string SurfaceContainerHighest => "#554339";
}
