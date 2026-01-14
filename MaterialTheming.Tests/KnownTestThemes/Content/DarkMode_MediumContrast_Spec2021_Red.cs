using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class DarkMode_MediumContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FFD2CD";
    public string OnPrimary => "#540003";
    public string PrimaryContainer => "#F55F53";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFD2CD";
    public string OnSecondary => "#4A110E";
    public string SecondaryContainer => "#CF7970";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFD69E";
    public string OnTertiary => "#362100";
    public string TertiaryContainer => "#BF8622";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#1D100F";
    public string SurfaceVariant => "#59413E";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#F8D4D0";
    public string SurfaceDim => "#1D100F";
    public string SurfaceBright => "#51403E";
    public string SurfaceTint => "#FFB4AB";
    // Background
    public string Background => "#1D100F";
    public string OnBackground => "#F6DDDA";
    // Outline
    public string Outline => "#CBAAA6";
    public string OutlineVariant => "#A88986";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F6DDDA";
    public string InverseOnSurface => "#352625";
    public string InversePrimary => "#901414";
    // Primary Fixed
    public string PrimaryFixed => "#FFDAD6";
    public string OnPrimaryFixed => "#2D0001";
    public string PrimaryFixedDim => "#FFB4AB";
    public string OnPrimaryFixedVariant => "#740006";
    // Secondary Fixed
    public string SecondaryFixed => "#FFDAD6";
    public string OnSecondaryFixed => "#2D0001";
    public string SecondaryFixedDim => "#FFB4AB";
    public string OnSecondaryFixedVariant => "#60221D";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFDDB1";
    public string OnTertiaryFixed => "#1B0F00";
    public string TertiaryFixedDim => "#FCBB54";
    public string OnTertiaryFixedVariant => "#4C3100";
    // Surface Container
    public string SurfaceContainerLowest => "#0F0504";
    public string SurfaceContainerLow => "#281A19";
    public string SurfaceContainer => "#332423";
    public string SurfaceContainerHigh => "#3E2F2D";
    public string SurfaceContainerHighest => "#4A3A38";
}
