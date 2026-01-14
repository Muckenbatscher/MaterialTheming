using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_NormalContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#DEC74C";
    public string OnPrimary => "#393000";
    public string PrimaryContainer => "#524600";
    public string OnPrimaryContainer => "#FCE365";
    // Secondary
    public string Secondary => "#D9C76F";
    public string OnSecondary => "#393000";
    public string SecondaryContainer => "#524600";
    public string OnSecondaryContainer => "#F6E388";
    // Tertiary
    public string Tertiary => "#9CD49F";
    public string OnTertiary => "#013913";
    public string TertiaryContainer => "#1D5128";
    public string OnTertiaryContainer => "#B8F1B9";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#0D150D";
    public string SurfaceVariant => "#3A4B3A";
    public string OnSurface => "#DBE5D7";
    public string OnSurfaceVariant => "#B8CCB5";
    public string SurfaceDim => "#0D150D";
    public string SurfaceBright => "#323C32";
    public string SurfaceTint => "#DEC74C";
    // Background
    public string Background => "#0D150D";
    public string OnBackground => "#DBE5D7";
    // Outline
    public string Outline => "#839681";
    public string OutlineVariant => "#3A4B3A";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#DBE5D7";
    public string InverseOnSurface => "#2A3329";
    public string InversePrimary => "#6D5E00";
    // Primary Fixed
    public string PrimaryFixed => "#FCE365";
    public string OnPrimaryFixed => "#211B00";
    public string PrimaryFixedDim => "#DEC74C";
    public string OnPrimaryFixedVariant => "#524600";
    // Secondary Fixed
    public string SecondaryFixed => "#F6E388";
    public string OnSecondaryFixed => "#211B00";
    public string SecondaryFixedDim => "#D9C76F";
    public string OnSecondaryFixedVariant => "#524600";
    // Tertiary Fixed
    public string TertiaryFixed => "#B8F1B9";
    public string OnTertiaryFixed => "#002108";
    public string TertiaryFixedDim => "#9CD49F";
    public string OnTertiaryFixedVariant => "#1D5128";
    // Surface Container
    public string SurfaceContainerLowest => "#081008";
    public string SurfaceContainerLow => "#151E15";
    public string SurfaceContainer => "#192219";
    public string SurfaceContainerHigh => "#232C23";
    public string SurfaceContainerHighest => "#2E372D";
}
