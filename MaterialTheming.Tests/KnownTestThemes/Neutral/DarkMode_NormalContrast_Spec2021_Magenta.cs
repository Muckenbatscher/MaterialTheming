namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_NormalContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#DAC0CA";
    public string OnPrimary => "#3D2C33";
    public string PrimaryContainer => "#54424A";
    public string OnPrimaryContainer => "#F7DBE6";
    // Secondary
    public string Secondary => "#D4C2C8";
    public string OnSecondary => "#392D32";
    public string SecondaryContainer => "#504348";
    public string OnSecondaryContainer => "#F1DEE4";
    // Tertiary
    public string Tertiary => "#E0BDCC";
    public string OnTertiary => "#402A35";
    public string TertiaryContainer => "#58404B";
    public string OnTertiaryContainer => "#FDD9E8";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#151314";
    public string SurfaceVariant => "#4A4647";
    public string OnSurface => "#E8E1E1";
    public string OnSurfaceVariant => "#CBC5C6";
    public string SurfaceDim => "#151314";
    public string SurfaceBright => "#3C3839";
    public string SurfaceTint => "#DAC0CA";
    // Background
    public string Background => "#151314";
    public string OnBackground => "#E8E1E1";
    // Outline
    public string Outline => "#958F90";
    public string OutlineVariant => "#4A4647";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E8E1E1";
    public string InverseOnSurface => "#333030";
    public string InversePrimary => "#6D5962";
    // Primary Fixed
    public string PrimaryFixed => "#F7DBE6";
    public string OnPrimaryFixed => "#26171E";
    public string PrimaryFixedDim => "#DAC0CA";
    public string OnPrimaryFixedVariant => "#54424A";
    // Secondary Fixed
    public string SecondaryFixed => "#F1DEE4";
    public string OnSecondaryFixed => "#23191D";
    public string SecondaryFixedDim => "#D4C2C8";
    public string OnSecondaryFixedVariant => "#504348";
    // Tertiary Fixed
    public string TertiaryFixed => "#FDD9E8";
    public string OnTertiaryFixed => "#291520";
    public string TertiaryFixedDim => "#E0BDCC";
    public string OnTertiaryFixedVariant => "#58404B";
    // Surface Container
    public string SurfaceContainerLowest => "#100E0E";
    public string SurfaceContainerLow => "#1E1B1C";
    public string SurfaceContainer => "#221F20";
    public string SurfaceContainerHigh => "#2C292A";
    public string SurfaceContainerHighest => "#373435";
}
