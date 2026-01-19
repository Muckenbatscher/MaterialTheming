namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_NormalContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#DFBFBB";
    public string OnPrimary => "#402B29";
    public string PrimaryContainer => "#58413F";
    public string OnPrimaryContainer => "#FDDBD7";
    // Secondary
    public string Secondary => "#D8C2BF";
    public string OnSecondary => "#3B2D2B";
    public string SecondaryContainer => "#534341";
    public string OnSecondaryContainer => "#F5DDDA";
    // Tertiary
    public string Tertiary => "#E7BDB8";
    public string OnTertiary => "#442926";
    public string TertiaryContainer => "#5D3F3C";
    public string OnTertiaryContainer => "#FFDAD6";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#161312";
    public string SurfaceVariant => "#4A4645";
    public string OnSurface => "#E9E1DF";
    public string OnSurfaceVariant => "#CCC5C4";
    public string SurfaceDim => "#161312";
    public string SurfaceBright => "#3C3838";
    public string SurfaceTint => "#DFBFBB";
    // Background
    public string Background => "#161312";
    public string OnBackground => "#E9E1DF";
    // Outline
    public string Outline => "#968F8E";
    public string OutlineVariant => "#4A4645";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E9E1DF";
    public string InverseOnSurface => "#332F2F";
    public string InversePrimary => "#715855";
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
    public string SurfaceContainerLowest => "#100D0D";
    public string SurfaceContainerLow => "#1E1B1A";
    public string SurfaceContainer => "#221F1E";
    public string SurfaceContainerHigh => "#2D2929";
    public string SurfaceContainerHighest => "#383433";
}
