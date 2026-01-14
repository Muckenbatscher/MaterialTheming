using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_HighContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FFF0B3";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#DAC349";
    public string OnPrimaryContainer => "#0F0B00";
    // Secondary
    public string Secondary => "#FFF0B3";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#D5C36C";
    public string OnSecondaryContainer => "#0F0B00";
    // Tertiary
    public string Tertiary => "#C5FEC6";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#99D09B";
    public string OnTertiaryContainer => "#000F02";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#0D150D";
    public string SurfaceVariant => "#3A4B3A";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#0D150D";
    public string SurfaceBright => "#495348";
    public string SurfaceTint => "#DEC74C";
    // Background
    public string Background => "#0D150D";
    public string OnBackground => "#DBE5D7";
    // Outline
    public string Outline => "#E1F6DE";
    public string OutlineVariant => "#B4C8B2";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#DBE5D7";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#534800";
    // Primary Fixed
    public string PrimaryFixed => "#FCE365";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#DEC74C";
    public string OnPrimaryFixedVariant => "#151100";
    // Secondary Fixed
    public string SecondaryFixed => "#F6E388";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#D9C76F";
    public string OnSecondaryFixedVariant => "#151100";
    // Tertiary Fixed
    public string TertiaryFixed => "#B8F1B9";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#9CD49F";
    public string OnTertiaryFixedVariant => "#001504";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#192219";
    public string SurfaceContainer => "#2A3329";
    public string SurfaceContainerHigh => "#353E34";
    public string SurfaceContainerHighest => "#40493F";
}
