namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_HighContrast_Spec2025_Watch_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFFFFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#BB97DD";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFFFF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#8BAE90";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFFFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#90E198";
    public string OnTertiaryContainer => "#002008";
    // Error
    public string Error => "#FFBDC3";
    public string OnError => "#000000";
    public string ErrorContainer => "#F38593";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#302035";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFEFF";
    public string SurfaceDim => "#130B16";
    public string SurfaceBright => "#37253E";
    public string SurfaceTint => "#FFFFFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#D9C9DA";
    public string OutlineVariant => "#B0A1B1";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF7FB";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#000000";
    // Primary Fixed
    public string PrimaryFixed => "#E2C2FF";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#D7B2FA";
    public string OnPrimaryFixedVariant => "#110025";
    // Secondary Fixed
    public string SecondaryFixed => "#C7ECCB";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#B9DEBD";
    public string OnSecondaryFixedVariant => "#052510";
    // Tertiary Fixed
    public string TertiaryFixed => "#ABFEB3";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#9DF0A5";
    public string OnTertiaryFixedVariant => "#002D0E";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#2C222F";
    public string SurfaceContainer => "#372D3A";
    public string SurfaceContainerHigh => "#423845";
    public string SurfaceContainerHighest => "#302035";
}
