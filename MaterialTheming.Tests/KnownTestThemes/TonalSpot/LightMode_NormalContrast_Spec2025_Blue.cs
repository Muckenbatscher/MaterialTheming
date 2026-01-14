using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_NormalContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#44608A";
    public string OnPrimary => "#F8F8FF";
    public string PrimaryContainer => "#A6C2F2";
    public string OnPrimaryContainer => "#1F3D65";
    // Secondary
    public string Secondary => "#556071";
    public string OnSecondary => "#F8F8FF";
    public string SecondaryContainer => "#D9E3F8";
    public string OnSecondaryContainer => "#485264";
    // Tertiary
    public string Tertiary => "#655882";
    public string OnTertiary => "#FDF7FF";
    public string TertiaryContainer => "#DACAFB";
    public string OnTertiaryContainer => "#4D4169";
    // Error
    public string Error => "#A83836";
    public string OnError => "#FFF7F6";
    public string ErrorContainer => "#FA746F";
    public string OnErrorContainer => "#6E0A12";
    // Surface
    public string Surface => "#F9F9FE";
    public string SurfaceVariant => "#DFE2EC";
    public string OnSurface => "#2F333A";
    public string OnSurfaceVariant => "#5B5F68";
    public string SurfaceDim => "#D7DAE4";
    public string SurfaceBright => "#F9F9FE";
    public string SurfaceTint => "#44608A";
    // Background
    public string Background => "#F9F9FE";
    public string OnBackground => "#2F333A";
    // Outline
    public string Outline => "#777B84";
    public string OutlineVariant => "#AEB2BB";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#0C0E12";
    public string InverseOnSurface => "#9C9DA1";
    public string InversePrimary => "#A6C2F2";
    // Primary Fixed
    public string PrimaryFixed => "#A6C2F2";
    public string OnPrimaryFixed => "#03284F";
    public string PrimaryFixedDim => "#98B5E3";
    public string OnPrimaryFixedVariant => "#29466E";
    // Secondary Fixed
    public string SecondaryFixed => "#D9E3F8";
    public string OnSecondaryFixed => "#364051";
    public string SecondaryFixedDim => "#CAD5EA";
    public string OnSecondaryFixedVariant => "#525C6E";
    // Tertiary Fixed
    public string TertiaryFixed => "#DACAFB";
    public string OnTertiaryFixed => "#392E55";
    public string TertiaryFixedDim => "#CBBCED";
    public string OnTertiaryFixedVariant => "#564A73";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F2F3FA";
    public string SurfaceContainer => "#ECEDF6";
    public string SurfaceContainerHigh => "#E6E8F1";
    public string SurfaceContainerHighest => "#DFE2EC";
}
