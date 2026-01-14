using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_MediumContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#8AEDE4";
    public string OnPrimary => "#002B28";
    public string PrimaryContainer => "#36A098";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFD0E0";
    public string OnSecondary => "#3C1B29";
    public string SecondaryContainer => "#B48395";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFCDFB";
    public string OnTertiary => "#3B183D";
    public string TertiaryContainer => "#B082AE";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#181118";
    public string SurfaceVariant => "#4F4350";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E9D7E7";
    public string SurfaceDim => "#181118";
    public string SurfaceBright => "#4A424A";
    public string SurfaceTint => "#73D7CE";
    // Background
    public string Background => "#181118";
    public string OnBackground => "#ECDFE9";
    // Outline
    public string Outline => "#BEADBC";
    public string OutlineVariant => "#9B8C9A";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#ECDFE9";
    public string InverseOnSurface => "#2F282F";
    public string InversePrimary => "#00514D";
    // Primary Fixed
    public string PrimaryFixed => "#90F3EA";
    public string OnPrimaryFixed => "#001413";
    public string PrimaryFixedDim => "#73D7CE";
    public string OnPrimaryFixedVariant => "#003E3A";
    // Secondary Fixed
    public string SecondaryFixed => "#FFD9E5";
    public string OnSecondaryFixed => "#240615";
    public string SecondaryFixedDim => "#EEB8CB";
    public string OnSecondaryFixedVariant => "#4F2B3A";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFD6FA";
    public string OnTertiaryFixed => "#230227";
    public string TertiaryFixedDim => "#E9B6E6";
    public string OnTertiaryFixedVariant => "#4D284F";
    // Surface Container
    public string SurfaceContainerLowest => "#0B060C";
    public string SurfaceContainerLow => "#221B22";
    public string SurfaceContainer => "#2D262D";
    public string SurfaceContainerHigh => "#383038";
    public string SurfaceContainerHighest => "#433B43";
}
