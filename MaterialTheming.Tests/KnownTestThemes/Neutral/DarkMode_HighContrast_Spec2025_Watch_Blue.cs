namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_HighContrast_Spec2025_Watch_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFFFFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#9CA6BA";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFFFF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#A1A6B1";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFFFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#B0ADEC";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFBEB9";
    public string OnError => "#000000";
    public string ErrorContainer => "#EA8C86";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#1E2633";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFEFF";
    public string SurfaceDim => "#0C0E13";
    public string SurfaceBright => "#232C3B";
    public string SurfaceTint => "#FFFFFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#CDCED4";
    public string OutlineVariant => "#A4A5AC";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F9F9FF";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#000000";
    // Primary Fixed
    public string PrimaryFixed => "#D9E3F8";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#CAD5EA";
    public string OnPrimaryFixedVariant => "#16202F";
    // Secondary Fixed
    public string SecondaryFixed => "#DEE2EF";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#D0D4E0";
    public string OnSecondaryFixedVariant => "#1B2028";
    // Tertiary Fixed
    public string TertiaryFixed => "#CDC9FF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#BEBAFB";
    public string OnTertiaryFixedVariant => "#040031";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#23262B";
    public string SurfaceContainer => "#2E3035";
    public string SurfaceContainerHigh => "#393B41";
    public string SurfaceContainerHighest => "#1E2633";
}
