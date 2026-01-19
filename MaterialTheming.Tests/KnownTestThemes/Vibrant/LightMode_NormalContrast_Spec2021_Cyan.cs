namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_NormalContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#006875";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#9AF0FF";
    public string OnPrimaryContainer => "#004F58";
    // Secondary
    public string Secondary => "#3E6374";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#C2E8FC";
    public string OnSecondaryContainer => "#254B5B";
    // Tertiary
    public string Tertiary => "#366285";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#CCE5FF";
    public string OnTertiaryContainer => "#1A4A6C";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#EEFCFF";
    public string SurfaceVariant => "#D4E6E9";
    public string OnSurface => "#111D20";
    public string OnSurfaceVariant => "#39494D";
    public string SurfaceDim => "#CFDCDF";
    public string SurfaceBright => "#EEFCFF";
    public string SurfaceTint => "#006875";
    // Background
    public string Background => "#EEFCFF";
    public string OnBackground => "#111D20";
    // Outline
    public string Outline => "#697A7D";
    public string OutlineVariant => "#B8CACD";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#263235";
    public string InverseOnSurface => "#E6F3F6";
    public string InversePrimary => "#00DAF2";
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
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#E9F6F9";
    public string SurfaceContainer => "#E3F0F3";
    public string SurfaceContainerHigh => "#DDEBED";
    public string SurfaceContainerHighest => "#D7E5E8";
}
