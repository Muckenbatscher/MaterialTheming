using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_HighContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#511A15";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#763630";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#3F2522";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#60423E";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#3A2902";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#5A461B";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F7";
    public string SurfaceVariant => "#F5DDDA";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#C6B5B3";
    public string SurfaceBright => "#FFF8F7";
    public string SurfaceTint => "#904A43";
    // Background
    public string Background => "#FFF8F7";
    public string OnBackground => "#231918";
    // Outline
    public string Outline => "#362927";
    public string OutlineVariant => "#554544";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#392E2D";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#FFB4AB";
    // Primary Fixed
    public string PrimaryFixed => "#763630";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#59201B";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#60423E";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#472C29";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#5A461B";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#423006";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFEDEA";
    public string SurfaceContainer => "#F1DEDC";
    public string SurfaceContainerHigh => "#E2D0CE";
    public string SurfaceContainerHighest => "#D4C3C0";
}
