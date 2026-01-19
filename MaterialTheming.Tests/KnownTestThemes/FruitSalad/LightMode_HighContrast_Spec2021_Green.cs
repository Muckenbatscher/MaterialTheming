namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_HighContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#342C00";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#554900";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#342C00";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#554900";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#003411";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#20532A";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F2FCEE";
    public string SurfaceVariant => "#D4E8D1";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#B1BCAE";
    public string SurfaceBright => "#F2FCEE";
    public string SurfaceTint => "#6D5E00";
    // Background
    public string Background => "#F2FCEE";
    public string OnBackground => "#151E15";
    // Outline
    public string Outline => "#203020";
    public string OutlineVariant => "#3C4D3C";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2A3329";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#DEC74C";
    // Primary Fixed
    public string PrimaryFixed => "#554900";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#3B3200";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#554900";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#3B3200";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#20532A";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#033B15";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#E9F4E5";
    public string SurfaceContainer => "#DBE5D7";
    public string SurfaceContainerHigh => "#CDD7C9";
    public string SurfaceContainerHighest => "#BFC9BC";
}
