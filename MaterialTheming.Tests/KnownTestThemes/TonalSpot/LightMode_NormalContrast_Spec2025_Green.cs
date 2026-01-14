using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_NormalContrast_Spec2025_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#3D6942";
    public string OnPrimary => "#E9FFE5";
    public string PrimaryContainer => "#BEEFBE";
    public string OnPrimaryContainer => "#305B36";
    // Secondary
    public string Secondary => "#526451";
    public string OnSecondary => "#EAFFE6";
    public string SecondaryContainer => "#D4E8D1";
    public string OnSecondaryContainer => "#455644";
    // Tertiary
    public string Tertiary => "#5C6330";
    public string OnTertiary => "#F7FEBC";
    public string TertiaryContainer => "#F8FFBC";
    public string OnTertiaryContainer => "#5C632F";
    // Error
    public string Error => "#A73B21";
    public string OnError => "#FFF7F6";
    public string ErrorContainer => "#FD795A";
    public string OnErrorContainer => "#6E1400";
    // Surface
    public string Surface => "#F8FAF3";
    public string SurfaceVariant => "#DDE5D9";
    public string OnSurface => "#2D342C";
    public string OnSurfaceVariant => "#596158";
    public string SurfaceDim => "#D4DCD0";
    public string SurfaceBright => "#F8FAF3";
    public string SurfaceTint => "#3D6942";
    // Background
    public string Background => "#F8FAF3";
    public string OnBackground => "#2D342C";
    // Outline
    public string Outline => "#757D73";
    public string OutlineVariant => "#ACB4A9";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#0C0F0B";
    public string InverseOnSurface => "#9B9E98";
    public string InversePrimary => "#C6F8C6";
    // Primary Fixed
    public string PrimaryFixed => "#BEEFBE";
    public string OnPrimaryFixed => "#1D4825";
    public string PrimaryFixedDim => "#B0E1B0";
    public string OnPrimaryFixedVariant => "#3A653F";
    // Secondary Fixed
    public string SecondaryFixed => "#D4E8D1";
    public string OnSecondaryFixed => "#334433";
    public string SecondaryFixedDim => "#C6DAC3";
    public string OnSecondaryFixedVariant => "#4E604E";
    // Tertiary Fixed
    public string TertiaryFixed => "#F8FFBC";
    public string OnTertiaryFixed => "#4A511F";
    public string TertiaryFixedDim => "#E9F0AF";
    public string OnTertiaryFixedVariant => "#676E39";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F1F5EC";
    public string SurfaceContainer => "#EAF0E6";
    public string SurfaceContainerHigh => "#E4EADF";
    public string SurfaceContainerHighest => "#DDE5D9";
}
