using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class LightMode_HighContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#600004";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#911615";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#531814";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#78342E";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#003236";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#005258";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F7";
    public string SurfaceVariant => "#FEDAD6";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#CBB3B1";
    public string SurfaceBright => "#FFF8F7";
    public string SurfaceTint => "#B02D28";
    // Background
    public string Background => "#FFF8F7";
    public string OnBackground => "#261817";
    // Outline
    public string Outline => "#3C2724";
    public string OutlineVariant => "#5C4340";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#3C2D2B";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#FFB4AB";
    // Primary Fixed
    public string PrimaryFixed => "#911615";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#6D0006";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#78342E";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#5B1E1A";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#005258";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#00393E";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFEDEA";
    public string SurfaceContainer => "#F6DDDA";
    public string SurfaceContainerHigh => "#E8CFCC";
    public string SurfaceContainerHighest => "#D9C1BE";
}
