using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_NormalContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FFB779";
    public string OnPrimary => "#4C2700";
    public string PrimaryContainer => "#6C3A00";
    public string OnPrimaryContainer => "#FFDCC1";
    // Secondary
    public string Secondary => "#FFB779";
    public string OnSecondary => "#4C2700";
    public string SecondaryContainer => "#6B3B04";
    public string OnSecondaryContainer => "#FFDCC1";
    // Tertiary
    public string Tertiary => "#CDCA75";
    public string OnTertiary => "#333200";
    public string TertiaryContainer => "#4A4900";
    public string OnTertiaryContainer => "#E9E78E";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#141407";
    public string SurfaceVariant => "#49482D";
    public string OnSurface => "#E6E3CD";
    public string OnSurfaceVariant => "#CBC8A4";
    public string SurfaceDim => "#141407";
    public string SurfaceBright => "#3B3A2A";
    public string SurfaceTint => "#FFB779";
    // Background
    public string Background => "#141407";
    public string OnBackground => "#E6E3CD";
    // Outline
    public string Outline => "#949271";
    public string OutlineVariant => "#49482D";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E6E3CD";
    public string InverseOnSurface => "#323122";
    public string InversePrimary => "#8E4E00";
    // Primary Fixed
    public string PrimaryFixed => "#FFDCC1";
    public string OnPrimaryFixed => "#2E1500";
    public string PrimaryFixedDim => "#FFB779";
    public string OnPrimaryFixedVariant => "#6C3A00";
    // Secondary Fixed
    public string SecondaryFixed => "#FFDCC1";
    public string OnSecondaryFixed => "#2E1500";
    public string SecondaryFixedDim => "#FFB779";
    public string OnSecondaryFixedVariant => "#6B3B04";
    // Tertiary Fixed
    public string TertiaryFixed => "#E9E78E";
    public string OnTertiaryFixed => "#1D1D00";
    public string TertiaryFixedDim => "#CDCA75";
    public string OnTertiaryFixedVariant => "#4A4900";
    // Surface Container
    public string SurfaceContainerLowest => "#0F0F04";
    public string SurfaceContainerLow => "#1D1C0E";
    public string SurfaceContainer => "#212012";
    public string SurfaceContainerHigh => "#2B2B1C";
    public string SurfaceContainerHighest => "#363526";
}
