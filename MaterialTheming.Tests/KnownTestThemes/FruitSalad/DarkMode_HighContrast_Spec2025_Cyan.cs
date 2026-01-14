using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_HighContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#BCFFD4";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#72D69E";
    public string OnPrimaryContainer => "#000E06";
    // Secondary
    public string Secondary => "#BCFFD4";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#8ED1A8";
    public string OnSecondaryContainer => "#000E06";
    // Tertiary
    public string Tertiary => "#CEF7FF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#7ECFDD";
    public string OnTertiaryContainer => "#000E10";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#091517";
    public string SurfaceVariant => "#334B4F";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#091517";
    public string SurfaceBright => "#465255";
    public string SurfaceTint => "#76DAA2";
    // Background
    public string Background => "#091517";
    public string OnBackground => "#D7E5E8";
    // Outline
    public string Outline => "#DAF5FA";
    public string OutlineVariant => "#ADC7CC";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#D7E5E8";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#005332";
    // Primary Fixed
    public string PrimaryFixed => "#92F7BC";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#76DAA2";
    public string OnPrimaryFixedVariant => "#001509";
    // Secondary Fixed
    public string SecondaryFixed => "#ADF2C6";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#92D5AB";
    public string OnSecondaryFixedVariant => "#001509";
    // Tertiary Fixed
    public string TertiaryFixed => "#9EEFFE";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#82D3E1";
    public string OnTertiaryFixedVariant => "#001417";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#152224";
    public string SurfaceContainer => "#263235";
    public string SurfaceContainerHigh => "#313D40";
    public string SurfaceContainerHighest => "#3C494B";
}
