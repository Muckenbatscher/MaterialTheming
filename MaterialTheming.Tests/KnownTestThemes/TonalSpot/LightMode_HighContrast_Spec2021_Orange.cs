namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_HighContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#4B2000";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#723A13";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#3E2718";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#5E4333";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#2E2E05";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#4C4B20";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F5";
    public string SurfaceVariant => "#F4DED3";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#C5B6AE";
    public string SurfaceBright => "#FFF8F5";
    public string SurfaceTint => "#8C4F26";
    // Background
    public string Background => "#FFF8F5";
    public string OnBackground => "#221A15";
    // Outline
    public string Outline => "#362A23";
    public string OutlineVariant => "#55463E";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#382E29";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#FFB68B";
    // Primary Fixed
    public string PrimaryFixed => "#723A13";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#552500";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#5E4333";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#452D1E";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#4C4B20";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#35340B";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFEDE5";
    public string SurfaceContainer => "#F0DFD7";
    public string SurfaceContainerHigh => "#E2D1C9";
    public string SurfaceContainerHighest => "#D3C3BC";
}
