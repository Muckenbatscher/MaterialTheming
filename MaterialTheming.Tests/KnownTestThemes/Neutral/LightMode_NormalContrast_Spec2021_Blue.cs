namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_NormalContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#585F6B";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#DCE2F2";
    public string OnPrimaryContainer => "#404753";
    // Secondary
    public string Secondary => "#5B5E66";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#E0E2EC";
    public string OnSecondaryContainer => "#43474E";
    // Tertiary
    public string Tertiary => "#555F71";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#D9E3F8";
    public string OnTertiaryContainer => "#3D4758";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#FBF8FA";
    public string SurfaceVariant => "#E4E2E3";
    public string OnSurface => "#1B1B1D";
    public string OnSurfaceVariant => "#474648";
    public string SurfaceDim => "#DCD9DB";
    public string SurfaceBright => "#FBF8FA";
    public string SurfaceTint => "#585F6B";
    // Background
    public string Background => "#FBF8FA";
    public string OnBackground => "#1B1B1D";
    // Outline
    public string Outline => "#787778";
    public string OutlineVariant => "#C8C6C7";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#303032";
    public string InverseOnSurface => "#F3F0F1";
    public string InversePrimary => "#C0C7D5";
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
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F6F3F4";
    public string SurfaceContainer => "#F0EDEE";
    public string SurfaceContainerHigh => "#EAE7E9";
    public string SurfaceContainerHighest => "#E4E2E3";
}
