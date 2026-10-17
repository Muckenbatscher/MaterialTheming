namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_NormalContrast_Spec2026_Watch_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#D9E3F8";
    public string OnPrimary => "#364051";
    public string PrimaryContainer => "#3D4758";
    public string OnPrimaryContainer => "#D6E0F6";
    // Secondary
    public string Secondary => "#DEE2EF";
    public string OnSecondary => "#3A3F49";
    public string SecondaryContainer => "#424751";
    public string OnSecondaryContainer => "#DCE0EC";
    // Tertiary
    public string Tertiary => "#CDC9FF";
    public string OnTertiary => "#2E2B62";
    public string TertiaryContainer => "#B0ADEC";
    public string OnTertiaryContainer => "#232057";
    // Error
    public string Error => "#FFBEB9";
    public string OnError => "#3C0507";
    public string ErrorContainer => "#77302E";
    public string OnErrorContainer => "#FFD7D4";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#1E2633";
    public string OnSurface => "#E7E8EE";
    public string OnSurfaceVariant => "#CDCED4";
    public string SurfaceDim => "#0C0E13";
    public string SurfaceBright => "#232C3B";
    public string SurfaceTint => "#D9E3F8";
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
    public string InverseOnSurface => "#53555A";
    public string InversePrimary => "#4B5567";
    // Primary Fixed
    public string PrimaryFixed => "#D9E3F8";
    public string OnPrimaryFixed => "#364051";
    public string PrimaryFixedDim => "#CAD5EA";
    public string OnPrimaryFixedVariant => "#3D4758";
    // Secondary Fixed
    public string SecondaryFixed => "#DEE2EF";
    public string OnSecondaryFixed => "#3A3F49";
    public string SecondaryFixedDim => "#D0D4E0";
    public string OnSecondaryFixedVariant => "#424751";
    // Tertiary Fixed
    public string TertiaryFixed => "#CDC9FF";
    public string OnTertiaryFixed => "#2E2B62";
    public string TertiaryFixedDim => "#BEBAFB";
    public string OnTertiaryFixedVariant => "#434078";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#23262B";
    public string SurfaceContainer => "#2E3035";
    public string SurfaceContainerHigh => "#393B41";
    public string SurfaceContainerHighest => "#1E2633";
}
