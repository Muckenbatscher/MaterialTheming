namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_NormalContrast_Spec2026_Watch_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FDDBD7";
    public string OnPrimary => "#503A37";
    public string PrimaryContainer => "#58413F";
    public string OnPrimaryContainer => "#FAD9D4";
    // Secondary
    public string Secondary => "#F1DEDC";
    public string OnSecondary => "#483D3B";
    public string SecondaryContainer => "#504443";
    public string OnSecondaryContainer => "#EEDCDA";
    // Tertiary
    public string Tertiary => "#FFC29E";
    public string OnTertiary => "#552400";
    public string TertiaryContainer => "#EFA172";
    public string OnTertiaryContainer => "#451C00";
    // Error
    public string Error => "#FFBDC3";
    public string OnError => "#3C0311";
    public string ErrorContainer => "#76303A";
    public string OnErrorContainer => "#FFD6D9";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#35201E";
    public string OnSurface => "#F6E4E2";
    public string OnSurfaceVariant => "#DCCAC8";
    public string SurfaceDim => "#140C0B";
    public string SurfaceBright => "#3E2623";
    public string SurfaceTint => "#FDDBD7";
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
    public string InverseOnSurface => "#5F5251";
    public string InversePrimary => "#674F4C";
    // Primary Fixed
    public string PrimaryFixed => "#FDDBD7";
    public string OnPrimaryFixed => "#503A37";
    public string PrimaryFixedDim => "#EECDC9";
    public string OnPrimaryFixedVariant => "#58413F";
    // Secondary Fixed
    public string SecondaryFixed => "#F1DEDC";
    public string OnSecondaryFixed => "#483D3B";
    public string SecondaryFixedDim => "#E2D0CE";
    public string OnSecondaryFixedVariant => "#504443";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFC29E";
    public string OnTertiaryFixed => "#552400";
    public string TertiaryFixedDim => "#FFAF7E";
    public string OnTertiaryFixedVariant => "#6F3811";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#2D2322";
    public string SurfaceContainer => "#392E2D";
    public string SurfaceContainerHigh => "#443937";
    public string SurfaceContainerHighest => "#35201E";
}
