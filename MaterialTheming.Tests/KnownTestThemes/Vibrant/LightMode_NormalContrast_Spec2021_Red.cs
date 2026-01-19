namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_NormalContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#C00012";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#FFDAD6";
    public string OnPrimaryContainer => "#93000B";
    // Secondary
    public string Secondary => "#81533F";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#FFDBCD";
    public string OnSecondaryContainer => "#653C2A";
    // Tertiary
    public string Tertiary => "#845325";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#FFDCC2";
    public string OnTertiaryContainer => "#683C10";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#FFF8F7";
    public string SurfaceVariant => "#FDDBD7";
    public string OnSurface => "#271816";
    public string OnSurfaceVariant => "#58413F";
    public string SurfaceDim => "#F0D4D0";
    public string SurfaceBright => "#FFF8F7";
    public string SurfaceTint => "#C00012";
    // Background
    public string Background => "#FFF8F7";
    public string OnBackground => "#271816";
    // Outline
    public string Outline => "#8C716E";
    public string OutlineVariant => "#DFBFBB";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#3D2C2A";
    public string InverseOnSurface => "#FFEDEA";
    public string InversePrimary => "#FFB4AB";
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
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0EE";
    public string SurfaceContainer => "#FFE9E6";
    public string SurfaceContainerHigh => "#FFE2DE";
    public string SurfaceContainerHighest => "#F9DCD9";
}
