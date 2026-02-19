namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class DarkMode_HighContrast_Spec2026_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#A2F9AA";
    public string OnPrimary => "#003411";
    public string PrimaryContainer => "#62B56E";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#CBEFC9";
    public string OnSecondary => "#143219";
    public string SecondaryContainer => "#8AAC8A";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#B8F4BA";
    public string OnTertiary => "#003411";
    public string TertiaryContainer => "#78B17C";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFDEDB";
    public string OnError => "#5A0D0E";
    public string ErrorContainer => "#F5827A";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#081008";
    public string SurfaceVariant => "#182A1A";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#D6EBD2";
    public string SurfaceDim => "#081008";
    public string SurfaceBright => "#1E3020";
    public string SurfaceTint => "#A2F9AA";
    // Background
    public string Background => "#081008";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#A9BEA7";
    public string OutlineVariant => "#94A992";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#EBFFE7";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#004217";
    // Primary Fixed
    public string PrimaryFixed => "#62B56E";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#62B56E";
    public string OnPrimaryFixedVariant => "#000000";
    // Secondary Fixed
    public string SecondaryFixed => "#C8ECC6";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#BADEB9";
    public string OnSecondaryFixedVariant => "#06250D";
    // Tertiary Fixed
    public string TertiaryFixed => "#78B17C";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#78B17C";
    public string OnTertiaryFixedVariant => "#000000";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#0B160B";
    public string SurfaceContainer => "#0F1D10";
    public string SurfaceContainerHigh => "#142315";
    public string SurfaceContainerHighest => "#182A1A";
}
