using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_NormalContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#CEC2D4";
    public string OnPrimary => "#352E3B";
    public string PrimaryContainer => "#4C4452";
    public string OnPrimaryContainer => "#EBDEF0";
    // Secondary
    public string Secondary => "#CCC4CE";
    public string OnSecondary => "#332F37";
    public string SecondaryContainer => "#4A454E";
    public string OnSecondaryContainer => "#E9DFEB";
    // Tertiary
    public string Tertiary => "#D0C1DA";
    public string OnTertiary => "#362C3F";
    public string TertiaryContainer => "#4D4357";
    public string OnTertiaryContainer => "#EDDDF6";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#141314";
    public string SurfaceVariant => "#484648";
    public string OnSurface => "#E6E1E3";
    public string OnSurfaceVariant => "#CAC5C7";
    public string SurfaceDim => "#141314";
    public string SurfaceBright => "#3B393A";
    public string SurfaceTint => "#CEC2D4";
    // Background
    public string Background => "#141314";
    public string OnBackground => "#E6E1E3";
    // Outline
    public string Outline => "#939091";
    public string OutlineVariant => "#484648";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E6E1E3";
    public string InverseOnSurface => "#323031";
    public string InversePrimary => "#645B6A";
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
    public string SurfaceContainerLowest => "#0F0E0F";
    public string SurfaceContainerLow => "#1C1B1D";
    public string SurfaceContainer => "#211F21";
    public string SurfaceContainerHigh => "#2B292B";
    public string SurfaceContainerHighest => "#363436";
}
