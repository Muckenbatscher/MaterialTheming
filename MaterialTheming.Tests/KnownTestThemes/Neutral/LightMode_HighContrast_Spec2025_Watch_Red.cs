namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_HighContrast_Spec2025_Watch_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFFFFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#BD9F9B";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFFFF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#B2A2A0";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFFFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#EFA172";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFBDC3";
    public string OnError => "#000000";
    public string ErrorContainer => "#E88B96";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#35201E";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFEFF";
    public string SurfaceDim => "#140C0B";
    public string SurfaceBright => "#3E2623";
    public string SurfaceTint => "#FFFFFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#DCCAC8";
    public string OutlineVariant => "#B2A2A0";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F7";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#000000";
    // Primary Fixed
    public string PrimaryFixed => "#FDDBD7";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#EECDC9";
    public string OnPrimaryFixedVariant => "#2D1B19";
    // Secondary Fixed
    public string SecondaryFixed => "#F1DEDC";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#E2D0CE";
    public string OnSecondaryFixedVariant => "#271D1C";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFC29E";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#FFAF7E";
    public string OnTertiaryFixedVariant => "#140500";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#2D2322";
    public string SurfaceContainer => "#392E2D";
    public string SurfaceContainerHigh => "#443937";
    public string SurfaceContainerHighest => "#35201E";
}
