using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class LightMode_HighContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#5A003D";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#8D0662";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#4E1738";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#713456";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#5D0900";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#901A05";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F8";
    public string SurfaceVariant => "#F8DBE6";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#C7B4BB";
    public string SurfaceBright => "#FFF8F8";
    public string SurfaceTint => "#A92779";
    // Background
    public string Background => "#FFF8F8";
    public string OnBackground => "#23181D";
    // Outline
    public string Outline => "#39272F";
    public string OutlineVariant => "#58444D";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#392D32";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#FFAFD6";
    // Primary Fixed
    public string PrimaryFixed => "#8D0662";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#660046";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#713456";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#561E3F";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#901A05";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#690C00";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFECF2";
    public string SurfaceContainer => "#F2DDE4";
    public string SurfaceContainerHigh => "#E3CFD6";
    public string SurfaceContainerHighest => "#D5C2C8";
}
