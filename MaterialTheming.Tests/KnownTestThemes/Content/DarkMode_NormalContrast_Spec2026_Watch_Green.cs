namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class DarkMode_NormalContrast_Spec2026_Watch_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Content;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#A8FFB0";
    public string OnPrimary => "#00501E";
    public string PrimaryContainer => "#00531F";
    public string OnPrimaryContainer => "#9DF4A5";
    // Secondary
    public string Secondary => "#C8ECC6";
    public string OnSecondary => "#28462B";
    public string SecondaryContainer => "#2F4E32";
    public string OnSecondaryContainer => "#C6EAC4";
    // Tertiary
    public string Tertiary => "#EDFD82";
    public string OnTertiary => "#464E00";
    public string TertiaryContainer => "#D1E068";
    public string OnTertiaryContainer => "#3D4500";
    // Error
    public string Error => "#FFBFB0";
    public string OnError => "#3B0600";
    public string ErrorContainer => "#7E2B17";
    public string OnErrorContainer => "#FFD7CE";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#192A1A";
    public string OnSurface => "#D9EED5";
    public string OnSurfaceVariant => "#BFD4BC";
    public string SurfaceDim => "#031105";
    public string SurfaceBright => "#1F3020";
    public string SurfaceTint => "#A8FFB0";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#97AB95";
    public string OutlineVariant => "#778B76";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#EBFFE7";
    public string InverseOnSurface => "#475A47";
    public string InversePrimary => "#006326";
    // Primary Fixed
    public string PrimaryFixed => "#A8FFB0";
    public string OnPrimaryFixed => "#00501E";
    public string PrimaryFixedDim => "#9AF0A2";
    public string OnPrimaryFixedVariant => "#00531F";
    // Secondary Fixed
    public string SecondaryFixed => "#C8ECC6";
    public string OnSecondaryFixed => "#28462B";
    public string SecondaryFixedDim => "#BADEB9";
    public string OnSecondaryFixedVariant => "#2F4E32";
    // Tertiary Fixed
    public string TertiaryFixed => "#EDFD82";
    public string OnTertiaryFixed => "#464E00";
    public string TertiaryFixedDim => "#DFEF75";
    public string OnTertiaryFixedVariant => "#434B00";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#192A1A";
    public string SurfaceContainer => "#233524";
    public string SurfaceContainerHigh => "#2E402E";
    public string SurfaceContainerHighest => "#192A1A";
}
