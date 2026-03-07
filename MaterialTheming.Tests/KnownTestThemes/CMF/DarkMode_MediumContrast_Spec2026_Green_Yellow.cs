namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class DarkMode_MediumContrast_Spec2026_Green_Yellow : ITestThemeSecondSourceColor
{
    public string SourceColor => "#338745"; //Green
    public string SecondSourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#77CB81";
    public string OnPrimary => "#003411";
    public string PrimaryContainer => "#308443";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#9FC29E";
    public string OnSecondary => "#143219";
    public string SecondaryContainer => "#5C7C5D";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#C0BE44";
    public string OnTertiary => "#2E2E00";
    public string TertiaryContainer => "#B2B037";
    public string OnTertiaryContainer => "#222200";
    // Error
    public string Error => "#FFA089";
    public string OnError => "#591001";
    public string ErrorContainer => "#BA573F";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#081008";
    public string SurfaceVariant => "#182A1A";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#A9BEA7";
    public string SurfaceDim => "#081008";
    public string SurfaceBright => "#1E3020";
    public string SurfaceTint => "#77CB81";
    // Background
    public string Background => "#081008";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#849983";
    public string OutlineVariant => "#677B66";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#EBFFE7";
    public string InverseOnSurface => "#313B31";
    public string InversePrimary => "#006326";
    // Primary Fixed
    public string PrimaryFixed => "#308443";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#318543";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#C8ECC6";
    public string OnSecondaryFixed => "#06250D";
    public string SecondaryFixedDim => "#BADEB9";
    public string OnSecondaryFixedVariant => "#28462B";
    // Tertiary Fixed
    public string TertiaryFixed => "#B2B037";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#A4A22A";
    public string OnTertiaryFixedVariant => "#121100";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#0B160B";
    public string SurfaceContainer => "#0F1D10";
    public string SurfaceContainerHigh => "#142315";
    public string SurfaceContainerHighest => "#182A1A";
}
