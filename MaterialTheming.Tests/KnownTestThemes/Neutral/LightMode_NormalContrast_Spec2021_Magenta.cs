namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_NormalContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#6D5962";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#F7DBE6";
    public string OnPrimaryContainer => "#54424A";
    // Secondary
    public string Secondary => "#685B60";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#F1DEE4";
    public string OnSecondaryContainer => "#504348";
    // Tertiary
    public string Tertiary => "#725763";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#FDD9E8";
    public string OnTertiaryContainer => "#58404B";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#FFF8F8";
    public string SurfaceVariant => "#E8E1E1";
    public string OnSurface => "#1E1B1C";
    public string OnSurfaceVariant => "#4A4647";
    public string SurfaceDim => "#DFD8D9";
    public string SurfaceBright => "#FFF8F8";
    public string SurfaceTint => "#6D5962";
    // Background
    public string Background => "#FFF8F8";
    public string OnBackground => "#1E1B1C";
    // Outline
    public string Outline => "#7B7677";
    public string OutlineVariant => "#CBC5C6";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#333030";
    public string InverseOnSurface => "#F6EFF0";
    public string InversePrimary => "#DAC0CA";
    // Primary Fixed
    public string PrimaryFixed => "#F7DBE6";
    public string OnPrimaryFixed => "#26171E";
    public string PrimaryFixedDim => "#DAC0CA";
    public string OnPrimaryFixedVariant => "#54424A";
    // Secondary Fixed
    public string SecondaryFixed => "#F1DEE4";
    public string OnSecondaryFixed => "#23191D";
    public string SecondaryFixedDim => "#D4C2C8";
    public string OnSecondaryFixedVariant => "#504348";
    // Tertiary Fixed
    public string TertiaryFixed => "#FDD9E8";
    public string OnTertiaryFixed => "#291520";
    public string TertiaryFixedDim => "#E0BDCC";
    public string OnTertiaryFixedVariant => "#58404B";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F9F2F3";
    public string SurfaceContainer => "#F3ECED";
    public string SurfaceContainerHigh => "#EEE6E7";
    public string SurfaceContainerHighest => "#E8E1E1";
}
