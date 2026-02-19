namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_NormalContrast_Spec2026_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#C6FFC7";
    public string OnPrimary => "#326539";
    public string PrimaryContainer => "#B8F1B9";
    public string OnPrimaryContainer => "#295C32";
    // Secondary
    public string Secondary => "#E5BFAA";
    public string OnSecondary => "#543A2B";
    public string SecondaryContainer => "#372013";
    public string OnSecondaryContainer => "#C09C89";
    // Tertiary
    public string Tertiary => "#FFB692";
    public string OnTertiary => "#6F2B00";
    public string TertiaryContainer => "#FFA273";
    public string OnTertiaryContainer => "#602400";
    // Error
    public string Error => "#FE7453";
    public string OnError => "#450900";
    public string ErrorContainer => "#881F05";
    public string OnErrorContainer => "#FF9B82";
    // Surface
    public string Surface => "#031108";
    public string SurfaceVariant => "#0B2C1A";
    public string OnSurface => "#CAEED4";
    public string OnSurfaceVariant => "#90B39B";
    public string SurfaceDim => "#031108";
    public string SurfaceBright => "#0D331F";
    public string SurfaceTint => "#C6FFC7";
    // Background
    public string Background => "#031108";
    public string OnBackground => "#CAEED4";
    // Outline
    public string Outline => "#5C7D67";
    public string OutlineVariant => "#2F4F3B";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#EBFEEE";
    public string InverseOnSurface => "#48594D";
    public string InversePrimary => "#376A3E";
    // Primary Fixed
    public string PrimaryFixed => "#B8F1B9";
    public string OnPrimaryFixed => "#154921";
    public string PrimaryFixedDim => "#AAE2AC";
    public string OnPrimaryFixedVariant => "#33663B";
    // Secondary Fixed
    public string SecondaryFixed => "#FFDBC8";
    public string OnSecondaryFixed => "#53392A";
    public string SecondaryFixedDim => "#F4CCB7";
    public string OnSecondaryFixedVariant => "#725544";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFA273";
    public string OnTertiaryFixed => "#3C1400";
    public string TertiaryFixedDim => "#F7915B";
    public string OnTertiaryFixedVariant => "#6E2B00";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#04170C";
    public string SurfaceContainer => "#061E11";
    public string SurfaceContainerHigh => "#082516";
    public string SurfaceContainerHighest => "#0B2C1A";
}
