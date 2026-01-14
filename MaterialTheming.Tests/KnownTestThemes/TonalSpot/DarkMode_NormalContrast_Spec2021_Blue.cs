using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_NormalContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#A6C8FF";
    public string OnPrimary => "#02315E";
    public string PrimaryContainer => "#234776";
    public string OnPrimaryContainer => "#D5E3FF";
    // Secondary
    public string Secondary => "#BDC7DC";
    public string OnSecondary => "#273141";
    public string SecondaryContainer => "#3D4758";
    public string OnSecondaryContainer => "#D9E3F8";
    // Tertiary
    public string Tertiary => "#DABDE2";
    public string OnTertiary => "#3D2846";
    public string TertiaryContainer => "#553F5D";
    public string OnTertiaryContainer => "#F7D8FF";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#111318";
    public string SurfaceVariant => "#43474E";
    public string OnSurface => "#E1E2E9";
    public string OnSurfaceVariant => "#C4C6CF";
    public string SurfaceDim => "#111318";
    public string SurfaceBright => "#37393E";
    public string SurfaceTint => "#A6C8FF";
    // Background
    public string Background => "#111318";
    public string OnBackground => "#E1E2E9";
    // Outline
    public string Outline => "#8D9199";
    public string OutlineVariant => "#43474E";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E1E2E9";
    public string InverseOnSurface => "#2E3035";
    public string InversePrimary => "#3D5F90";
    // Primary Fixed
    public string PrimaryFixed => "#D5E3FF";
    public string OnPrimaryFixed => "#001C3B";
    public string PrimaryFixedDim => "#A6C8FF";
    public string OnPrimaryFixedVariant => "#234776";
    // Secondary Fixed
    public string SecondaryFixed => "#D9E3F8";
    public string OnSecondaryFixed => "#121C2B";
    public string SecondaryFixedDim => "#BDC7DC";
    public string OnSecondaryFixedVariant => "#3D4758";
    // Tertiary Fixed
    public string TertiaryFixed => "#F7D8FF";
    public string OnTertiaryFixed => "#27142F";
    public string TertiaryFixedDim => "#DABDE2";
    public string OnTertiaryFixedVariant => "#553F5D";
    // Surface Container
    public string SurfaceContainerLowest => "#0C0E13";
    public string SurfaceContainerLow => "#191C20";
    public string SurfaceContainer => "#1D2024";
    public string SurfaceContainerHigh => "#282A2F";
    public string SurfaceContainerHighest => "#32353A";
}
