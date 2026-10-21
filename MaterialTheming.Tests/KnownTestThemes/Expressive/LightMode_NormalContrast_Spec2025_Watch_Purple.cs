namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_NormalContrast_Spec2025_Watch_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#E2C2FF";
    public string OnPrimary => "#422360";
    public string PrimaryContainer => "#573877";
    public string OnPrimaryContainer => "#EED8FF";
    // Secondary
    public string Secondary => "#C7ECCB";
    public string OnSecondary => "#27462E";
    public string SecondaryContainer => "#2E4E35";
    public string OnSecondaryContainer => "#C5E9C9";
    // Tertiary
    public string Tertiary => "#ABFEB3";
    public string OnTertiary => "#00501E";
    public string TertiaryContainer => "#90E198";
    public string OnTertiaryContainer => "#00461A";
    // Error
    public string Error => "#FFBDC3";
    public string OnError => "#3F000F";
    public string ErrorContainer => "#7D2938";
    public string OnErrorContainer => "#FFD6D9";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#302035";
    public string OnSurface => "#F4E3F4";
    public string OnSurfaceVariant => "#D9C9DA";
    public string SurfaceDim => "#130B16";
    public string SurfaceBright => "#37253E";
    public string SurfaceTint => "#E2C2FF";
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
    public string InverseOnSurface => "#5D515F";
    public string InversePrimary => "#664786";
    // Primary Fixed
    public string PrimaryFixed => "#E2C2FF";
    public string OnPrimaryFixed => "#422360";
    public string PrimaryFixedDim => "#D7B2FA";
    public string OnPrimaryFixedVariant => "#573877";
    // Secondary Fixed
    public string SecondaryFixed => "#C7ECCB";
    public string OnSecondaryFixed => "#27462E";
    public string SecondaryFixedDim => "#B9DEBD";
    public string OnSecondaryFixedVariant => "#2E4E35";
    // Tertiary Fixed
    public string TertiaryFixed => "#ABFEB3";
    public string OnTertiaryFixed => "#00501E";
    public string TertiaryFixedDim => "#9DF0A5";
    public string OnTertiaryFixedVariant => "#00531F";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#2C222F";
    public string SurfaceContainer => "#372D3A";
    public string SurfaceContainerHigh => "#423845";
    public string SurfaceContainerHighest => "#302035";
}
