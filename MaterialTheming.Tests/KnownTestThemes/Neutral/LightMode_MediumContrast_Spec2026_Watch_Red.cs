namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_MediumContrast_Spec2026_Watch_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFFEFF";
    public string OnPrimary => "#2D1B19";
    public string PrimaryContainer => "#9B7F7C";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFEFF";
    public string OnSecondary => "#271D1C";
    public string SecondaryContainer => "#918280";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFEFF";
    public string OnTertiary => "#140500";
    public string TertiaryContainer => "#EFA172";
    public string OnTertiaryContainer => "#451C00";
    // Error
    public string Error => "#FFBDC3";
    public string OnError => "#3B0310";
    public string ErrorContainer => "#C26C77";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#35201E";
    public string OnSurface => "#FFFEFF";
    public string OnSurfaceVariant => "#DCCAC8";
    public string SurfaceDim => "#140C0B";
    public string SurfaceBright => "#3E2623";
    public string SurfaceTint => "#FFFEFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#B2A2A0";
    public string OutlineVariant => "#918280";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F7";
    public string InverseOnSurface => "#413634";
    public string InversePrimary => "#483330";
    // Primary Fixed
    public string PrimaryFixed => "#FDDBD7";
    public string OnPrimaryFixed => "#2D1B19";
    public string PrimaryFixedDim => "#EECDC9";
    public string OnPrimaryFixedVariant => "#503A37";
    // Secondary Fixed
    public string SecondaryFixed => "#F1DEDC";
    public string OnSecondaryFixed => "#271D1C";
    public string SecondaryFixedDim => "#E2D0CE";
    public string OnSecondaryFixedVariant => "#483D3B";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFC29E";
    public string OnTertiaryFixed => "#140500";
    public string TertiaryFixedDim => "#FFAF7E";
    public string OnTertiaryFixedVariant => "#552400";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#2D2322";
    public string SurfaceContainer => "#392E2D";
    public string SurfaceContainerHigh => "#443937";
    public string SurfaceContainerHighest => "#35201E";
}
