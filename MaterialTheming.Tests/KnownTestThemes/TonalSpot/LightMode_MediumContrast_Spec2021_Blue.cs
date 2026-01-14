using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_MediumContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#0C3765";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#4C6EA0";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#2D3747";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#636D80";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#442E4C";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#7D6485";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F9F9FF";
    public string SurfaceVariant => "#E0E2EC";
    public string OnSurface => "#0F1116";
    public string OnSurfaceVariant => "#33363D";
    public string SurfaceDim => "#C5C6CD";
    public string SurfaceBright => "#F9F9FF";
    public string SurfaceTint => "#3D5F90";
    // Background
    public string Background => "#F9F9FF";
    public string OnBackground => "#191C20";
    // Outline
    public string Outline => "#4F525A";
    public string OutlineVariant => "#6A6D75";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2E3035";
    public string InverseOnSurface => "#F0F0F7";
    public string InversePrimary => "#A6C8FF";
    // Primary Fixed
    public string PrimaryFixed => "#4C6EA0";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#335685";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#636D80";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#4B5567";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#7D6485";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#644C6C";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F3F3FA";
    public string SurfaceContainer => "#E7E8EE";
    public string SurfaceContainerHigh => "#DCDCE3";
    public string SurfaceContainerHighest => "#D0D1D8";
}
