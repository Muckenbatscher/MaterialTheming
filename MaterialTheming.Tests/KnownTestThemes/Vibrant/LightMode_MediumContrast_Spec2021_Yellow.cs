using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_MediumContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#393800";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#727000";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#323A14";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#687146";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#243D10";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#597542";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FEFAE3";
    public string SurfaceVariant => "#E7E3C8";
    public string OnSurface => "#121205";
    public string OnSurfaceVariant => "#383724";
    public string SurfaceDim => "#CAC7B1";
    public string SurfaceBright => "#FEFAE3";
    public string SurfaceTint => "#636100";
    // Background
    public string Background => "#FEFAE3";
    public string OnBackground => "#1D1C0E";
    // Outline
    public string Outline => "#54533E";
    public string OutlineVariant => "#6F6E58";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#323122";
    public string InverseOnSurface => "#F5F1DA";
    public string InversePrimary => "#CFCC00";
    // Primary Fixed
    public string PrimaryFixed => "#727000";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#595700";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#687146";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#505930";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#597542";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#425C2C";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F8F4DD";
    public string SurfaceContainer => "#ECE9D2";
    public string SurfaceContainerHigh => "#E1DEC7";
    public string SurfaceContainerHighest => "#D5D2BC";
}
