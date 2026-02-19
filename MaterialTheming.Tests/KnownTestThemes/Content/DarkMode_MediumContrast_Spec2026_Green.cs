namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class DarkMode_MediumContrast_Spec2026_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#99F0A2";
    public string OnPrimary => "#002D0D";
    public string PrimaryContainer => "#4EA25C";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#C2E6C0";
    public string OnSecondary => "#0D2B13";
    public string SecondaryContainer => "#789978";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#C6DEFF";
    public string OnTertiary => "#002746";
    public string TertiaryContainer => "#4C95DD";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#101510";
    public string SurfaceVariant => "#40493F";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#D5DFD1";
    public string SurfaceDim => "#101510";
    public string SurfaceBright => "#41463F";
    public string SurfaceTint => "#84D98E";
    // Background
    public string Background => "#101510";
    public string OnBackground => "#DFE4DB";
    // Outline
    public string Outline => "#AAB5A7";
    public string OutlineVariant => "#899386";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#DFE4DB";
    public string InverseOnSurface => "#262B26";
    public string InversePrimary => "#00541F";
    // Primary Fixed
    public string PrimaryFixed => "#9FF6A7";
    public string OnPrimaryFixed => "#001504";
    public string PrimaryFixedDim => "#84D98E";
    public string OnPrimaryFixedVariant => "#004016";
    // Secondary Fixed
    public string SecondaryFixed => "#C8ECC6";
    public string OnSecondaryFixed => "#001504";
    public string SecondaryFixedDim => "#ACD0AB";
    public string OnSecondaryFixedVariant => "#1F3D22";
    // Tertiary Fixed
    public string TertiaryFixed => "#D1E4FF";
    public string OnTertiaryFixed => "#001225";
    public string TertiaryFixedDim => "#9ECAFF";
    public string OnTertiaryFixedVariant => "#003861";
    // Surface Container
    public string SurfaceContainerLowest => "#050805";
    public string SurfaceContainerLow => "#1A1F19";
    public string SurfaceContainer => "#242924";
    public string SurfaceContainerHigh => "#2F342E";
    public string SurfaceContainerHighest => "#3A3F39";
}
