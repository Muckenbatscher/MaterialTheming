using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_HighContrast_Spec2025_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#C9EFC8";
    public string OnPrimary => "#133218";
    public string PrimaryContainer => "#89AD89";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#D7EBD3";
    public string OnSecondary => "#1F3020";
    public string SecondaryContainer => "#96A993";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#F8FFBC";
    public string OnTertiary => "#363B0C";
    public string TertiaryContainer => "#E9F0AF";
    public string OnTertiaryContainer => "#2D3304";
    // Error
    public string Error => "#FFDED7";
    public string OnError => "#5A0E00";
    public string ErrorContainer => "#FF7E5E";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#0C0F0B";
    public string SurfaceVariant => "#202820";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E0E8DC";
    public string SurfaceDim => "#0C0F0B";
    public string SurfaceBright => "#272E26";
    public string SurfaceTint => "#C9EFC8";
    // Background
    public string Background => "#0C0F0B";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#B3BBB0";
    public string OutlineVariant => "#9EA69B";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F8FAF3";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#1F3F23";
    // Primary Fixed
    public string PrimaryFixed => "#C7ECC5";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#B9DEB8";
    public string OnPrimaryFixedVariant => "#05250D";
    // Secondary Fixed
    public string SecondaryFixed => "#D4E8D1";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#C6DAC3";
    public string OnSecondaryFixedVariant => "#132314";
    // Tertiary Fixed
    public string TertiaryFixed => "#F8FFBC";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#E9F0AF";
    public string OnTertiaryFixedVariant => "#2D3304";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#101510";
    public string SurfaceContainer => "#151B15";
    public string SurfaceContainerHigh => "#1B211B";
    public string SurfaceContainerHighest => "#202820";
}
