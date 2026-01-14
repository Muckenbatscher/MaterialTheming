using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_MediumContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#5D00A3";
    public string OnPrimary => "#E6C9FF";
    public string PrimaryContainer => "#994CE6";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#611F7E";
    public string OnSecondary => "#F1C5FF";
    public string SecondaryContainer => "#9C58B8";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#7A192E";
    public string OnTertiary => "#FFC6CA";
    public string TertiaryContainer => "#C04F60";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#83002A";
    public string OnError => "#FFC6CA";
    public string ErrorContainer => "#D73357";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF3FD";
    public string SurfaceVariant => "#F5D1FF";
    public string OnSurface => "#2E1538";
    public string OnSurfaceVariant => "#50355A";
    public string SurfaceDim => "#F2C5FF";
    public string SurfaceBright => "#FFF3FD";
    public string SurfaceTint => "#5D00A3";
    // Background
    public string Background => "#FFF3FD";
    public string OnBackground => "#2E1538";
    // Outline
    public string Outline => "#6E5178";
    public string OutlineVariant => "#8A6C94";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#1B0425";
    public string InverseOnSurface => "#DCB9E5";
    public string InversePrimary => "#BF80FF";
    // Primary Fixed
    public string PrimaryFixed => "#994CE6";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#8C3DD8";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#9C58B8";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#8E4CAB";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#C04F60";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#B04354";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FEEBFF";
    public string SurfaceContainer => "#FAE0FF";
    public string SurfaceContainerHigh => "#F8D8FF";
    public string SurfaceContainerHighest => "#F5D1FF";
}
