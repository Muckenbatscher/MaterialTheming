using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_NormalContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#7E2CCA";
    public string OnPrimary => "#FBEFFF";
    public string PrimaryContainer => "#C185FF";
    public string OnPrimaryContainer => "#360062";
    // Secondary
    public string Secondary => "#803E9D";
    public string OnSecondary => "#FFEDFF";
    public string SecondaryContainer => "#F0C1FF";
    public string OnSecondaryContainer => "#6A2887";
    // Tertiary
    public string Tertiary => "#A03648";
    public string OnTertiary => "#FFEFEF";
    public string TertiaryContainer => "#FF909D";
    public string OnTertiaryContainer => "#650620";
    // Error
    public string Error => "#B41340";
    public string OnError => "#FFEFEF";
    public string ErrorContainer => "#F74B6D";
    public string OnErrorContainer => "#510017";
    // Surface
    public string Surface => "#FFF3FD";
    public string SurfaceVariant => "#F5D1FF";
    public string OnSurface => "#3E2548";
    public string OnSurfaceVariant => "#6E5178";
    public string SurfaceDim => "#F2C5FF";
    public string SurfaceBright => "#FFF3FD";
    public string SurfaceTint => "#7E2CCA";
    // Background
    public string Background => "#FFF3FD";
    public string OnBackground => "#3E2548";
    // Outline
    public string Outline => "#8A6C94";
    public string OutlineVariant => "#C3A2CD";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#1B0425";
    public string InverseOnSurface => "#B292BC";
    public string InversePrimary => "#B66DFF";
    // Primary Fixed
    public string PrimaryFixed => "#C185FF";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#B871FF";
    public string OnPrimaryFixedVariant => "#430077";
    // Secondary Fixed
    public string SecondaryFixed => "#F0C1FF";
    public string OnSecondaryFixed => "#550F72";
    public string SecondaryFixedDim => "#EAAEFF";
    public string OnSecondaryFixedVariant => "#743391";
    // Tertiary Fixed
    public string TertiaryFixed => "#FF909D";
    public string OnTertiaryFixed => "#39000D";
    public string TertiaryFixedDim => "#FA7C8D";
    public string OnTertiaryFixedVariant => "#711228";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FEEBFF";
    public string SurfaceContainer => "#FAE0FF";
    public string SurfaceContainerHigh => "#F8D8FF";
    public string SurfaceContainerHighest => "#F5D1FF";
}
