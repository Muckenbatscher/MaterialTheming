using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_MediumContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#083F18";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#45784B";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#2A3A2A";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#60725F";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#083C43";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#48747B";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F7FBF2";
    public string SurfaceVariant => "#DDE5D9";
    public string OnSurface => "#0E120E";
    public string OnSurfaceVariant => "#313830";
    public string SurfaceDim => "#C4C8C0";
    public string SurfaceBright => "#F7FBF2";
    public string SurfaceTint => "#36693D";
    // Background
    public string Background => "#F7FBF2";
    public string OnBackground => "#181D18";
    // Outline
    public string Outline => "#4D544C";
    public string OutlineVariant => "#686F66";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2D322C";
    public string InverseOnSurface => "#EEF2E9";
    public string InversePrimary => "#9CD49F";
    // Primary Fixed
    public string PrimaryFixed => "#45784B";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#2C5F35";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#60725F";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#485947";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#48747B";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#2F5B62";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F1F5EC";
    public string SurfaceContainer => "#E5E9E1";
    public string SurfaceContainerHigh => "#DADED6";
    public string SurfaceContainerHighest => "#CFD3CB";
}
