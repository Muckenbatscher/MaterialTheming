using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_MediumContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FFD2C9";
    public string OnPrimary => "#4B1107";
    public string PrimaryContainer => "#D17967";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#BAE6D1";
    public string OnSecondary => "#002C1F";
    public string SecondaryContainer => "#709A87";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#A2E9E7";
    public string OnTertiary => "#002B2A";
    public string TertiaryContainer => "#559C9A";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#0D1511";
    public string SurfaceVariant => "#3B4A41";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#D0E0D5";
    public string SurfaceDim => "#0D1511";
    public string SurfaceBright => "#3E4641";
    public string SurfaceTint => "#FFB4A5";
    // Background
    public string Background => "#0D1511";
    public string OnBackground => "#DCE5DD";
    // Outline
    public string Outline => "#A5B6AB";
    public string OutlineVariant => "#84948A";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#DCE5DD";
    public string InverseOnSurface => "#232C27";
    public string InversePrimary => "#783325";
    // Primary Fixed
    public string PrimaryFixed => "#FFDAD3";
    public string OnPrimaryFixed => "#2B0200";
    public string PrimaryFixedDim => "#FFB4A5";
    public string OnPrimaryFixedVariant => "#612115";
    // Secondary Fixed
    public string SecondaryFixed => "#C0ECD7";
    public string OnSecondaryFixed => "#00150D";
    public string SecondaryFixedDim => "#A4D0BC";
    public string OnSecondaryFixedVariant => "#133D2F";
    // Tertiary Fixed
    public string TertiaryFixed => "#A8EFED";
    public string OnTertiaryFixed => "#001414";
    public string TertiaryFixedDim => "#8CD3D1";
    public string OnTertiaryFixedVariant => "#003D3C";
    // Surface Container
    public string SurfaceContainerLowest => "#030905";
    public string SurfaceContainerLow => "#171F1B";
    public string SurfaceContainer => "#212A25";
    public string SurfaceContainerHigh => "#2C352F";
    public string SurfaceContainerHighest => "#37403A";
}
