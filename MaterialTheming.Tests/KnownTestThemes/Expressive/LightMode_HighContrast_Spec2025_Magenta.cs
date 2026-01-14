using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_HighContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#4B0132";
    public string OnPrimary => "#FFCCE3";
    public string PrimaryContainer => "#853563";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#002927";
    public string OnSecondary => "#B3E3DE";
    public string SecondaryContainer => "#2C5A56";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#002924";
    public string OnTertiary => "#6BEFDC";
    public string TertiaryContainer => "#005D53";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#500016";
    public string OnError => "#FFCED2";
    public string ErrorContainer => "#9A243D";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F8";
    public string SurfaceVariant => "#FFD8E8";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#3D162C";
    public string SurfaceDim => "#FFCCE3";
    public string SurfaceBright => "#FFF8F8";
    public string SurfaceTint => "#4B0132";
    // Background
    public string Background => "#FFF8F8";
    public string OnBackground => "#000000";
    // Outline
    public string Outline => "#61354C";
    public string OutlineVariant => "#72435C";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#1C0712";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#FFACD5";
    // Primary Fixed
    public string PrimaryFixed => "#853563";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#772957";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#2C5A56";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#1F4E4A";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#005D53";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#005048";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0F4";
    public string SurfaceContainer => "#FFE8F0";
    public string SurfaceContainerHigh => "#FFE0EC";
    public string SurfaceContainerHighest => "#FFD8E8";
}
