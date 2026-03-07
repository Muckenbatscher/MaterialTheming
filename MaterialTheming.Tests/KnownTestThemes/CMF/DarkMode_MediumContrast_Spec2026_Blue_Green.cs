namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class DarkMode_MediumContrast_Spec2026_Blue_Green : ITestThemeSecondSourceColor
{
    public string SourceColor => "#185FAA"; //Blue
    public string SecondSourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#8DBBFF";
    public string OnPrimary => "#002C58";
    public string PrimaryContainer => "#3876C2";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#A6BADC";
    public string OnSecondary => "#182D49";
    public string SecondaryContainer => "#627595";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#77CB81";
    public string OnTertiary => "#003411";
    public string TertiaryContainer => "#308443";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#FF9F96";
    public string OnError => "#5A0D0D";
    public string ErrorContainer => "#BB554D";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#090E17";
    public string SurfaceVariant => "#1B2637";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#AEB9CF";
    public string SurfaceDim => "#090E17";
    public string SurfaceBright => "#212D3E";
    public string SurfaceTint => "#8DBBFF";
    // Background
    public string Background => "#090E17";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#8994A9";
    public string OutlineVariant => "#6B768A";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F9F9FF";
    public string InverseOnSurface => "#333842";
    public string InversePrimary => "#0055A0";
    // Primary Fixed
    public string PrimaryFixed => "#3876C2";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#3976C3";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#C1D5F9";
    public string OnSecondaryFixed => "#001128";
    public string SecondaryFixedDim => "#B3C7EB";
    public string OnSecondaryFixedVariant => "#233753";
    // Tertiary Fixed
    public string TertiaryFixed => "#308443";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#318543";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#0C141F";
    public string SurfaceContainer => "#111A27";
    public string SurfaceContainerHigh => "#17202E";
    public string SurfaceContainerHighest => "#1B2637";
}
