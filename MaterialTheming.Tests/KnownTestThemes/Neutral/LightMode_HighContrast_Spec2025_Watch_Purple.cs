namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_HighContrast_Spec2025_Watch_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFFFFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#ADA2B3";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFFFF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#AAA4AB";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFFFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#E0A3D5";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFBDC3";
    public string OnError => "#000000";
    public string ErrorContainer => "#E88B96";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#2A2331";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFEFF";
    public string SurfaceDim => "#100D12";
    public string SurfaceBright => "#31293A";
    public string SurfaceTint => "#FFFFFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#D3CCD3";
    public string OutlineVariant => "#AAA4AB";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF7FE";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#000000";
    // Primary Fixed
    public string PrimaryFixed => "#EBDEF0";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#DCD0E2";
    public string OnPrimaryFixedVariant => "#231D29";
    // Secondary Fixed
    public string SecondaryFixed => "#E8E0E8";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#DAD2DA";
    public string OnSecondaryFixedVariant => "#221E24";
    // Tertiary Fixed
    public string TertiaryFixed => "#FDBEF1";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#EFB0E3";
    public string OnTertiaryFixedVariant => "#20001F";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#28242A";
    public string SurfaceContainer => "#332F35";
    public string SurfaceContainerHigh => "#3E3A40";
    public string SurfaceContainerHighest => "#2A2331";
}
