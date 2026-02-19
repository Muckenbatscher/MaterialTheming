namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class DarkMode_HighContrast_Spec2026_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#C2FFC4";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#80D58A";
    public string OnPrimaryContainer => "#000801";
    // Secondary
    public string Secondary => "#D5FAD3";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#A9CCA8";
    public string OnSecondaryContainer => "#000F02";
    // Tertiary
    public string Tertiary => "#E8F0FF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#96C6FF";
    public string OnTertiaryContainer => "#000712";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#101510";
    public string SurfaceVariant => "#40493F";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#101510";
    public string SurfaceBright => "#4C514B";
    public string SurfaceTint => "#84D98E";
    // Background
    public string Background => "#101510";
    public string OnBackground => "#DFE4DB";
    // Outline
    public string Outline => "#E8F3E4";
    public string OutlineVariant => "#BBC6B8";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#DFE4DB";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#00541F";
    // Primary Fixed
    public string PrimaryFixed => "#9FF6A7";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#84D98E";
    public string OnPrimaryFixedVariant => "#001504";
    // Secondary Fixed
    public string SecondaryFixed => "#C8ECC6";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#ACD0AB";
    public string OnSecondaryFixedVariant => "#001504";
    // Tertiary Fixed
    public string TertiaryFixed => "#D1E4FF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#9ECAFF";
    public string OnTertiaryFixedVariant => "#001225";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1C211B";
    public string SurfaceContainer => "#2D322C";
    public string SurfaceContainerHigh => "#383D37";
    public string SurfaceContainerHighest => "#434842";
}
