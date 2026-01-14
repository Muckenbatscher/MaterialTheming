using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class LightMode_HighContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#4B2000";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#783600";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#46230C";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#683F26";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#2C2E00";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#494D00";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F5";
    public string SurfaceVariant => "#F8DDCF";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#C6B6AE";
    public string SurfaceBright => "#FFF8F5";
    public string SurfaceTint => "#984804";
    // Background
    public string Background => "#FFF8F5";
    public string OnBackground => "#221A15";
    // Outline
    public string Outline => "#382920";
    public string OutlineVariant => "#57453B";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#382E29";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#FFB68B";
    // Primary Fixed
    public string PrimaryFixed => "#783600";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#552500";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#683F26";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#4D2911";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#494D00";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#323500";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFEDE5";
    public string SurfaceContainer => "#F1DFD7";
    public string SurfaceContainerHigh => "#E2D1C9";
    public string SurfaceContainerHighest => "#D4C3BB";
}
