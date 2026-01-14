using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_NormalContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#00E563";
    public string OnPrimary => "#003913";
    public string PrimaryContainer => "#00531F";
    public string OnPrimaryContainer => "#69FF89";
    // Secondary
    public string Secondary => "#A6D0B8";
    public string OnSecondary => "#103726";
    public string SecondaryContainer => "#284E3C";
    public string OnSecondaryContainer => "#C2ECD3";
    // Tertiary
    public string Tertiary => "#8FD4C2";
    public string OnTertiary => "#00382E";
    public string TertiaryContainer => "#005144";
    public string OnTertiaryContainer => "#ABF0DE";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#0D150D";
    public string SurfaceVariant => "#3E4A3D";
    public string OnSurface => "#DBE5D7";
    public string OnSurfaceVariant => "#BDCABA";
    public string SurfaceDim => "#0D150D";
    public string SurfaceBright => "#323C32";
    public string SurfaceTint => "#00E563";
    // Background
    public string Background => "#0D150D";
    public string OnBackground => "#DBE5D7";
    // Outline
    public string Outline => "#879485";
    public string OutlineVariant => "#3E4A3D";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#DBE5D7";
    public string InverseOnSurface => "#2A3329";
    public string InversePrimary => "#006E2B";
    // Primary Fixed
    public string PrimaryFixed => "#69FF89";
    public string OnPrimaryFixed => "#002108";
    public string PrimaryFixedDim => "#00E563";
    public string OnPrimaryFixedVariant => "#00531F";
    // Secondary Fixed
    public string SecondaryFixed => "#C2ECD3";
    public string OnSecondaryFixed => "#002114";
    public string SecondaryFixedDim => "#A6D0B8";
    public string OnSecondaryFixedVariant => "#284E3C";
    // Tertiary Fixed
    public string TertiaryFixed => "#ABF0DE";
    public string OnTertiaryFixed => "#00201A";
    public string TertiaryFixedDim => "#8FD4C2";
    public string OnTertiaryFixedVariant => "#005144";
    // Surface Container
    public string SurfaceContainerLowest => "#081008";
    public string SurfaceContainerLow => "#151E15";
    public string SurfaceContainer => "#192219";
    public string SurfaceContainerHigh => "#232C23";
    public string SurfaceContainerHighest => "#2E372D";
}
