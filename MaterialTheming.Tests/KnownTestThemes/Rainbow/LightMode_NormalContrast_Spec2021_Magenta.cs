using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class LightMode_NormalContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#944170";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#FFD8E8";
    public string OnPrimaryContainer => "#772957";
    // Secondary
    public string Secondary => "#725763";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#FDD9E8";
    public string OnSecondaryContainer => "#58404B";
    // Tertiary
    public string Tertiary => "#7F543A";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#FFDBC8";
    public string OnTertiaryContainer => "#643D25";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#F9F9F9";
    public string SurfaceVariant => "#E2E2E2";
    public string OnSurface => "#1B1B1B";
    public string OnSurfaceVariant => "#474747";
    public string SurfaceDim => "#DADADA";
    public string SurfaceBright => "#F9F9F9";
    public string SurfaceTint => "#944170";
    // Background
    public string Background => "#F9F9F9";
    public string OnBackground => "#1B1B1B";
    // Outline
    public string Outline => "#777777";
    public string OutlineVariant => "#C6C6C6";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#303030";
    public string InverseOnSurface => "#F1F1F1";
    public string InversePrimary => "#FFAFD6";
    // Primary Fixed
    public string PrimaryFixed => "#FFD8E8";
    public string OnPrimaryFixed => "#3C0028";
    public string PrimaryFixedDim => "#FFAFD6";
    public string OnPrimaryFixedVariant => "#772957";
    // Secondary Fixed
    public string SecondaryFixed => "#FDD9E8";
    public string OnSecondaryFixed => "#291520";
    public string SecondaryFixedDim => "#E0BDCC";
    public string OnSecondaryFixedVariant => "#58404B";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFDBC8";
    public string OnTertiaryFixed => "#311302";
    public string TertiaryFixedDim => "#F3BB9A";
    public string OnTertiaryFixedVariant => "#643D25";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F3F3F3";
    public string SurfaceContainer => "#EEEEEE";
    public string SurfaceContainerHigh => "#E8E8E8";
    public string SurfaceContainerHighest => "#E2E2E2";
}
