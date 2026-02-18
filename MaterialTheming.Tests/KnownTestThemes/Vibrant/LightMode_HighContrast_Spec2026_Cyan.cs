namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_HighContrast_Spec2026_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#002429";
    public string OnPrimary => "#46E8FF";
    public string PrimaryContainer => "#005762";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#00232C";
    public string OnSecondary => "#82E2FF";
    public string SecondaryContainer => "#005669";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#001F42";
    public string OnTertiary => "#BED6FF";
    public string TertiaryContainer => "#004F96";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#480005";
    public string OnError => "#FFC7C3";
    public string ErrorContainer => "#A0071A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#EAF9FF";
    public string SurfaceVariant => "#A0E7FF";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#00232C";
    public string SurfaceDim => "#8EE0FA";
    public string SurfaceBright => "#EAF9FF";
    public string SurfaceTint => "#002429";
    // Background
    public string Background => "#EAF9FF";
    public string OnBackground => "#000000";
    // Outline
    public string Outline => "#054654";
    public string OutlineVariant => "#1E5564";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#001016";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#00E3FC";
    // Primary Fixed
    public string PrimaryFixed => "#005762";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#004B54";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#005669";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#004A5A";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#004F96";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#004381";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#DBF5FF";
    public string SurfaceContainer => "#C3EFFF";
    public string SurfaceContainerHigh => "#B2EBFF";
    public string SurfaceContainerHighest => "#A0E7FF";
}
