using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_NormalContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#645B6A";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#EBDEF0";
    public string OnPrimaryContainer => "#4C4452";
    // Secondary
    public string Secondary => "#625C65";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#E9DFEB";
    public string OnSecondaryContainer => "#4A454E";
    // Tertiary
    public string Tertiary => "#665A6F";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#EDDDF6";
    public string OnTertiaryContainer => "#4D4357";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#FDF8FA";
    public string SurfaceVariant => "#E6E1E3";
    public string OnSurface => "#1C1B1D";
    public string OnSurfaceVariant => "#484648";
    public string SurfaceDim => "#DED9DA";
    public string SurfaceBright => "#FDF8FA";
    public string SurfaceTint => "#645B6A";
    // Background
    public string Background => "#FDF8FA";
    public string OnBackground => "#1C1B1D";
    // Outline
    public string Outline => "#797678";
    public string OutlineVariant => "#CAC5C7";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#323031";
    public string InverseOnSurface => "#F5EFF1";
    public string InversePrimary => "#CEC2D4";
    // Primary Fixed
    public string PrimaryFixed => "#EBDEF0";
    public string OnPrimaryFixed => "#1F1925";
    public string PrimaryFixedDim => "#CEC2D4";
    public string OnPrimaryFixedVariant => "#4C4452";
    // Secondary Fixed
    public string SecondaryFixed => "#E9DFEB";
    public string OnSecondaryFixed => "#1E1A22";
    public string SecondaryFixedDim => "#CCC4CE";
    public string OnSecondaryFixedVariant => "#4A454E";
    // Tertiary Fixed
    public string TertiaryFixed => "#EDDDF6";
    public string OnTertiaryFixed => "#211829";
    public string TertiaryFixedDim => "#D0C1DA";
    public string OnTertiaryFixedVariant => "#4D4357";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F8F2F4";
    public string SurfaceContainer => "#F2ECEE";
    public string SurfaceContainerHigh => "#ECE7E9";
    public string SurfaceContainerHighest => "#E6E1E3";
}
