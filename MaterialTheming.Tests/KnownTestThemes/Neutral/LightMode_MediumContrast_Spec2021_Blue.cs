using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_MediumContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#303642";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#676D7A";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#33363D";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#6A6D75";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#2D3747";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#636D80";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FBF8FA";
    public string SurfaceVariant => "#E4E2E3";
    public string OnSurface => "#111112";
    public string OnSurfaceVariant => "#363637";
    public string SurfaceDim => "#C8C6C7";
    public string SurfaceBright => "#FBF8FA";
    public string SurfaceTint => "#585F6B";
    // Background
    public string Background => "#FBF8FA";
    public string OnBackground => "#1B1B1D";
    // Outline
    public string Outline => "#535254";
    public string OutlineVariant => "#6D6D6E";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#303032";
    public string InverseOnSurface => "#F3F0F1";
    public string InversePrimary => "#C0C7D5";
    // Primary Fixed
    public string PrimaryFixed => "#676D7A";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#4E5562";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#6A6D75";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#51555D";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#636D80";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#4B5567";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F6F3F4";
    public string SurfaceContainer => "#EAE7E9";
    public string SurfaceContainerHigh => "#DFDCDD";
    public string SurfaceContainerHighest => "#D3D1D2";
}
