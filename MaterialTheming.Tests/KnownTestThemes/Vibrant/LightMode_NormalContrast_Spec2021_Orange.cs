using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_NormalContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#994700";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#FFDBC8";
    public string OnPrimaryContainer => "#743400";
    // Secondary
    public string Secondary => "#7A5732";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#FFDCBD";
    public string OnSecondaryContainer => "#60401D";
    // Tertiary
    public string Tertiary => "#79591B";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#FFDEAA";
    public string OnTertiaryContainer => "#5F4102";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#FFF8F5";
    public string SurfaceVariant => "#FBDCCC";
    public string OnSurface => "#261910";
    public string OnSurfaceVariant => "#574236";
    public string SurfaceDim => "#EFD5C7";
    public string SurfaceBright => "#FFF8F5";
    public string SurfaceTint => "#994700";
    // Background
    public string Background => "#FFF8F5";
    public string OnBackground => "#261910";
    // Outline
    public string Outline => "#8B7264";
    public string OutlineVariant => "#DEC1B1";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#3D2D24";
    public string InverseOnSurface => "#FFEDE5";
    public string InversePrimary => "#FFB68B";
    // Primary Fixed
    public string PrimaryFixed => "#FFDBC8";
    public string OnPrimaryFixed => "#321300";
    public string PrimaryFixedDim => "#FFB68B";
    public string OnPrimaryFixedVariant => "#743400";
    // Secondary Fixed
    public string SecondaryFixed => "#FFDCBD";
    public string OnSecondaryFixed => "#2C1600";
    public string SecondaryFixedDim => "#ECBE91";
    public string OnSecondaryFixedVariant => "#60401D";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFDEAA";
    public string OnTertiaryFixed => "#271900";
    public string TertiaryFixedDim => "#EBC078";
    public string OnTertiaryFixedVariant => "#5F4102";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1EA";
    public string SurfaceContainer => "#FFEADF";
    public string SurfaceContainerHigh => "#FEE3D5";
    public string SurfaceContainerHighest => "#F8DDD0";
}
