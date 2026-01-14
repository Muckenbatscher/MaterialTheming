using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_NormalContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#00DAF2";
    public string OnPrimary => "#00363D";
    public string PrimaryContainer => "#004F58";
    public string OnPrimaryContainer => "#9AF0FF";
    // Secondary
    public string Secondary => "#A6CCDF";
    public string OnSecondary => "#093544";
    public string SecondaryContainer => "#254B5B";
    public string OnSecondaryContainer => "#C2E8FC";
    // Tertiary
    public string Tertiary => "#A0CBF3";
    public string OnTertiary => "#003351";
    public string TertiaryContainer => "#1A4A6C";
    public string OnTertiaryContainer => "#CCE5FF";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#091517";
    public string SurfaceVariant => "#39494D";
    public string OnSurface => "#D7E5E8";
    public string OnSurfaceVariant => "#B8CACD";
    public string SurfaceDim => "#091517";
    public string SurfaceBright => "#2F3B3E";
    public string SurfaceTint => "#00DAF2";
    // Background
    public string Background => "#091517";
    public string OnBackground => "#D7E5E8";
    // Outline
    public string Outline => "#839497";
    public string OutlineVariant => "#39494D";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#D7E5E8";
    public string InverseOnSurface => "#263235";
    public string InversePrimary => "#006875";
    // Primary Fixed
    public string PrimaryFixed => "#9AF0FF";
    public string OnPrimaryFixed => "#001F24";
    public string PrimaryFixedDim => "#00DAF2";
    public string OnPrimaryFixedVariant => "#004F58";
    // Secondary Fixed
    public string SecondaryFixed => "#C2E8FC";
    public string OnSecondaryFixed => "#001F2A";
    public string SecondaryFixedDim => "#A6CCDF";
    public string OnSecondaryFixedVariant => "#254B5B";
    // Tertiary Fixed
    public string TertiaryFixed => "#CCE5FF";
    public string OnTertiaryFixed => "#001E31";
    public string TertiaryFixedDim => "#A0CBF3";
    public string OnTertiaryFixedVariant => "#1A4A6C";
    // Surface Container
    public string SurfaceContainerLowest => "#051012";
    public string SurfaceContainerLow => "#111D20";
    public string SurfaceContainer => "#152224";
    public string SurfaceContainerHigh => "#202C2E";
    public string SurfaceContainerHighest => "#2B3739";
}
