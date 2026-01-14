using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_MediumContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFA268";
    public string OnPrimary => "#4B2000";
    public string PrimaryContainer => "#FF7B00";
    public string OnPrimaryContainer => "#270D00";
    // Secondary
    public string Secondary => "#FFA44D";
    public string OnSecondary => "#462300";
    public string SecondaryContainer => "#AF6100";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#FFD47D";
    public string OnTertiary => "#573F00";
    public string TertiaryContainer => "#FFC32D";
    public string OnTertiaryContainer => "#4C3600";
    // Error
    public string Error => "#FFA089";
    public string OnError => "#5A0E00";
    public string ErrorContainer => "#D53D18";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#1B0A00";
    public string SurfaceVariant => "#3D1E00";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E5AD7E";
    public string SurfaceDim => "#1B0A00";
    public string SurfaceBright => "#462300";
    public string SurfaceTint => "#FFA268";
    // Background
    public string Background => "#1B0A00";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#BC895C";
    public string OutlineVariant => "#9A6B42";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F5";
    public string InverseOnSurface => "#542F0A";
    public string InversePrimary => "#8A4000";
    // Primary Fixed
    public string PrimaryFixed => "#FF7B00";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#EB7000";
    public string OnPrimaryFixedVariant => "#000000";
    // Secondary Fixed
    public string SecondaryFixed => "#FFC697";
    public string OnSecondaryFixed => "#190900";
    public string SecondaryFixedDim => "#FFB471";
    public string OnSecondaryFixedVariant => "#522A00";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFC32D";
    public string OnTertiaryFixed => "#050300";
    public string TertiaryFixedDim => "#F0B51C";
    public string OnTertiaryFixedVariant => "#402D00";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#220E00";
    public string SurfaceContainer => "#2B1400";
    public string SurfaceContainerHigh => "#341900";
    public string SurfaceContainerHighest => "#3D1E00";
}
