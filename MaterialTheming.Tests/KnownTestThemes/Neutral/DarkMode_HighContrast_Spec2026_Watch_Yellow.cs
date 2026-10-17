namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_HighContrast_Spec2026_Watch_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFFFFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#A9A78E";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFFFF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#A8A69A";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFFFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#BBE09A";
    public string OnTertiaryContainer => "#0E2500";
    // Error
    public string Error => "#FFBFB0";
    public string OnError => "#000000";
    public string ErrorContainer => "#EA8D77";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#272713";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFEFF";
    public string SurfaceDim => "#0F0E07";
    public string SurfaceBright => "#2E2D16";
    public string SurfaceTint => "#FFFFFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#D1CEC1";
    public string OutlineVariant => "#A8A69A";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FDF9EC";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#000000";
    // Primary Fixed
    public string PrimaryFixed => "#E7E3C8";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#D8D5BA";
    public string OnPrimaryFixedVariant => "#21200F";
    // Secondary Fixed
    public string SecondaryFixed => "#E6E2D5";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#D8D4C7";
    public string OnSecondaryFixedVariant => "#202018";
    // Tertiary Fixed
    public string TertiaryFixed => "#D7FCB4";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#C9EEA7";
    public string OnTertiaryFixedVariant => "#153000";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#27261E";
    public string SurfaceContainer => "#313128";
    public string SurfaceContainerHigh => "#3D3C32";
    public string SurfaceContainerHighest => "#272713";
}
