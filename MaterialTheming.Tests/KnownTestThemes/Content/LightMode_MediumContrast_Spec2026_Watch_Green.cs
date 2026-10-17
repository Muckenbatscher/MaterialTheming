namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class LightMode_MediumContrast_Spec2026_Watch_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Content;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFFFFA";
    public string OnPrimary => "#002D0D";
    public string PrimaryContainer => "#439652";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFFFA";
    public string OnSecondary => "#06250D";
    public string SecondaryContainer => "#6D8E6D";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFEFF";
    public string OnTertiary => "#292F00";
    public string TertiaryContainer => "#D1E068";
    public string OnTertiaryContainer => "#3D4500";
    // Error
    public string Error => "#FFBFB0";
    public string OnError => "#390600";
    public string ErrorContainer => "#CF674E";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#192A1A";
    public string OnSurface => "#FFFFFA";
    public string OnSurfaceVariant => "#BFD4BC";
    public string SurfaceDim => "#031105";
    public string SurfaceBright => "#1F3020";
    public string SurfaceTint => "#FFFFFA";
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
    public string InverseOnSurface => "#2B3C2B";
    public string InversePrimary => "#004217";
    // Primary Fixed
    public string PrimaryFixed => "#A8FFB0";
    public string OnPrimaryFixed => "#002D0D";
    public string PrimaryFixedDim => "#9AF0A2";
    public string OnPrimaryFixedVariant => "#00501E";
    // Secondary Fixed
    public string SecondaryFixed => "#C8ECC6";
    public string OnSecondaryFixed => "#06250D";
    public string SecondaryFixedDim => "#BADEB9";
    public string OnSecondaryFixedVariant => "#28462B";
    // Tertiary Fixed
    public string TertiaryFixed => "#EDFD82";
    public string OnTertiaryFixed => "#292F00";
    public string TertiaryFixedDim => "#DFEF75";
    public string OnTertiaryFixedVariant => "#434B00";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#192A1A";
    public string SurfaceContainer => "#233524";
    public string SurfaceContainerHigh => "#2E402E";
    public string SurfaceContainerHighest => "#192A1A";
}
