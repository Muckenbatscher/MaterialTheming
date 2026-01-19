namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_HighContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#002449";
    public string OnPrimary => "#C7DBFF";
    public string PrimaryContainer => "#075299";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#022A1A";
    public string OnSecondary => "#BAE4CA";
    public string SecondaryContainer => "#345A46";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#002A16";
    public string OnTertiary => "#8CEEB1";
    public string TertiaryContainer => "#005F37";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#510007";
    public string OnError => "#FFCFCB";
    public string ErrorContainer => "#9A2728";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F9F9FF";
    public string SurfaceVariant => "#D5E3FF";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#062446";
    public string SurfaceDim => "#C7DBFF";
    public string SurfaceBright => "#F9F9FF";
    public string SurfaceTint => "#002449";
    // Background
    public string Background => "#F9F9FF";
    public string OnBackground => "#000000";
    // Outline
    public string Outline => "#2B4466";
    public string OutlineVariant => "#3B5377";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#030E20";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#A3C6FF";
    // Primary Fixed
    public string PrimaryFixed => "#075299";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#004786";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#345A46";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#284E3B";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#005F37";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#00522F";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F0F3FF";
    public string SurfaceContainer => "#E7EEFF";
    public string SurfaceContainerHigh => "#DEE9FF";
    public string SurfaceContainerHighest => "#D5E3FF";
}
