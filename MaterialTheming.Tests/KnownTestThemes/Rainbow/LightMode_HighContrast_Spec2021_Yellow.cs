using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class LightMode_HighContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#2E2E00";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#4D4C00";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#2E2D14";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#4B4A2F";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#063325";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#285141";
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
    public string SurfaceTint => "#636100";
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
    public string InversePrimary => "#CECB56";
    // Primary Fixed
    public string PrimaryFixed => "#4D4C00";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#353400";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#4B4A2F";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#34341A";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#285141";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#0F3A2B";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F1F1F1";
    public string SurfaceContainer => "#E2E2E2";
    public string SurfaceContainerHigh => "#D4D4D4";
    public string SurfaceContainerHighest => "#C6C6C6";
}
