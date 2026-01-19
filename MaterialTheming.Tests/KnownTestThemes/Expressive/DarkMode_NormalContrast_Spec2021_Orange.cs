namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_NormalContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#C6BFFF";
    public string OnPrimary => "#2E2767";
    public string PrimaryContainer => "#443E7F";
    public string OnPrimaryContainer => "#E4DFFF";
    // Secondary
    public string Secondary => "#B1CFA9";
    public string OnSecondary => "#1D361B";
    public string SecondaryContainer => "#334D30";
    public string OnSecondaryContainer => "#CCEBC4";
    // Tertiary
    public string Tertiary => "#94D4B9";
    public string OnTertiary => "#003828";
    public string TertiaryContainer => "#08513C";
    public string OnTertiaryContainer => "#AFF0D4";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#1A1209";
    public string SurfaceVariant => "#554433";
    public string OnSurface => "#F2DFD1";
    public string OnSurfaceVariant => "#DBC2AC";
    public string SurfaceDim => "#1A1209";
    public string SurfaceBright => "#42372D";
    public string SurfaceTint => "#C6BFFF";
    // Background
    public string Background => "#1A1209";
    public string OnBackground => "#F2DFD1";
    // Outline
    public string Outline => "#A38D79";
    public string OutlineVariant => "#554433";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F2DFD1";
    public string InverseOnSurface => "#392E25";
    public string InversePrimary => "#5C5698";
    // Primary Fixed
    public string PrimaryFixed => "#E4DFFF";
    public string OnPrimaryFixed => "#180F51";
    public string PrimaryFixedDim => "#C6BFFF";
    public string OnPrimaryFixedVariant => "#443E7F";
    // Secondary Fixed
    public string SecondaryFixed => "#CCEBC4";
    public string OnSecondaryFixed => "#082008";
    public string SecondaryFixedDim => "#B1CFA9";
    public string OnSecondaryFixedVariant => "#334D30";
    // Tertiary Fixed
    public string TertiaryFixed => "#AFF0D4";
    public string OnTertiaryFixed => "#002116";
    public string TertiaryFixedDim => "#94D4B9";
    public string OnTertiaryFixedVariant => "#08513C";
    // Surface Container
    public string SurfaceContainerLowest => "#150D05";
    public string SurfaceContainerLow => "#231A11";
    public string SurfaceContainer => "#271E15";
    public string SurfaceContainerHigh => "#32281E";
    public string SurfaceContainerHighest => "#3E3329";
}
