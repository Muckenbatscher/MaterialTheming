namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_MediumContrast_Spec2026_Watch_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFFEFF";
    public string OnPrimary => "#16202F";
    public string PrimaryContainer => "#7C8699";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFEFF";
    public string OnSecondary => "#1B2028";
    public string SecondaryContainer => "#818691";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFEFF";
    public string OnTertiary => "#040031";
    public string TertiaryContainer => "#B0ADEC";
    public string OnTertiaryContainer => "#232057";
    // Error
    public string Error => "#FFBEB9";
    public string OnError => "#3A0406";
    public string ErrorContainer => "#C46D68";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#1E2633";
    public string OnSurface => "#FFFEFF";
    public string OnSurfaceVariant => "#CDCED4";
    public string SurfaceDim => "#0C0E13";
    public string SurfaceBright => "#232C3B";
    public string SurfaceTint => "#FFFEFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#A4A5AC";
    public string OutlineVariant => "#84858B";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F9F9FF";
    public string InverseOnSurface => "#36383D";
    public string InversePrimary => "#2F3949";
    // Primary Fixed
    public string PrimaryFixed => "#D9E3F8";
    public string OnPrimaryFixed => "#16202F";
    public string PrimaryFixedDim => "#CAD5EA";
    public string OnPrimaryFixedVariant => "#364051";
    // Secondary Fixed
    public string SecondaryFixed => "#DEE2EF";
    public string OnSecondaryFixed => "#1B2028";
    public string SecondaryFixedDim => "#D0D4E0";
    public string OnSecondaryFixedVariant => "#3A3F49";
    // Tertiary Fixed
    public string TertiaryFixed => "#CDC9FF";
    public string OnTertiaryFixed => "#040031";
    public string TertiaryFixedDim => "#BEBAFB";
    public string OnTertiaryFixedVariant => "#2E2B62";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#23262B";
    public string SurfaceContainer => "#2E3035";
    public string SurfaceContainerHigh => "#393B41";
    public string SurfaceContainerHighest => "#1E2633";
}
