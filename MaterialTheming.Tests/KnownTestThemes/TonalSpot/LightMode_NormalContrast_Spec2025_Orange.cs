using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_NormalContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#88512E";
    public string OnPrimary => "#FFF7F5";
    public string PrimaryContainer => "#FFB68B";
    public string OnPrimaryContainer => "#633412";
    // Secondary
    public string Secondary => "#765947";
    public string OnSecondary => "#FFF7F5";
    public string SecondaryContainer => "#FFDBC8";
    public string OnSecondaryContainer => "#684C3B";
    // Tertiary
    public string Tertiary => "#6B5F27";
    public string OnTertiary => "#FFF8EB";
    public string TertiaryContainer => "#FAE8A2";
    public string OnTertiaryContainer => "#61551E";
    // Error
    public string Error => "#A73B21";
    public string OnError => "#FFF7F6";
    public string ErrorContainer => "#FD795A";
    public string OnErrorContainer => "#6E1400";
    // Surface
    public string Surface => "#FFF8F5";
    public string SurfaceVariant => "#F5DED2";
    public string OnSurface => "#3D3028";
    public string OnSurfaceVariant => "#6C5C53";
    public string SurfaceDim => "#ECD6CA";
    public string SurfaceBright => "#FFF8F5";
    public string SurfaceTint => "#88512E";
    // Background
    public string Background => "#FFF8F5";
    public string OnBackground => "#3D3028";
    // Outline
    public string Outline => "#89776D";
    public string OutlineVariant => "#C3AEA3";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#130D09";
    public string InverseOnSurface => "#A79A94";
    public string InversePrimary => "#FFB68B";
    // Primary Fixed
    public string PrimaryFixed => "#FFB68B";
    public string OnPrimaryFixed => "#4B2002";
    public string PrimaryFixedDim => "#F0A97E";
    public string OnPrimaryFixedVariant => "#6E3C1A";
    // Secondary Fixed
    public string SecondaryFixed => "#FFDBC8";
    public string OnSecondaryFixed => "#533A2A";
    public string SecondaryFixedDim => "#F4CCB7";
    public string OnSecondaryFixedVariant => "#725544";
    // Tertiary Fixed
    public string TertiaryFixed => "#FAE8A2";
    public string OnTertiaryFixed => "#4E420C";
    public string TertiaryFixedDim => "#ECDA95";
    public string OnTertiaryFixedVariant => "#6B5F27";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1EA";
    public string SurfaceContainer => "#FEEAE0";
    public string SurfaceContainerHigh => "#F9E4DA";
    public string SurfaceContainerHighest => "#F5DED2";
}
