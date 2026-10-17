namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_HighContrast_Spec2025_Watch_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFFFFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#B89FA9";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFFFF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#AFA2A7";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFFFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#EF999E";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFBDC3";
    public string OnError => "#000000";
    public string ErrorContainer => "#E88B96";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#322129";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFEFF";
    public string SurfaceDim => "#130C0F";
    public string SurfaceBright => "#3B2630";
    public string SurfaceTint => "#FFFFFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#D9CACF";
    public string OutlineVariant => "#AFA2A7";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F8";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#000000";
    // Primary Fixed
    public string PrimaryFixed => "#F7DBE6";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#E8CDD8";
    public string OnPrimaryFixedVariant => "#2A1B22";
    // Secondary Fixed
    public string SecondaryFixed => "#EEDFE3";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#DFD1D5";
    public string OnSecondaryFixedVariant => "#251D21";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFBFC1";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#FFA6AB";
    public string OnTertiaryFixedVariant => "#0E0001";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#2C2427";
    public string SurfaceContainer => "#372E32";
    public string SurfaceContainerHigh => "#42393D";
    public string SurfaceContainerHighest => "#322129";
}
