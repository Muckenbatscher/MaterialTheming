using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_HighContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#600004";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#98000C";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#462312";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#683F2C";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#462300";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#6B3E12";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F7";
    public string SurfaceVariant => "#FDDBD7";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#CDB3B0";
    public string SurfaceBright => "#FFF8F7";
    public string SurfaceTint => "#C00012";
    // Background
    public string Background => "#FFF8F7";
    public string OnBackground => "#271816";
    // Outline
    public string Outline => "#3B2725";
    public string OutlineVariant => "#5B4441";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#3D2C2A";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#FFB4AB";
    // Primary Fixed
    public string PrimaryFixed => "#98000C";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#6D0006";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#683F2C";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#4E2918";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#6B3E12";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#4F2900";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFEDEA";
    public string SurfaceContainer => "#F9DCD9";
    public string SurfaceContainerHigh => "#EACECB";
    public string SurfaceContainerHighest => "#DCC0BD";
}
