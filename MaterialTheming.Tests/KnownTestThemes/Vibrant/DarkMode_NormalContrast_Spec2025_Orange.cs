using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_NormalContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FF9248";
    public string OnPrimary => "#4F2100";
    public string PrimaryContainer => "#FF7B00";
    public string OnPrimaryContainer => "#3D1800";
    // Secondary
    public string Secondary => "#FD9831";
    public string OnSecondary => "#4C2700";
    public string SecondaryContainer => "#8E4E00";
    public string OnSecondaryContainer => "#FFF6F1";
    // Tertiary
    public string Tertiary => "#FFD47D";
    public string OnTertiary => "#634800";
    public string TertiaryContainer => "#FFC32D";
    public string OnTertiaryContainer => "#584000";
    // Error
    public string Error => "#FF7351";
    public string OnError => "#450900";
    public string ErrorContainer => "#B92902";
    public string OnErrorContainer => "#FFD2C8";
    // Surface
    public string Surface => "#1B0A00";
    public string SurfaceVariant => "#3D1E00";
    public string OnSurface => "#FFE0C8";
    public string OnSurfaceVariant => "#D6A072";
    public string SurfaceDim => "#1B0A00";
    public string SurfaceBright => "#462300";
    public string SurfaceTint => "#FF9248";
    // Background
    public string Background => "#1B0A00";
    public string OnBackground => "#FFE0C8";
    // Outline
    public string Outline => "#9A6B42";
    public string OutlineVariant => "#663F19";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F5";
    public string InverseOnSurface => "#754C25";
    public string InversePrimary => "#9A4700";
    // Primary Fixed
    public string PrimaryFixed => "#FF7B00";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#EB7000";
    public string OnPrimaryFixedVariant => "#4B2000";
    // Secondary Fixed
    public string SecondaryFixed => "#FFC697";
    public string OnSecondaryFixed => "#522A00";
    public string SecondaryFixedDim => "#FFB471";
    public string OnSecondaryFixedVariant => "#7B4200";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFC32D";
    public string OnTertiaryFixed => "#402D00";
    public string TertiaryFixedDim => "#F0B51C";
    public string OnTertiaryFixedVariant => "#634800";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#220E00";
    public string SurfaceContainer => "#2B1400";
    public string SurfaceContainerHigh => "#341900";
    public string SurfaceContainerHighest => "#3D1E00";
}
