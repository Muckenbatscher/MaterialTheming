namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_NormalContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FCB0D5";
    public string OnPrimary => "#521D3B";
    public string PrimaryContainer => "#6C3353";
    public string OnPrimaryContainer => "#FFD8E8";
    // Secondary
    public string Secondary => "#E0BDCC";
    public string OnSecondary => "#402A35";
    public string SecondaryContainer => "#58404B";
    public string OnSecondaryContainer => "#FDD9E8";
    // Tertiary
    public string Tertiary => "#F3BB9A";
    public string OnTertiary => "#4A2811";
    public string TertiaryContainer => "#643D25";
    public string OnTertiaryContainer => "#FFDBC8";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#181114";
    public string SurfaceVariant => "#504348";
    public string OnSurface => "#EEDFE3";
    public string OnSurfaceVariant => "#D4C2C8";
    public string SurfaceDim => "#181114";
    public string SurfaceBright => "#40373A";
    public string SurfaceTint => "#FCB0D5";
    // Background
    public string Background => "#181114";
    public string OnBackground => "#EEDFE3";
    // Outline
    public string Outline => "#9C8D92";
    public string OutlineVariant => "#504348";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#EEDFE3";
    public string InverseOnSurface => "#372E32";
    public string InversePrimary => "#884B6B";
    // Primary Fixed
    public string PrimaryFixed => "#FFD8E8";
    public string OnPrimaryFixed => "#380726";
    public string PrimaryFixedDim => "#FCB0D5";
    public string OnPrimaryFixedVariant => "#6C3353";
    // Secondary Fixed
    public string SecondaryFixed => "#FDD9E8";
    public string OnSecondaryFixed => "#291520";
    public string SecondaryFixedDim => "#E0BDCC";
    public string OnSecondaryFixedVariant => "#58404B";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFDBC8";
    public string OnTertiaryFixed => "#311302";
    public string TertiaryFixedDim => "#F3BB9A";
    public string OnTertiaryFixedVariant => "#643D25";
    // Surface Container
    public string SurfaceContainerLowest => "#130C0F";
    public string SurfaceContainerLow => "#21191D";
    public string SurfaceContainer => "#251D21";
    public string SurfaceContainerHigh => "#30282B";
    public string SurfaceContainerHighest => "#3B3236";
}
