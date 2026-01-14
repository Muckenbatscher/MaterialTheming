using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_NormalContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#A6C8FF";
    public string OnPrimary => "#00315F";
    public string PrimaryContainer => "#004787";
    public string OnPrimaryContainer => "#D5E3FF";
    // Secondary
    public string Secondary => "#BDC5EB";
    public string OnSecondary => "#272F4D";
    public string SecondaryContainer => "#3E4565";
    public string OnSecondaryContainer => "#DCE1FF";
    // Tertiary
    public string Tertiary => "#C6C0F9";
    public string OnTertiary => "#2E2A59";
    public string TertiaryContainer => "#454171";
    public string OnTertiaryContainer => "#E4DFFF";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#0E141C";
    public string SurfaceVariant => "#404753";
    public string OnSurface => "#DEE2EF";
    public string OnSurfaceVariant => "#C0C7D5";
    public string SurfaceDim => "#0E141C";
    public string SurfaceBright => "#343943";
    public string SurfaceTint => "#A6C8FF";
    // Background
    public string Background => "#0E141C";
    public string OnBackground => "#DEE2EF";
    // Outline
    public string Outline => "#8A919F";
    public string OutlineVariant => "#404753";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#DEE2EF";
    public string InverseOnSurface => "#2B313A";
    public string InversePrimary => "#005FB0";
    // Primary Fixed
    public string PrimaryFixed => "#D5E3FF";
    public string OnPrimaryFixed => "#001C3B";
    public string PrimaryFixedDim => "#A6C8FF";
    public string OnPrimaryFixedVariant => "#004787";
    // Secondary Fixed
    public string SecondaryFixed => "#DCE1FF";
    public string OnSecondaryFixed => "#121A37";
    public string SecondaryFixedDim => "#BDC5EB";
    public string OnSecondaryFixedVariant => "#3E4565";
    // Tertiary Fixed
    public string TertiaryFixed => "#E4DFFF";
    public string OnTertiaryFixed => "#191443";
    public string TertiaryFixedDim => "#C6C0F9";
    public string OnTertiaryFixedVariant => "#454171";
    // Surface Container
    public string SurfaceContainerLowest => "#090E17";
    public string SurfaceContainerLow => "#171C24";
    public string SurfaceContainer => "#1B2029";
    public string SurfaceContainerHigh => "#252A33";
    public string SurfaceContainerHighest => "#30353E";
}
