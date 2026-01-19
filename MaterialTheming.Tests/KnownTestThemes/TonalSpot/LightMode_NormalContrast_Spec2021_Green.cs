namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_NormalContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#36693D";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#B8F1B9";
    public string OnPrimaryContainer => "#1D5128";
    // Secondary
    public string Secondary => "#516350";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#D4E8D1";
    public string OnSecondaryContainer => "#3A4B3A";
    // Tertiary
    public string Tertiary => "#39656C";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#BDEAF3";
    public string OnTertiaryContainer => "#1F4D54";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#F7FBF2";
    public string SurfaceVariant => "#DDE5D9";
    public string OnSurface => "#181D18";
    public string OnSurfaceVariant => "#424940";
    public string SurfaceDim => "#D7DBD3";
    public string SurfaceBright => "#F7FBF2";
    public string SurfaceTint => "#36693D";
    // Background
    public string Background => "#F7FBF2";
    public string OnBackground => "#181D18";
    // Outline
    public string Outline => "#727970";
    public string OutlineVariant => "#C1C9BE";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2D322C";
    public string InverseOnSurface => "#EEF2E9";
    public string InversePrimary => "#9CD49F";
    // Primary Fixed
    public string PrimaryFixed => "#B8F1B9";
    public string OnPrimaryFixed => "#002108";
    public string PrimaryFixedDim => "#9CD49F";
    public string OnPrimaryFixedVariant => "#1D5128";
    // Secondary Fixed
    public string SecondaryFixed => "#D4E8D1";
    public string OnSecondaryFixed => "#0F1F11";
    public string SecondaryFixedDim => "#B8CCB5";
    public string OnSecondaryFixedVariant => "#3A4B3A";
    // Tertiary Fixed
    public string TertiaryFixed => "#BDEAF3";
    public string OnTertiaryFixed => "#001F24";
    public string TertiaryFixedDim => "#A1CED6";
    public string OnTertiaryFixedVariant => "#1F4D54";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F1F5EC";
    public string SurfaceContainer => "#EBEFE7";
    public string SurfaceContainerHigh => "#E5E9E1";
    public string SurfaceContainerHighest => "#E0E4DB";
}
