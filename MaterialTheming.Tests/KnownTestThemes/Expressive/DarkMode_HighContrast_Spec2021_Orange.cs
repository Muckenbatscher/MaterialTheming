namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_HighContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#F2EDFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#C2BBFF";
    public string OnPrimaryContainer => "#080038";
    // Secondary
    public string Secondary => "#DAF9D1";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#ADCBA5";
    public string OnSecondaryContainer => "#000F01";
    // Tertiary
    public string Tertiary => "#BCFEE1";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#90D0B5";
    public string OnTertiaryContainer => "#000E08";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#1A1209";
    public string SurfaceVariant => "#554433";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#1A1209";
    public string SurfaceBright => "#5A4E43";
    public string SurfaceTint => "#C6BFFF";
    // Background
    public string Background => "#1A1209";
    public string OnBackground => "#F2DFD1";
    // Outline
    public string Outline => "#FFEDDE";
    public string OutlineVariant => "#D7BEA9";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F2DFD1";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#453F80";
    // Primary Fixed
    public string PrimaryFixed => "#E4DFFF";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#C6BFFF";
    public string OnPrimaryFixedVariant => "#0D0148";
    // Secondary Fixed
    public string SecondaryFixed => "#CCEBC4";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#B1CFA9";
    public string OnSecondaryFixedVariant => "#011602";
    // Tertiary Fixed
    public string TertiaryFixed => "#AFF0D4";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#94D4B9";
    public string OnTertiaryFixedVariant => "#00150D";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#271E15";
    public string SurfaceContainer => "#392E25";
    public string SurfaceContainerHigh => "#45392F";
    public string SurfaceContainerHighest => "#50453A";
}
