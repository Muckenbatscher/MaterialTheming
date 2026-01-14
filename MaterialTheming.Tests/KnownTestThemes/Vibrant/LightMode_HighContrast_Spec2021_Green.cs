using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_HighContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#003411";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#005520";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#0A3322";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#2B513E";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#00332A";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#005346";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F2FCEE";
    public string SurfaceVariant => "#D9E6D5";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#B1BCAE";
    public string SurfaceBright => "#F2FCEE";
    public string SurfaceTint => "#006E2B";
    // Background
    public string Background => "#F2FCEE";
    public string OnBackground => "#151E15";
    // Outline
    public string Outline => "#242F23";
    public string OutlineVariant => "#404C3F";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2A3329";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#00E563";
    // Primary Fixed
    public string PrimaryFixed => "#005520";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#003C14";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#2B513E";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#123929";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#005346";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#003A31";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#E9F4E5";
    public string SurfaceContainer => "#DBE5D7";
    public string SurfaceContainerHigh => "#CDD7C9";
    public string SurfaceContainerHighest => "#BFC9BC";
}
