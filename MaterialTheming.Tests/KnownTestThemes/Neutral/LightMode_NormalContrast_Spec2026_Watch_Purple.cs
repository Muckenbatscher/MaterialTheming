namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_NormalContrast_Spec2026_Watch_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#EBDEF0";
    public string OnPrimary => "#443C4A";
    public string PrimaryContainer => "#4C4452";
    public string OnPrimaryContainer => "#E8DCEE";
    // Secondary
    public string Secondary => "#E8E0E8";
    public string OnSecondary => "#423E44";
    public string SecondaryContainer => "#4A454C";
    public string OnSecondaryContainer => "#E5DEE6";
    // Tertiary
    public string Tertiary => "#FDBEF1";
    public string OnTertiary => "#51234C";
    public string TertiaryContainer => "#E0A3D5";
    public string OnTertiaryContainer => "#451841";
    // Error
    public string Error => "#FFBDC3";
    public string OnError => "#3C0311";
    public string ErrorContainer => "#76303A";
    public string OnErrorContainer => "#FFD6D9";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#2A2331";
    public string OnSurface => "#EEE6EE";
    public string OnSurfaceVariant => "#D3CCD3";
    public string SurfaceDim => "#100D12";
    public string SurfaceBright => "#31293A";
    public string SurfaceTint => "#EBDEF0";
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
    public string InverseOnSurface => "#58535A";
    public string InversePrimary => "#5A5261";
    // Primary Fixed
    public string PrimaryFixed => "#EBDEF0";
    public string OnPrimaryFixed => "#443C4A";
    public string PrimaryFixedDim => "#DCD0E2";
    public string OnPrimaryFixedVariant => "#4C4452";
    // Secondary Fixed
    public string SecondaryFixed => "#E8E0E8";
    public string OnSecondaryFixed => "#423E44";
    public string SecondaryFixedDim => "#DAD2DA";
    public string OnSecondaryFixedVariant => "#4A454C";
    // Tertiary Fixed
    public string TertiaryFixed => "#FDBEF1";
    public string OnTertiaryFixed => "#51234C";
    public string TertiaryFixedDim => "#EFB0E3";
    public string OnTertiaryFixedVariant => "#663560";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#28242A";
    public string SurfaceContainer => "#332F35";
    public string SurfaceContainerHigh => "#3E3A40";
    public string SurfaceContainerHighest => "#2A2331";
}
