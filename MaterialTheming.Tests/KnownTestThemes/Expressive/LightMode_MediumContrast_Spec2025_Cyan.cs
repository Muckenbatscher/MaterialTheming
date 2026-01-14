using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_MediumContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#004A53";
    public string OnPrimary => "#6DEBFF";
    public string PrimaryContainer => "#00818F";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#4B3D5D";
    public string OnSecondary => "#E5D2FB";
    public string SecondaryContainer => "#7E6E92";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#582E7E";
    public string OnTertiary => "#EBD0FF";
    public string TertiaryContainer => "#8D61B4";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#84161B";
    public string OnError => "#FFCECA";
    public string ErrorContainer => "#C94947";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F2FBFF";
    public string SurfaceVariant => "#B4EBFE";
    public string OnSurface => "#002832";
    public string OnSurfaceVariant => "#064959";
    public string SurfaceDim => "#A6E3F8";
    public string SurfaceBright => "#F2FBFF";
    public string SurfaceTint => "#004A53";
    // Background
    public string Background => "#F2FBFF";
    public string OnBackground => "#002832";
    // Outline
    public string Outline => "#2F6676";
    public string OutlineVariant => "#4D8293";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#001016";
    public string InverseOnSurface => "#ADC9D4";
    public string InversePrimary => "#61E6FB";
    // Primary Fixed
    public string PrimaryFixed => "#00818F";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#007380";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#7E6E92";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#716284";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#8D61B4";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#8055A7";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#E3F7FF";
    public string SurfaceContainer => "#D3F3FF";
    public string SurfaceContainerHigh => "#C3EFFF";
    public string SurfaceContainerHighest => "#B4EBFE";
}
