namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_HighContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#003138";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#00515B";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#023040";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#284E5E";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#002F4A";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#1D4D6E";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#EEFCFF";
    public string SurfaceVariant => "#D4E6E9";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#AEBBBE";
    public string SurfaceBright => "#EEFCFF";
    public string SurfaceTint => "#006875";
    // Background
    public string Background => "#EEFCFF";
    public string OnBackground => "#111D20";
    // Outline
    public string Outline => "#1F2F32";
    public string OutlineVariant => "#3C4C4F";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#263235";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#00DAF2";
    // Primary Fixed
    public string PrimaryFixed => "#00515B";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#003940";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#284E5E";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#0C3746";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#1D4D6E";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#003654";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#E6F3F6";
    public string SurfaceContainer => "#D7E5E8";
    public string SurfaceContainerHigh => "#C9D7DA";
    public string SurfaceContainerHighest => "#BBC9CC";
}
