using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class LightMode_NormalContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#AC2B25";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#CF443B";
    public string OnPrimaryContainer => "#FFFBFF";
    // Secondary
    public string Secondary => "#924941";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#FEA096";
    public string OnSecondaryContainer => "#78342E";
    // Tertiary
    public string Tertiary => "#805500";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#A16C00";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#FFF8F7";
    public string SurfaceVariant => "#FEDAD6";
    public string OnSurface => "#261817";
    public string OnSurfaceVariant => "#59413E";
    public string SurfaceDim => "#EDD4D1";
    public string SurfaceBright => "#FFF8F7";
    public string SurfaceTint => "#B02D28";
    // Background
    public string Background => "#FFF8F7";
    public string OnBackground => "#261817";
    // Outline
    public string Outline => "#8D706D";
    public string OutlineVariant => "#E1BFBB";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#3C2D2B";
    public string InverseOnSurface => "#FFEDEA";
    public string InversePrimary => "#FFB4AB";
    // Primary Fixed
    public string PrimaryFixed => "#FFDAD6";
    public string OnPrimaryFixed => "#410002";
    public string PrimaryFixedDim => "#FFB4AB";
    public string OnPrimaryFixedVariant => "#8E1313";
    // Secondary Fixed
    public string SecondaryFixed => "#FFDAD6";
    public string OnSecondaryFixed => "#3C0706";
    public string SecondaryFixedDim => "#FFB4AB";
    public string OnSecondaryFixedVariant => "#75322C";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFDDB1";
    public string OnTertiaryFixed => "#291800";
    public string TertiaryFixedDim => "#FCBB54";
    public string OnTertiaryFixedVariant => "#624000";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0EE";
    public string SurfaceContainer => "#FFE9E6";
    public string SurfaceContainerHigh => "#FCE2DF";
    public string SurfaceContainerHighest => "#F6DDDA";
}
