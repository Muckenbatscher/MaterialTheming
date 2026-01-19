namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_HighContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#003411";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#20532A";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#203020";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#3C4D3C";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#003138";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#224F56";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F7FBF2";
    public string SurfaceVariant => "#DDE5D9";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#B6BAB2";
    public string SurfaceBright => "#F7FBF2";
    public string SurfaceTint => "#36693D";
    // Background
    public string Background => "#F7FBF2";
    public string OnBackground => "#181D18";
    // Outline
    public string Outline => "#272E26";
    public string OutlineVariant => "#444B43";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2D322C";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#9CD49F";
    // Primary Fixed
    public string PrimaryFixed => "#20532A";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#033B15";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#3C4D3C";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#263727";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#224F56";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#03383F";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#EEF2E9";
    public string SurfaceContainer => "#E0E4DB";
    public string SurfaceContainerHigh => "#D2D6CD";
    public string SurfaceContainerHighest => "#C4C8C0";
}
