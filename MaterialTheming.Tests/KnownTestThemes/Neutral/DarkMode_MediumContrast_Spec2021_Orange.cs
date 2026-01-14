using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_MediumContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#F5D6C6";
    public string OnPrimary => "#332217";
    public string PrimaryContainer => "#A68B7D";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#EED8CD";
    public string OnSecondary => "#2F231C";
    public string SecondaryContainer => "#9F8D84";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FCD4BE";
    public string OnTertiary => "#372012";
    public string TertiaryContainer => "#AC8A76";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#161311";
    public string SurfaceVariant => "#4A4644";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E2DBD8";
    public string SurfaceDim => "#161311";
    public string SurfaceBright => "#484442";
    public string SurfaceTint => "#DEC1B1";
    // Background
    public string Background => "#161311";
    public string OnBackground => "#E9E1DE";
    // Outline
    public string Outline => "#B7B0AE";
    public string OutlineVariant => "#958F8D";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E9E1DE";
    public string InverseOnSurface => "#2D2928";
    public string InversePrimary => "#584438";
    // Primary Fixed
    public string PrimaryFixed => "#FBDCCC";
    public string OnPrimaryFixed => "#1C0E05";
    public string PrimaryFixedDim => "#DEC1B1";
    public string OnPrimaryFixedVariant => "#453227";
    // Secondary Fixed
    public string SecondaryFixed => "#F4DED3";
    public string OnSecondaryFixed => "#190F09";
    public string SecondaryFixedDim => "#D7C2B8";
    public string OnSecondaryFixedVariant => "#41332C";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFDBC8";
    public string OnTertiaryFixed => "#1F0C03";
    public string TertiaryFixedDim => "#E5BFA9";
    public string OnTertiaryFixedVariant => "#493121";
    // Surface Container
    public string SurfaceContainerLowest => "#090706";
    public string SurfaceContainerLow => "#201D1B";
    public string SurfaceContainer => "#2B2725";
    public string SurfaceContainerHigh => "#363230";
    public string SurfaceContainerHighest => "#413D3B";
}
