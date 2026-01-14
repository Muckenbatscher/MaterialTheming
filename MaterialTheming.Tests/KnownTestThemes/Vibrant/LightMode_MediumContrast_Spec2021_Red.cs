using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_MediumContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#740006";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#DC0017";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#522C1B";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#91624D";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#542C01";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#956132";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F7";
    public string SurfaceVariant => "#FDDBD7";
    public string OnSurface => "#1B0E0C";
    public string OnSurfaceVariant => "#46312E";
    public string SurfaceDim => "#DCC0BD";
    public string SurfaceBright => "#FFF8F7";
    public string SurfaceTint => "#C00012";
    // Background
    public string Background => "#FFF8F7";
    public string OnBackground => "#271816";
    // Outline
    public string Outline => "#654D4A";
    public string OutlineVariant => "#816764";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#3D2C2A";
    public string InverseOnSurface => "#FFEDEA";
    public string InversePrimary => "#FFB4AB";
    // Primary Fixed
    public string PrimaryFixed => "#DC0017";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#AE000F";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#91624D";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#764A36";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#956132";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#794A1D";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0EE";
    public string SurfaceContainer => "#FFE2DE";
    public string SurfaceContainerHigh => "#F3D7D3";
    public string SurfaceContainerHighest => "#E7CBC8";
}
