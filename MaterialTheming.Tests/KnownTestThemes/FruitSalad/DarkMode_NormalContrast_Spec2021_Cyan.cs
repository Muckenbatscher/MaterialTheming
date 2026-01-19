namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_NormalContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#76DAA2";
    public string OnPrimary => "#003920";
    public string PrimaryContainer => "#005231";
    public string OnPrimaryContainer => "#92F7BC";
    // Secondary
    public string Secondary => "#92D5AB";
    public string OnSecondary => "#003920";
    public string SecondaryContainer => "#065232";
    public string OnSecondaryContainer => "#ADF2C6";
    // Tertiary
    public string Tertiary => "#82D3E1";
    public string OnTertiary => "#00363D";
    public string TertiaryContainer => "#004F58";
    public string OnTertiaryContainer => "#9EEFFE";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#091517";
    public string SurfaceVariant => "#334B4F";
    public string OnSurface => "#D7E5E8";
    public string OnSurfaceVariant => "#B1CBD0";
    public string SurfaceDim => "#091517";
    public string SurfaceBright => "#2F3B3E";
    public string SurfaceTint => "#76DAA2";
    // Background
    public string Background => "#091517";
    public string OnBackground => "#D7E5E8";
    // Outline
    public string Outline => "#7C959A";
    public string OutlineVariant => "#334B4F";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#D7E5E8";
    public string InverseOnSurface => "#263235";
    public string InversePrimary => "#006D43";
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
    public string SurfaceContainerLowest => "#051012";
    public string SurfaceContainerLow => "#111D20";
    public string SurfaceContainer => "#152224";
    public string SurfaceContainerHigh => "#202C2E";
    public string SurfaceContainerHighest => "#2B3739";
}
