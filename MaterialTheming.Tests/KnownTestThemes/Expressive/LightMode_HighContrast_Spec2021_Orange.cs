namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_HighContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#292262";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#474181";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#193217";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#364F32";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#003325";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#0D533F";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F5";
    public string SurfaceVariant => "#F8DEC7";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#C7B6A8";
    public string SurfaceBright => "#FFF8F5";
    public string SurfaceTint => "#5C5698";
    // Background
    public string Background => "#FFF8F5";
    public string OnBackground => "#231A11";
    // Outline
    public string Outline => "#38291A";
    public string OutlineVariant => "#574635";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#392E25";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#C6BFFF";
    // Primary Fixed
    public string PrimaryFixed => "#474181";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#302969";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#364F32";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#20381D";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#0D533F";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#003B2A";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFEEE0";
    public string SurfaceContainer => "#F2DFD1";
    public string SurfaceContainerHigh => "#E3D1C3";
    public string SurfaceContainerHighest => "#D5C3B5";
}
