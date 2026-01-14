using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_HighContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#F2DFFF";
    public string OnPrimary => "#352546";
    public string PrimaryContainer => "#B19BC5";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#F0E0F9";
    public string OnSecondary => "#32283B";
    public string SecondaryContainer => "#AD9FB6";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFDCEA";
    public string OnTertiary => "#461F34";
    public string TertiaryContainer => "#F7BBD7";
    public string OnTertiaryContainer => "#2E0A1F";
    // Error
    public string Error => "#FFDDDF";
    public string OnError => "#5F001C";
    public string ErrorContainer => "#FF798C";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#100D11";
    public string SurfaceVariant => "#29242D";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#ECE2EE";
    public string SurfaceDim => "#100D11";
    public string SurfaceBright => "#2F2A33";
    public string SurfaceTint => "#F2DFFF";
    // Background
    public string Background => "#100D11";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#BFB6C1";
    public string OutlineVariant => "#A9A1AC";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF7FE";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#423153";
    // Primary Fixed
    public string PrimaryFixed => "#E4CBF7";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#D5BEE9";
    public string OnPrimaryFixedVariant => "#19092A";
    // Secondary Fixed
    public string SecondaryFixed => "#EDDDF6";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#DECFE8";
    public string OnSecondaryFixedVariant => "#251C2E";
    // Tertiary Fixed
    public string TertiaryFixed => "#F7BBD7";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#E8AEC9";
    public string OnTertiaryFixedVariant => "#0D0006";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#151218";
    public string SurfaceContainer => "#1C181F";
    public string SurfaceContainerHigh => "#221E25";
    public string SurfaceContainerHighest => "#29242D";
}
