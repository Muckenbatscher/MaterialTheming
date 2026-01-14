using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_NormalContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#904A43";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#FFDAD6";
    public string OnPrimaryContainer => "#73332D";
    // Secondary
    public string Secondary => "#775653";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#FFDAD6";
    public string OnSecondaryContainer => "#5D3F3C";
    // Tertiary
    public string Tertiary => "#715B2E";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#FDDFA6";
    public string OnTertiaryContainer => "#584419";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#FFF8F7";
    public string SurfaceVariant => "#F5DDDA";
    public string OnSurface => "#231918";
    public string OnSurfaceVariant => "#534341";
    public string SurfaceDim => "#E8D6D4";
    public string SurfaceBright => "#FFF8F7";
    public string SurfaceTint => "#904A43";
    // Background
    public string Background => "#FFF8F7";
    public string OnBackground => "#231918";
    // Outline
    public string Outline => "#857371";
    public string OutlineVariant => "#D8C2BF";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#392E2D";
    public string InverseOnSurface => "#FFEDEA";
    public string InversePrimary => "#FFB4AB";
    // Primary Fixed
    public string PrimaryFixed => "#FFDAD6";
    public string OnPrimaryFixed => "#3B0907";
    public string PrimaryFixedDim => "#FFB4AB";
    public string OnPrimaryFixedVariant => "#73332D";
    // Secondary Fixed
    public string SecondaryFixed => "#FFDAD6";
    public string OnSecondaryFixed => "#2C1513";
    public string SecondaryFixedDim => "#E7BDB8";
    public string OnSecondaryFixedVariant => "#5D3F3C";
    // Tertiary Fixed
    public string TertiaryFixed => "#FDDFA6";
    public string OnTertiaryFixed => "#261900";
    public string TertiaryFixedDim => "#E0C38C";
    public string OnTertiaryFixedVariant => "#584419";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0EE";
    public string SurfaceContainer => "#FCEAE7";
    public string SurfaceContainerHigh => "#F6E4E2";
    public string SurfaceContainerHighest => "#F1DEDC";
}
