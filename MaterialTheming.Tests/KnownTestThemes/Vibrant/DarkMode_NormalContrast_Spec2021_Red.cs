namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_NormalContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FFB4AB";
    public string OnPrimary => "#690005";
    public string PrimaryContainer => "#93000B";
    public string OnPrimaryContainer => "#FFDAD6";
    // Secondary
    public string Secondary => "#F4B9A0";
    public string OnSecondary => "#4B2715";
    public string SecondaryContainer => "#653C2A";
    public string OnSecondaryContainer => "#FFDBCD";
    // Tertiary
    public string Tertiary => "#FAB982";
    public string OnTertiary => "#4C2700";
    public string TertiaryContainer => "#683C10";
    public string OnTertiaryContainer => "#FFDCC2";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#1E100E";
    public string SurfaceVariant => "#58413F";
    public string OnSurface => "#F9DCD9";
    public string OnSurfaceVariant => "#DFBFBB";
    public string SurfaceDim => "#1E100E";
    public string SurfaceBright => "#473533";
    public string SurfaceTint => "#FFB4AB";
    // Background
    public string Background => "#1E100E";
    public string OnBackground => "#F9DCD9";
    // Outline
    public string Outline => "#A78A87";
    public string OutlineVariant => "#58413F";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F9DCD9";
    public string InverseOnSurface => "#3D2C2A";
    public string InversePrimary => "#C00012";
    // Primary Fixed
    public string PrimaryFixed => "#FFDAD6";
    public string OnPrimaryFixed => "#410002";
    public string PrimaryFixedDim => "#FFB4AB";
    public string OnPrimaryFixedVariant => "#93000B";
    // Secondary Fixed
    public string SecondaryFixed => "#FFDBCD";
    public string OnSecondaryFixed => "#321304";
    public string SecondaryFixedDim => "#F4B9A0";
    public string OnSecondaryFixedVariant => "#653C2A";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFDCC2";
    public string OnTertiaryFixed => "#2E1500";
    public string TertiaryFixedDim => "#FAB982";
    public string OnTertiaryFixedVariant => "#683C10";
    // Surface Container
    public string SurfaceContainerLowest => "#180B09";
    public string SurfaceContainerLow => "#271816";
    public string SurfaceContainer => "#2B1C1A";
    public string SurfaceContainerHigh => "#372624";
    public string SurfaceContainerHighest => "#42302E";
}
