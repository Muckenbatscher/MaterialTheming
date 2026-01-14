using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class LightMode_NormalContrast_Spec2025_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#0D6A2C";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#308443";
    public string OnPrimaryContainer => "#F7FFF2";
    // Secondary
    public string Secondary => "#466648";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#C8ECC6";
    public string OnSecondaryContainer => "#4C6C4E";
    // Tertiary
    public string Tertiary => "#005F9F";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#2678BF";
    public string OnTertiaryContainer => "#FDFCFF";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#F6FBF2";
    public string SurfaceVariant => "#DBE6D7";
    public string OnSurface => "#181D18";
    public string OnSurfaceVariant => "#40493F";
    public string SurfaceDim => "#D7DBD3";
    public string SurfaceBright => "#F6FBF2";
    public string SurfaceTint => "#126D2E";
    // Background
    public string Background => "#F6FBF2";
    public string OnBackground => "#181D18";
    // Outline
    public string Outline => "#707A6E";
    public string OutlineVariant => "#BFCABB";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2D322C";
    public string InverseOnSurface => "#EEF2E9";
    public string InversePrimary => "#84D98E";
    // Primary Fixed
    public string PrimaryFixed => "#9FF6A7";
    public string OnPrimaryFixed => "#002108";
    public string PrimaryFixedDim => "#84D98E";
    public string OnPrimaryFixedVariant => "#00531F";
    // Secondary Fixed
    public string SecondaryFixed => "#C8ECC6";
    public string OnSecondaryFixed => "#03210A";
    public string SecondaryFixedDim => "#ACD0AB";
    public string OnSecondaryFixedVariant => "#2F4E32";
    // Tertiary Fixed
    public string TertiaryFixed => "#D1E4FF";
    public string OnTertiaryFixed => "#001D36";
    public string TertiaryFixedDim => "#9ECAFF";
    public string OnTertiaryFixedVariant => "#00497D";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F1F5EC";
    public string SurfaceContainer => "#EBEFE6";
    public string SurfaceContainerHigh => "#E5EAE1";
    public string SurfaceContainerHighest => "#DFE4DB";
}
