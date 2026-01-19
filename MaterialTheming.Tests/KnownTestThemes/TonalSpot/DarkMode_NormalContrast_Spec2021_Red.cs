namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_NormalContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FFB4AB";
    public string OnPrimary => "#561E19";
    public string PrimaryContainer => "#73332D";
    public string OnPrimaryContainer => "#FFDAD6";
    // Secondary
    public string Secondary => "#E7BDB8";
    public string OnSecondary => "#442926";
    public string SecondaryContainer => "#5D3F3C";
    public string OnSecondaryContainer => "#FFDAD6";
    // Tertiary
    public string Tertiary => "#E0C38C";
    public string OnTertiary => "#3F2E04";
    public string TertiaryContainer => "#584419";
    public string OnTertiaryContainer => "#FDDFA6";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#1A1110";
    public string SurfaceVariant => "#534341";
    public string OnSurface => "#F1DEDC";
    public string OnSurfaceVariant => "#D8C2BF";
    public string SurfaceDim => "#1A1110";
    public string SurfaceBright => "#423735";
    public string SurfaceTint => "#FFB4AB";
    // Background
    public string Background => "#1A1110";
    public string OnBackground => "#F1DEDC";
    // Outline
    public string Outline => "#A08C8A";
    public string OutlineVariant => "#534341";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F1DEDC";
    public string InverseOnSurface => "#392E2D";
    public string InversePrimary => "#904A43";
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
    public string SurfaceContainerLowest => "#140C0B";
    public string SurfaceContainerLow => "#231918";
    public string SurfaceContainer => "#271D1C";
    public string SurfaceContainerHigh => "#322826";
    public string SurfaceContainerHighest => "#3D3231";
}
