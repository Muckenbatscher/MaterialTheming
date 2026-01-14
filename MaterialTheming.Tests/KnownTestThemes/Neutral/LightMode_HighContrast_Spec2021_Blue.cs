using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_HighContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#262C38";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#434956";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#292C33";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#464951";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#222D3D";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#3F4A5B";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FBF8FA";
    public string SurfaceVariant => "#E4E2E3";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#BAB8BA";
    public string SurfaceBright => "#FBF8FA";
    public string SurfaceTint => "#585F6B";
    // Background
    public string Background => "#FBF8FA";
    public string OnBackground => "#1B1B1D";
    // Outline
    public string Outline => "#2C2C2D";
    public string OutlineVariant => "#49494A";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#303032";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#C0C7D5";
    // Primary Fixed
    public string PrimaryFixed => "#434956";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#2C333E";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#464951";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#2F333A";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#3F4A5B";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#293343";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F3F0F1";
    public string SurfaceContainer => "#E4E2E3";
    public string SurfaceContainerHigh => "#D6D4D5";
    public string SurfaceContainerHighest => "#C8C6C7";
}
