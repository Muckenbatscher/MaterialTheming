namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class LightMode_HighContrast_Spec2025_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#003411";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#005520";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#143219";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#325034";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#002E51";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#004B81";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F6FBF2";
    public string SurfaceVariant => "#DBE6D7";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#B5BAB2";
    public string SurfaceBright => "#F6FBF2";
    public string SurfaceTint => "#126D2E";
    // Background
    public string Background => "#F6FBF2";
    public string OnBackground => "#181D18";
    // Outline
    public string Outline => "#252F25";
    public string OutlineVariant => "#424C41";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2D322C";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#84D98E";
    // Primary Fixed
    public string PrimaryFixed => "#005520";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#003C14";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#325034";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#1B391F";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#004B81";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#00345C";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#EEF2E9";
    public string SurfaceContainer => "#DFE4DB";
    public string SurfaceContainerHigh => "#D1D6CD";
    public string SurfaceContainerHighest => "#C3C8BF";
}
