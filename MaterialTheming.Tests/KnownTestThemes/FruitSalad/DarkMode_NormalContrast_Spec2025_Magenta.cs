using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_NormalContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#D0BCFF";
    public string OnPrimary => "#391E72";
    public string PrimaryContainer => "#50378A";
    public string OnPrimaryContainer => "#E9DDFF";
    // Secondary
    public string Secondary => "#D0BCFE";
    public string OnSecondary => "#36265D";
    public string SecondaryContainer => "#4D3D75";
    public string OnSecondaryContainer => "#E9DDFF";
    // Tertiary
    public string Tertiary => "#FCB0D5";
    public string OnTertiary => "#521D3B";
    public string TertiaryContainer => "#6C3353";
    public string OnTertiaryContainer => "#FFD8E8";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#1C1016";
    public string SurfaceVariant => "#58404B";
    public string OnSurface => "#F4DDE5";
    public string OnSurfaceVariant => "#E0BDCC";
    public string SurfaceDim => "#1C1016";
    public string SurfaceBright => "#44353C";
    public string SurfaceTint => "#D0BCFF";
    // Background
    public string Background => "#1C1016";
    public string OnBackground => "#F4DDE5";
    // Outline
    public string Outline => "#A78896";
    public string OutlineVariant => "#58404B";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F4DDE5";
    public string InverseOnSurface => "#3B2C33";
    public string InversePrimary => "#684FA4";
    // Primary Fixed
    public string PrimaryFixed => "#E9DDFF";
    public string OnPrimaryFixed => "#23005C";
    public string PrimaryFixedDim => "#D0BCFF";
    public string OnPrimaryFixedVariant => "#50378A";
    // Secondary Fixed
    public string SecondaryFixed => "#E9DDFF";
    public string OnSecondaryFixed => "#210F47";
    public string SecondaryFixedDim => "#D0BCFE";
    public string OnSecondaryFixedVariant => "#4D3D75";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFD8E8";
    public string OnTertiaryFixed => "#380726";
    public string TertiaryFixedDim => "#FCB0D5";
    public string OnTertiaryFixedVariant => "#6C3353";
    // Surface Container
    public string SurfaceContainerLowest => "#160B10";
    public string SurfaceContainerLow => "#24181E";
    public string SurfaceContainer => "#291C22";
    public string SurfaceContainerHigh => "#34262C";
    public string SurfaceContainerHighest => "#3F3137";
}
