namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_MediumContrast_Spec2026_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#3F3600";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#7D6D00";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#3F3600";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#7B6D1F";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#083F18";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#45784B";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F2FCEE";
    public string SurfaceVariant => "#D4E8D1";
    public string OnSurface => "#0B130B";
    public string OnSurfaceVariant => "#2A3A2A";
    public string SurfaceDim => "#BFC9BC";
    public string SurfaceBright => "#F2FCEE";
    public string SurfaceTint => "#6D5E00";
    // Background
    public string Background => "#F2FCEE";
    public string OnBackground => "#151E15";
    // Outline
    public string Outline => "#455745";
    public string OutlineVariant => "#60725F";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2A3329";
    public string InverseOnSurface => "#E9F4E5";
    public string InversePrimary => "#DEC74C";
    // Primary Fixed
    public string PrimaryFixed => "#7D6D00";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#625400";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#7B6D1F";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#625404";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#45784B";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#2C5F35";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#ECF7E8";
    public string SurfaceContainer => "#E1EBDD";
    public string SurfaceContainerHigh => "#D6E0D2";
    public string SurfaceContainerHighest => "#CAD5C7";
}
