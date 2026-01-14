using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_NormalContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#8A4484";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#FFD7F5";
    public string OnPrimaryContainer => "#6F2C6B";
    // Secondary
    public string Secondary => "#804D79";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#FFD7F5";
    public string OnSecondaryContainer => "#653660";
    // Tertiary
    public string Tertiary => "#904A43";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#FFDAD6";
    public string OnTertiaryContainer => "#73332D";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#FFF8F7";
    public string SurfaceVariant => "#FFDAD6";
    public string OnSurface => "#271816";
    public string OnSurfaceVariant => "#5D3F3C";
    public string SurfaceDim => "#F0D4D0";
    public string SurfaceBright => "#FFF8F7";
    public string SurfaceTint => "#8A4484";
    // Background
    public string Background => "#FFF8F7";
    public string OnBackground => "#271816";
    // Outline
    public string Outline => "#926F6A";
    public string OutlineVariant => "#E7BDB8";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#3D2C2A";
    public string InverseOnSurface => "#FFEDEA";
    public string InversePrimary => "#FFABF3";
    // Primary Fixed
    public string PrimaryFixed => "#FFD7F5";
    public string OnPrimaryFixed => "#380038";
    public string PrimaryFixedDim => "#FFABF3";
    public string OnPrimaryFixedVariant => "#6F2C6B";
    // Secondary Fixed
    public string SecondaryFixed => "#FFD7F5";
    public string OnSecondaryFixed => "#340832";
    public string SecondaryFixedDim => "#F1B3E6";
    public string OnSecondaryFixedVariant => "#653660";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFDAD6";
    public string OnTertiaryFixed => "#3B0907";
    public string TertiaryFixedDim => "#FFB4AB";
    public string OnTertiaryFixedVariant => "#73332D";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0EE";
    public string SurfaceContainer => "#FFE9E6";
    public string SurfaceContainerHigh => "#FFE2DE";
    public string SurfaceContainerHighest => "#F9DCD9";
}
