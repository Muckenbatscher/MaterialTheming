using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_NormalContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#C0C7D5";
    public string OnPrimary => "#2A313C";
    public string PrimaryContainer => "#404753";
    public string OnPrimaryContainer => "#DCE2F2";
    // Secondary
    public string Secondary => "#C4C6CF";
    public string OnSecondary => "#2D3038";
    public string SecondaryContainer => "#43474E";
    public string OnSecondaryContainer => "#E0E2EC";
    // Tertiary
    public string Tertiary => "#BDC7DC";
    public string OnTertiary => "#273141";
    public string TertiaryContainer => "#3D4758";
    public string OnTertiaryContainer => "#D9E3F8";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#131315";
    public string SurfaceVariant => "#474648";
    public string OnSurface => "#E4E2E3";
    public string OnSurfaceVariant => "#C8C6C7";
    public string SurfaceDim => "#131315";
    public string SurfaceBright => "#39393A";
    public string SurfaceTint => "#C0C7D5";
    // Background
    public string Background => "#131315";
    public string OnBackground => "#E4E2E3";
    // Outline
    public string Outline => "#929092";
    public string OutlineVariant => "#474648";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E4E2E3";
    public string InverseOnSurface => "#303032";
    public string InversePrimary => "#585F6B";
    // Primary Fixed
    public string PrimaryFixed => "#DCE2F2";
    public string OnPrimaryFixed => "#151C27";
    public string PrimaryFixedDim => "#C0C7D5";
    public string OnPrimaryFixedVariant => "#404753";
    // Secondary Fixed
    public string SecondaryFixed => "#E0E2EC";
    public string OnSecondaryFixed => "#181C22";
    public string SecondaryFixedDim => "#C4C6CF";
    public string OnSecondaryFixedVariant => "#43474E";
    // Tertiary Fixed
    public string TertiaryFixed => "#D9E3F8";
    public string OnTertiaryFixed => "#121C2B";
    public string TertiaryFixedDim => "#BDC7DC";
    public string OnTertiaryFixedVariant => "#3D4758";
    // Surface Container
    public string SurfaceContainerLowest => "#0E0E0F";
    public string SurfaceContainerLow => "#1B1B1D";
    public string SurfaceContainer => "#1F1F21";
    public string SurfaceContainerHigh => "#2A2A2B";
    public string SurfaceContainerHighest => "#353536";
}
