using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_NormalContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#715855";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#FDDBD7";
    public string OnPrimaryContainer => "#58413F";
    // Secondary
    public string Secondary => "#6B5A58";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#F5DDDA";
    public string OnSecondaryContainer => "#534341";
    // Tertiary
    public string Tertiary => "#775653";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#FFDAD6";
    public string OnTertiaryContainer => "#5D3F3C";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#FFF8F7";
    public string SurfaceVariant => "#E9E1DF";
    public string OnSurface => "#1E1B1A";
    public string OnSurfaceVariant => "#4A4645";
    public string SurfaceDim => "#E0D8D7";
    public string SurfaceBright => "#FFF8F7";
    public string SurfaceTint => "#715855";
    // Background
    public string Background => "#FFF8F7";
    public string OnBackground => "#1E1B1A";
    // Outline
    public string Outline => "#7C7675";
    public string OutlineVariant => "#CCC5C4";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#332F2F";
    public string InverseOnSurface => "#F7EFEE";
    public string InversePrimary => "#DFBFBB";
    // Primary Fixed
    public string PrimaryFixed => "#FDDBD7";
    public string OnPrimaryFixed => "#291715";
    public string PrimaryFixedDim => "#DFBFBB";
    public string OnPrimaryFixedVariant => "#58413F";
    // Secondary Fixed
    public string SecondaryFixed => "#F5DDDA";
    public string OnSecondaryFixed => "#251917";
    public string SecondaryFixedDim => "#D8C2BF";
    public string OnSecondaryFixedVariant => "#534341";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFDAD6";
    public string OnTertiaryFixed => "#2C1513";
    public string TertiaryFixedDim => "#E7BDB8";
    public string OnTertiaryFixedVariant => "#5D3F3C";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FAF2F0";
    public string SurfaceContainer => "#F4ECEB";
    public string SurfaceContainerHigh => "#EFE6E5";
    public string SurfaceContainerHighest => "#E9E1DF";
}
