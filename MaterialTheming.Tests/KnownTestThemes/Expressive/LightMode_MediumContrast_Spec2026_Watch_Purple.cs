namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_MediumContrast_Spec2026_Watch_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFFEFF";
    public string OnPrimary => "#110025";
    public string PrimaryContainer => "#9977BB";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFFFA";
    public string OnSecondary => "#052510";
    public string SecondaryContainer => "#6C8E71";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFFFA";
    public string OnTertiary => "#002D0E";
    public string TertiaryContainer => "#90E198";
    public string OnTertiaryContainer => "#00461A";
    // Error
    public string Error => "#FFBDC3";
    public string OnError => "#3D000F";
    public string ErrorContainer => "#CC6674";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#302035";
    public string OnSurface => "#FFFEFF";
    public string OnSurfaceVariant => "#D9C9DA";
    public string SurfaceDim => "#130B16";
    public string SurfaceBright => "#37253E";
    public string SurfaceTint => "#FFFEFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#B0A1B1";
    public string OutlineVariant => "#8F8190";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF7FB";
    public string InverseOnSurface => "#3F3542";
    public string InversePrimary => "#482967";
    // Primary Fixed
    public string PrimaryFixed => "#E2C2FF";
    public string OnPrimaryFixed => "#110025";
    public string PrimaryFixedDim => "#D7B2FA";
    public string OnPrimaryFixedVariant => "#422360";
    // Secondary Fixed
    public string SecondaryFixed => "#C7ECCB";
    public string OnSecondaryFixed => "#052510";
    public string SecondaryFixedDim => "#B9DEBD";
    public string OnSecondaryFixedVariant => "#27462E";
    // Tertiary Fixed
    public string TertiaryFixed => "#ABFEB3";
    public string OnTertiaryFixed => "#002D0E";
    public string TertiaryFixedDim => "#9DF0A5";
    public string OnTertiaryFixedVariant => "#00501E";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#2C222F";
    public string SurfaceContainer => "#372D3A";
    public string SurfaceContainerHigh => "#423845";
    public string SurfaceContainerHighest => "#302035";
}
