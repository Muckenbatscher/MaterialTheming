namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_NormalContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#DCB8FF";
    public string OnPrimary => "#490081";
    public string PrimaryContainer => "#6800B4";
    public string OnPrimaryContainer => "#F0DBFF";
    // Secondary
    public string Secondary => "#DCBCE1";
    public string OnSecondary => "#3E2845";
    public string SecondaryContainer => "#563E5C";
    public string OnSecondaryContainer => "#F9D8FE";
    // Tertiary
    public string Tertiary => "#EDB5E2";
    public string OnTertiary => "#492245";
    public string TertiaryContainer => "#62385D";
    public string OnTertiaryContainer => "#FFD7F5";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#16111B";
    public string SurfaceVariant => "#4C4452";
    public string OnSurface => "#EADFED";
    public string OnSurfaceVariant => "#CEC2D4";
    public string SurfaceDim => "#16111B";
    public string SurfaceBright => "#3D3742";
    public string SurfaceTint => "#DCB8FF";
    // Background
    public string Background => "#16111B";
    public string OnBackground => "#EADFED";
    // Outline
    public string Outline => "#978D9D";
    public string OutlineVariant => "#4C4452";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#EADFED";
    public string InverseOnSurface => "#342E39";
    public string InversePrimary => "#8900EA";
    // Primary Fixed
    public string PrimaryFixed => "#F0DBFF";
    public string OnPrimaryFixed => "#2C0051";
    public string PrimaryFixedDim => "#DCB8FF";
    public string OnPrimaryFixedVariant => "#6800B4";
    // Secondary Fixed
    public string SecondaryFixed => "#F9D8FE";
    public string OnSecondaryFixed => "#28132F";
    public string SecondaryFixedDim => "#DCBCE1";
    public string OnSecondaryFixedVariant => "#563E5C";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFD7F5";
    public string OnTertiaryFixed => "#310C2F";
    public string TertiaryFixedDim => "#EDB5E2";
    public string OnTertiaryFixedVariant => "#62385D";
    // Surface Container
    public string SurfaceContainerLowest => "#110C16";
    public string SurfaceContainerLow => "#1F1923";
    public string SurfaceContainer => "#231D28";
    public string SurfaceContainerHigh => "#2E2832";
    public string SurfaceContainerHighest => "#39323D";
}
