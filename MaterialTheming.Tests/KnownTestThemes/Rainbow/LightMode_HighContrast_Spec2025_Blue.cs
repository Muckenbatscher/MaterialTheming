using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class LightMode_HighContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#002C58";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#00498B";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#222D3D";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#3F4A5B";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#392441";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#584160";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F9F9F9";
    public string SurfaceVariant => "#E2E2E2";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#B9B9B9";
    public string SurfaceBright => "#F9F9F9";
    public string SurfaceTint => "#205FA6";
    // Background
    public string Background => "#F9F9F9";
    public string OnBackground => "#1B1B1B";
    // Outline
    public string Outline => "#2C2C2C";
    public string OutlineVariant => "#494949";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#303030";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#A6C8FF";
    // Primary Fixed
    public string PrimaryFixed => "#00498B";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#003363";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#3F4A5B";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#293343";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#584160";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#402B48";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F1F1F1";
    public string SurfaceContainer => "#E2E2E2";
    public string SurfaceContainerHigh => "#D4D4D4";
    public string SurfaceContainerHighest => "#C6C6C6";
}
