using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_MediumContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#5B2700";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#AF5200";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#4D300E";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#8B6640";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#4A3200";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#896728";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F5";
    public string SurfaceVariant => "#FBDCCC";
    public string OnSurface => "#1B0E07";
    public string OnSurfaceVariant => "#453227";
    public string SurfaceDim => "#DBC2B4";
    public string SurfaceBright => "#FFF8F5";
    public string SurfaceTint => "#994700";
    // Background
    public string Background => "#FFF8F5";
    public string OnBackground => "#261910";
    // Outline
    public string Outline => "#644E42";
    public string OutlineVariant => "#80685B";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#3D2D24";
    public string InverseOnSurface => "#FFEDE5";
    public string InversePrimary => "#FFB68B";
    // Primary Fixed
    public string PrimaryFixed => "#AF5200";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#8A3F00";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#8B6640";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#704E2A";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#896728";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#6E4F11";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1EA";
    public string SurfaceContainer => "#FEE3D5";
    public string SurfaceContainerHigh => "#F2D8CA";
    public string SurfaceContainerHighest => "#E6CDBF";
}
