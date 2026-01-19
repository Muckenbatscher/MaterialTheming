namespace MaterialTheming.Tests.KnownTestThemes.Monochrome;

internal class DarkMode_NormalContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Monochrome;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFFFFF";
    public string OnPrimary => "#1B1B1B";
    public string PrimaryContainer => "#D4D4D4";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#C6C6C6";
    public string OnSecondary => "#1B1B1B";
    public string SecondaryContainer => "#474747";
    public string OnSecondaryContainer => "#E2E2E2";
    // Tertiary
    public string Tertiary => "#E2E2E2";
    public string OnTertiary => "#1B1B1B";
    public string TertiaryContainer => "#919191";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#131313";
    public string SurfaceVariant => "#474747";
    public string OnSurface => "#E2E2E2";
    public string OnSurfaceVariant => "#C6C6C6";
    public string SurfaceDim => "#131313";
    public string SurfaceBright => "#393939";
    public string SurfaceTint => "#C6C6C6";
    // Background
    public string Background => "#131313";
    public string OnBackground => "#E2E2E2";
    // Outline
    public string Outline => "#919191";
    public string OutlineVariant => "#474747";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E2E2E2";
    public string InverseOnSurface => "#303030";
    public string InversePrimary => "#5E5E5E";
    // Primary Fixed
    public string PrimaryFixed => "#5E5E5E";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#474747";
    public string OnPrimaryFixedVariant => "#E2E2E2";
    // Secondary Fixed
    public string SecondaryFixed => "#C6C6C6";
    public string OnSecondaryFixed => "#1B1B1B";
    public string SecondaryFixedDim => "#ABABAB";
    public string OnSecondaryFixedVariant => "#3B3B3B";
    // Tertiary Fixed
    public string TertiaryFixed => "#5E5E5E";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#474747";
    public string OnTertiaryFixedVariant => "#E2E2E2";
    // Surface Container
    public string SurfaceContainerLowest => "#0E0E0E";
    public string SurfaceContainerLow => "#1B1B1B";
    public string SurfaceContainer => "#1F1F1F";
    public string SurfaceContainerHigh => "#2A2A2A";
    public string SurfaceContainerHighest => "#353535";
}
