namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_HighContrast_Spec2026_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#DEE7E9";
    public string OnPrimary => "#252E2F";
    public string PrimaryContainer => "#9CA5A7";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#E4E6E6";
    public string OnSecondary => "#292D2D";
    public string SecondaryContainer => "#A1A4A5";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#EFF8FF";
    public string OnTertiary => "#1F3A48";
    public string TertiaryContainer => "#D0ECFF";
    public string OnTertiaryContainer => "#16313F";
    // Error
    public string Error => "#FFDEDB";
    public string OnError => "#5A0D10";
    public string ErrorContainer => "#F5827C";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#0E0E0E";
    public string SurfaceVariant => "#242627";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E5E5E6";
    public string SurfaceDim => "#0E0E0E";
    public string SurfaceBright => "#2A2D2D";
    public string SurfaceTint => "#DEE7E9";
    // Background
    public string Background => "#0E0E0E";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#B8B9B9";
    public string OutlineVariant => "#A2A4A4";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FBF9F8";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#313A3B";
    // Primary Fixed
    public string PrimaryFixed => "#DBE4E6";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#CDD6D8";
    public string OnPrimaryFixedVariant => "#182123";
    // Secondary Fixed
    public string SecondaryFixed => "#E1E3E3";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#D2D5D5";
    public string OnSecondaryFixedVariant => "#1D2021";
    // Tertiary Fixed
    public string TertiaryFixed => "#D0ECFF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#C2DEF0";
    public string OnTertiaryFixedVariant => "#0A2735";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#121414";
    public string SurfaceContainer => "#181A1A";
    public string SurfaceContainerHigh => "#1E2020";
    public string SurfaceContainerHighest => "#242627";
}
