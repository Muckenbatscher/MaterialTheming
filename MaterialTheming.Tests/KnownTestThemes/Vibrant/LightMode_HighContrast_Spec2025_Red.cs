using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_HighContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#480002";
    public string OnPrimary => "#FFC7C1";
    public string PrimaryContainer => "#9C1717";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#470014";
    public string OnSecondary => "#FFC6CC";
    public string SecondaryContainer => "#8E293F";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#330057";
    public string OnTertiary => "#E9C9FF";
    public string TertiaryContainer => "#6A3497";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#470013";
    public string OnError => "#FFC6CB";
    public string ErrorContainer => "#A00035";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF4F4";
    public string SurfaceVariant => "#FFD2D6";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#3A1219";
    public string SurfaceDim => "#FFC6CC";
    public string SurfaceBright => "#FFF4F4";
    public string SurfaceTint => "#480002";
    // Background
    public string Background => "#FFF4F4";
    public string OnBackground => "#000000";
    // Outline
    public string Outline => "#613138";
    public string OutlineVariant => "#734047";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#240209";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#FFB1A8";
    // Primary Fixed
    public string PrimaryFixed => "#9C1717";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#8B060C";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#8E293F";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#7F1D34";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#6A3497";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#5E268A";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFECED";
    public string SurfaceContainer => "#FFE1E3";
    public string SurfaceContainerHigh => "#FFD9DC";
    public string SurfaceContainerHighest => "#FFD2D6";
}
