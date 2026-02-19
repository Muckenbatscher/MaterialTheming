namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_NormalContrast_Spec2026_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFABF3";
    public string OnPrimary => "#551353";
    public string PrimaryContainer => "#6F2C6B";
    public string OnPrimaryContainer => "#FFD7F5";
    // Secondary
    public string Secondary => "#F1B3E6";
    public string OnSecondary => "#4C1F49";
    public string SecondaryContainer => "#653660";
    public string OnSecondaryContainer => "#FFD7F5";
    // Tertiary
    public string Tertiary => "#FFB4AB";
    public string OnTertiary => "#561E19";
    public string TertiaryContainer => "#73332D";
    public string OnTertiaryContainer => "#FFDAD6";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#1E100E";
    public string SurfaceVariant => "#5D3F3C";
    public string OnSurface => "#F9DCD9";
    public string OnSurfaceVariant => "#E7BDB8";
    public string SurfaceDim => "#1E100E";
    public string SurfaceBright => "#473533";
    public string SurfaceTint => "#FFABF3";
    // Background
    public string Background => "#1E100E";
    public string OnBackground => "#F9DCD9";
    // Outline
    public string Outline => "#AD8883";
    public string OutlineVariant => "#5D3F3C";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F9DCD9";
    public string InverseOnSurface => "#3D2C2A";
    public string InversePrimary => "#8A4484";
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
    public string SurfaceContainerLowest => "#180B09";
    public string SurfaceContainerLow => "#271816";
    public string SurfaceContainer => "#2B1C1A";
    public string SurfaceContainerHigh => "#372624";
    public string SurfaceContainerHighest => "#42302E";
}
