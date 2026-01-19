namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class DarkMode_NormalContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#84D98E";
    public string OnPrimary => "#003913";
    public string PrimaryContainer => "#4EA25C";
    public string OnPrimaryContainer => "#000801";
    // Secondary
    public string Secondary => "#ACD0AB";
    public string OnSecondary => "#19371D";
    public string SecondaryContainer => "#2F4E32";
    public string OnSecondaryContainer => "#9BBE9B";
    // Tertiary
    public string Tertiary => "#FFB1C2";
    public string OnTertiary => "#600E2C";
    public string TertiaryContainer => "#BB5671";
    public string OnTertiaryContainer => "#140004";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#101510";
    public string SurfaceVariant => "#40493F";
    public string OnSurface => "#DFE4DB";
    public string OnSurfaceVariant => "#BFCABB";
    public string SurfaceDim => "#101510";
    public string SurfaceBright => "#363B34";
    public string SurfaceTint => "#84D98E";
    // Background
    public string Background => "#101510";
    public string OnBackground => "#DFE4DB";
    // Outline
    public string Outline => "#899487";
    public string OutlineVariant => "#40493F";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#DFE4DB";
    public string InverseOnSurface => "#2D322C";
    public string InversePrimary => "#126D2E";
    // Primary Fixed
    public string PrimaryFixed => "#9FF6A7";
    public string OnPrimaryFixed => "#002108";
    public string PrimaryFixedDim => "#84D98E";
    public string OnPrimaryFixedVariant => "#00531F";
    // Secondary Fixed
    public string SecondaryFixed => "#C8ECC6";
    public string OnSecondaryFixed => "#03210A";
    public string SecondaryFixedDim => "#ACD0AB";
    public string OnSecondaryFixedVariant => "#2F4E32";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFD9DF";
    public string OnTertiaryFixed => "#3F0018";
    public string TertiaryFixedDim => "#FFB1C2";
    public string OnTertiaryFixedVariant => "#7E2642";
    // Surface Container
    public string SurfaceContainerLowest => "#0B0F0B";
    public string SurfaceContainerLow => "#181D18";
    public string SurfaceContainer => "#1C211B";
    public string SurfaceContainerHigh => "#262B26";
    public string SurfaceContainerHighest => "#313630";
}
