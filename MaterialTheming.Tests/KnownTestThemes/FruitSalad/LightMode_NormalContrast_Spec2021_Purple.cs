using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_NormalContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#215FA6";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#D5E3FF";
    public string OnPrimaryContainer => "#004787";
    // Secondary
    public string Secondary => "#3D5F90";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#D5E3FF";
    public string OnSecondaryContainer => "#234776";
    // Tertiary
    public string Tertiary => "#6E528A";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#F0DBFF";
    public string OnTertiaryContainer => "#563B71";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#FFF7FE";
    public string SurfaceVariant => "#EDDDF6";
    public string OnSurface => "#1F1923";
    public string OnSurfaceVariant => "#4D4357";
    public string SurfaceDim => "#E1D6E5";
    public string SurfaceBright => "#FFF7FE";
    public string SurfaceTint => "#215FA6";
    // Background
    public string Background => "#FFF7FE";
    public string OnBackground => "#1F1923";
    // Outline
    public string Outline => "#7F7288";
    public string OutlineVariant => "#D0C1DA";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#342E39";
    public string InverseOnSurface => "#F8EDFC";
    public string InversePrimary => "#A6C8FF";
    // Primary Fixed
    public string PrimaryFixed => "#D5E3FF";
    public string OnPrimaryFixed => "#001C3B";
    public string PrimaryFixedDim => "#A6C8FF";
    public string OnPrimaryFixedVariant => "#004787";
    // Secondary Fixed
    public string SecondaryFixed => "#D5E3FF";
    public string OnSecondaryFixed => "#001C3B";
    public string SecondaryFixedDim => "#A6C8FF";
    public string OnSecondaryFixedVariant => "#234776";
    // Tertiary Fixed
    public string TertiaryFixed => "#F0DBFF";
    public string OnTertiaryFixed => "#280D42";
    public string TertiaryFixedDim => "#DBB9F9";
    public string OnTertiaryFixedVariant => "#563B71";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FBF0FF";
    public string SurfaceContainer => "#F5EAF9";
    public string SurfaceContainerHigh => "#F0E5F3";
    public string SurfaceContainerHighest => "#EADFED";
}
