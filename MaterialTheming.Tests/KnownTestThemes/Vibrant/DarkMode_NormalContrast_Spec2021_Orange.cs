using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_NormalContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FFB68B";
    public string OnPrimary => "#522300";
    public string PrimaryContainer => "#743400";
    public string OnPrimaryContainer => "#FFDBC8";
    // Secondary
    public string Secondary => "#ECBE91";
    public string OnSecondary => "#462A09";
    public string SecondaryContainer => "#60401D";
    public string OnSecondaryContainer => "#FFDCBD";
    // Tertiary
    public string Tertiary => "#EBC078";
    public string OnTertiary => "#422C00";
    public string TertiaryContainer => "#5F4102";
    public string OnTertiaryContainer => "#FFDEAA";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#1D1009";
    public string SurfaceVariant => "#574236";
    public string OnSurface => "#F8DDD0";
    public string OnSurfaceVariant => "#DEC1B1";
    public string SurfaceDim => "#1D1009";
    public string SurfaceBright => "#46362C";
    public string SurfaceTint => "#FFB68B";
    // Background
    public string Background => "#1D1009";
    public string OnBackground => "#F8DDD0";
    // Outline
    public string Outline => "#A68B7D";
    public string OutlineVariant => "#574236";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F8DDD0";
    public string InverseOnSurface => "#3D2D24";
    public string InversePrimary => "#994700";
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
    public string SurfaceContainerLowest => "#170B05";
    public string SurfaceContainerLow => "#261910";
    public string SurfaceContainer => "#2A1D14";
    public string SurfaceContainerHigh => "#36271E";
    public string SurfaceContainerHighest => "#413128";
}
