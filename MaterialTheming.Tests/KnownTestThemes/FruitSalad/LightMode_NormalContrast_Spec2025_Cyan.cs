namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_NormalContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#006D43";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#92F7BC";
    public string OnPrimaryContainer => "#005231";
    // Secondary
    public string Secondary => "#286A48";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#ADF2C6";
    public string OnSecondaryContainer => "#065232";
    // Tertiary
    public string Tertiary => "#006875";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#9EEFFE";
    public string OnTertiaryContainer => "#004F58";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#EEFCFF";
    public string SurfaceVariant => "#CDE7EC";
    public string OnSurface => "#111D20";
    public string OnSurfaceVariant => "#334B4F";
    public string SurfaceDim => "#CFDCDF";
    public string SurfaceBright => "#EEFCFF";
    public string SurfaceTint => "#006D43";
    // Background
    public string Background => "#EEFCFF";
    public string OnBackground => "#111D20";
    // Outline
    public string Outline => "#637B80";
    public string OutlineVariant => "#B1CBD0";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#263235";
    public string InverseOnSurface => "#E6F3F6";
    public string InversePrimary => "#76DAA2";
    // Primary Fixed
    public string PrimaryFixed => "#92F7BC";
    public string OnPrimaryFixed => "#002111";
    public string PrimaryFixedDim => "#76DAA2";
    public string OnPrimaryFixedVariant => "#005231";
    // Secondary Fixed
    public string SecondaryFixed => "#ADF2C6";
    public string OnSecondaryFixed => "#002111";
    public string SecondaryFixedDim => "#92D5AB";
    public string OnSecondaryFixedVariant => "#065232";
    // Tertiary Fixed
    public string TertiaryFixed => "#9EEFFE";
    public string OnTertiaryFixed => "#001F24";
    public string TertiaryFixedDim => "#82D3E1";
    public string OnTertiaryFixedVariant => "#004F58";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#E9F6F9";
    public string SurfaceContainer => "#E3F0F3";
    public string SurfaceContainerHigh => "#DDEBED";
    public string SurfaceContainerHighest => "#D7E5E8";
}
