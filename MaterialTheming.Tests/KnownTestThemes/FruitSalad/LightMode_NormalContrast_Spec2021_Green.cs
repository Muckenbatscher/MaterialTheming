namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_NormalContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#6D5E00";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#FCE365";
    public string OnPrimaryContainer => "#524600";
    // Secondary
    public string Secondary => "#6C5E10";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#F6E388";
    public string OnSecondaryContainer => "#524600";
    // Tertiary
    public string Tertiary => "#36693D";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#B8F1B9";
    public string OnTertiaryContainer => "#1D5128";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#F2FCEE";
    public string SurfaceVariant => "#D4E8D1";
    public string OnSurface => "#151E15";
    public string OnSurfaceVariant => "#3A4B3A";
    public string SurfaceDim => "#D3DDCF";
    public string SurfaceBright => "#F2FCEE";
    public string SurfaceTint => "#6D5E00";
    // Background
    public string Background => "#F2FCEE";
    public string OnBackground => "#151E15";
    // Outline
    public string Outline => "#697C68";
    public string OutlineVariant => "#B8CCB5";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2A3329";
    public string InverseOnSurface => "#E9F4E5";
    public string InversePrimary => "#DEC74C";
    // Primary Fixed
    public string PrimaryFixed => "#FCE365";
    public string OnPrimaryFixed => "#211B00";
    public string PrimaryFixedDim => "#DEC74C";
    public string OnPrimaryFixedVariant => "#524600";
    // Secondary Fixed
    public string SecondaryFixed => "#F6E388";
    public string OnSecondaryFixed => "#211B00";
    public string SecondaryFixedDim => "#D9C76F";
    public string OnSecondaryFixedVariant => "#524600";
    // Tertiary Fixed
    public string TertiaryFixed => "#B8F1B9";
    public string OnTertiaryFixed => "#002108";
    public string TertiaryFixedDim => "#9CD49F";
    public string OnTertiaryFixedVariant => "#1D5128";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#ECF7E8";
    public string SurfaceContainer => "#E7F1E2";
    public string SurfaceContainerHigh => "#E1EBDD";
    public string SurfaceContainerHighest => "#DBE5D7";
}
