using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_MediumContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FFCDF4";
    public string OnPrimary => "#480447";
    public string PrimaryContainer => "#C376BA";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFCDF4";
    public string OnSecondary => "#3F143D";
    public string SecondaryContainer => "#B77EAE";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFD2CD";
    public string OnTertiary => "#481310";
    public string TertiaryContainer => "#CC7B72";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#1E100E";
    public string SurfaceVariant => "#5D3F3C";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FED2CD";
    public string SurfaceDim => "#1E100E";
    public string SurfaceBright => "#53403E";
    public string SurfaceTint => "#FFABF3";
    // Background
    public string Background => "#1E100E";
    public string OnBackground => "#F9DCD9";
    // Outline
    public string Outline => "#D1A8A4";
    public string OutlineVariant => "#AD8783";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F9DCD9";
    public string InverseOnSurface => "#372624";
    public string InversePrimary => "#702D6C";
    // Primary Fixed
    public string PrimaryFixed => "#FFD7F5";
    public string OnPrimaryFixed => "#260026";
    public string PrimaryFixedDim => "#FFABF3";
    public string OnPrimaryFixedVariant => "#5C1A59";
    // Secondary Fixed
    public string SecondaryFixed => "#FFD7F5";
    public string OnSecondaryFixed => "#260026";
    public string SecondaryFixedDim => "#F1B3E6";
    public string OnSecondaryFixedVariant => "#53254F";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFDAD6";
    public string OnTertiaryFixed => "#2C0102";
    public string TertiaryFixedDim => "#FFB4AB";
    public string OnTertiaryFixedVariant => "#5E231E";
    // Surface Container
    public string SurfaceContainerLowest => "#100504";
    public string SurfaceContainerLow => "#291A18";
    public string SurfaceContainer => "#342422";
    public string SurfaceContainerHigh => "#402E2C";
    public string SurfaceContainerHighest => "#4C3937";
}
