using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_NormalContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#8900EA";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#F0DBFF";
    public string OnPrimaryContainer => "#6800B4";
    // Secondary
    public string Secondary => "#6F5675";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#F9D8FE";
    public string OnSecondaryContainer => "#563E5C";
    // Tertiary
    public string Tertiary => "#7C4F76";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#FFD7F5";
    public string OnTertiaryContainer => "#62385D";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#FFF7FE";
    public string SurfaceVariant => "#EBDEF0";
    public string OnSurface => "#1F1923";
    public string OnSurfaceVariant => "#4C4452";
    public string SurfaceDim => "#E1D6E5";
    public string SurfaceBright => "#FFF7FE";
    public string SurfaceTint => "#8900EA";
    // Background
    public string Background => "#FFF7FE";
    public string OnBackground => "#1F1923";
    // Outline
    public string Outline => "#7D7483";
    public string OutlineVariant => "#CEC2D4";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#342E39";
    public string InverseOnSurface => "#F8EDFC";
    public string InversePrimary => "#DCB8FF";
    // Primary Fixed
    public string PrimaryFixed => "#F0DBFF";
    public string OnPrimaryFixed => "#2C0051";
    public string PrimaryFixedDim => "#DCB8FF";
    public string OnPrimaryFixedVariant => "#6800B4";
    // Secondary Fixed
    public string SecondaryFixed => "#F9D8FE";
    public string OnSecondaryFixed => "#28132F";
    public string SecondaryFixedDim => "#DCBCE1";
    public string OnSecondaryFixedVariant => "#563E5C";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFD7F5";
    public string OnTertiaryFixed => "#310C2F";
    public string TertiaryFixedDim => "#EDB5E2";
    public string OnTertiaryFixedVariant => "#62385D";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FBF0FF";
    public string SurfaceContainer => "#F5EAF9";
    public string SurfaceContainerHigh => "#F0E5F3";
    public string SurfaceContainerHighest => "#EADFED";
}
