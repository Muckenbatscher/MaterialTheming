using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_NormalContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#6E528A";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#F0DBFF";
    public string OnPrimaryContainer => "#563B71";
    // Secondary
    public string Secondary => "#665A6F";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#EDDDF6";
    public string OnSecondaryContainer => "#4D4357";
    // Tertiary
    public string Tertiary => "#805158";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#FFD9DD";
    public string OnTertiaryContainer => "#653A41";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#FFF7FE";
    public string SurfaceVariant => "#E9DFEB";
    public string OnSurface => "#1E1A20";
    public string OnSurfaceVariant => "#4A454E";
    public string SurfaceDim => "#DFD8DF";
    public string SurfaceBright => "#FFF7FE";
    public string SurfaceTint => "#6E528A";
    // Background
    public string Background => "#FFF7FE";
    public string OnBackground => "#1E1A20";
    // Outline
    public string Outline => "#7C757E";
    public string OutlineVariant => "#CCC4CE";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#332F35";
    public string InverseOnSurface => "#F6EEF6";
    public string InversePrimary => "#DBB9F9";
    // Primary Fixed
    public string PrimaryFixed => "#F0DBFF";
    public string OnPrimaryFixed => "#280D42";
    public string PrimaryFixedDim => "#DBB9F9";
    public string OnPrimaryFixedVariant => "#563B71";
    // Secondary Fixed
    public string SecondaryFixed => "#EDDDF6";
    public string OnSecondaryFixed => "#211829";
    public string SecondaryFixedDim => "#D0C1DA";
    public string OnSecondaryFixedVariant => "#4D4357";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFD9DD";
    public string OnTertiaryFixed => "#321017";
    public string TertiaryFixedDim => "#F3B7BE";
    public string OnTertiaryFixedVariant => "#653A41";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F9F1F9";
    public string SurfaceContainer => "#F3EBF3";
    public string SurfaceContainerHigh => "#EEE6EE";
    public string SurfaceContainerHighest => "#E8E0E8";
}
