using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class LightMode_MediumContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#5B2700";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#AB5616";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#522D15";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#916246";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#003C4A";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#007791";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F5";
    public string SurfaceVariant => "#F8DDCF";
    public string OnSurface => "#170F0B";
    public string OnSurfaceVariant => "#433329";
    public string SurfaceDim => "#D4C3BB";
    public string SurfaceBright => "#FFF8F5";
    public string SurfaceTint => "#984804";
    // Background
    public string Background => "#FFF8F5";
    public string OnBackground => "#221A15";
    // Outline
    public string Outline => "#614F44";
    public string OutlineVariant => "#7D695E";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#382E29";
    public string InverseOnSurface => "#FFEDE5";
    public string InversePrimary => "#FFB68B";
    // Primary Fixed
    public string PrimaryFixed => "#AB5616";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#8A3F00";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#916246";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#754B30";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#007791";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#005D71";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1EA";
    public string SurfaceContainer => "#F6E5DC";
    public string SurfaceContainerHigh => "#EBD9D1";
    public string SurfaceContainerHighest => "#DFCEC6";
}
