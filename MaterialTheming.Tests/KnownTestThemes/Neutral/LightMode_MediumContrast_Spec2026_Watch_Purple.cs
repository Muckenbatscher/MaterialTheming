namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_MediumContrast_Spec2026_Watch_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFFEFF";
    public string OnPrimary => "#231D29";
    public string PrimaryContainer => "#8C8292";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFEFF";
    public string OnSecondary => "#221E24";
    public string SecondaryContainer => "#8A848B";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFEFF";
    public string OnTertiary => "#20001F";
    public string TertiaryContainer => "#E0A3D5";
    public string OnTertiaryContainer => "#451841";
    // Error
    public string Error => "#FFBDC3";
    public string OnError => "#3B0310";
    public string ErrorContainer => "#C26C77";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#2A2331";
    public string OnSurface => "#FFFEFF";
    public string OnSurfaceVariant => "#D3CCD3";
    public string SurfaceDim => "#100D12";
    public string SurfaceBright => "#31293A";
    public string SurfaceTint => "#FFFEFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#AAA4AB";
    public string OutlineVariant => "#8A848B";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF7FE";
    public string InverseOnSurface => "#3B373D";
    public string InversePrimary => "#3D3543";
    // Primary Fixed
    public string PrimaryFixed => "#EBDEF0";
    public string OnPrimaryFixed => "#231D29";
    public string PrimaryFixedDim => "#DCD0E2";
    public string OnPrimaryFixedVariant => "#443C4A";
    // Secondary Fixed
    public string SecondaryFixed => "#E8E0E8";
    public string OnSecondaryFixed => "#221E24";
    public string SecondaryFixedDim => "#DAD2DA";
    public string OnSecondaryFixedVariant => "#423E44";
    // Tertiary Fixed
    public string TertiaryFixed => "#FDBEF1";
    public string OnTertiaryFixed => "#20001F";
    public string TertiaryFixedDim => "#EFB0E3";
    public string OnTertiaryFixedVariant => "#51234C";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#28242A";
    public string SurfaceContainer => "#332F35";
    public string SurfaceContainerHigh => "#3E3A40";
    public string SurfaceContainerHighest => "#2A2331";
}
