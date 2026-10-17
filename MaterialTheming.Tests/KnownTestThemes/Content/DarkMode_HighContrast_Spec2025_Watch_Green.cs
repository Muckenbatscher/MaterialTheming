namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class DarkMode_HighContrast_Spec2025_Watch_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Content;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFFFFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#64B76F";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFFFF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#8CAE8C";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFFFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#D1E068";
    public string OnTertiaryContainer => "#1F2400";
    // Error
    public string Error => "#FFBFB0";
    public string OnError => "#000000";
    public string ErrorContainer => "#F7866B";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#192A1A";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFA";
    public string SurfaceDim => "#031105";
    public string SurfaceBright => "#1F3020";
    public string SurfaceTint => "#FFFFFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#BFD4BC";
    public string OutlineVariant => "#97AB95";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#EBFFE7";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#000000";
    // Primary Fixed
    public string PrimaryFixed => "#A8FFB0";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#9AF0A2";
    public string OnPrimaryFixedVariant => "#002D0D";
    // Secondary Fixed
    public string SecondaryFixed => "#C8ECC6";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#BADEB9";
    public string OnSecondaryFixedVariant => "#06250D";
    // Tertiary Fixed
    public string TertiaryFixed => "#EDFD82";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#DFEF75";
    public string OnTertiaryFixedVariant => "#292F00";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#192A1A";
    public string SurfaceContainer => "#233524";
    public string SurfaceContainerHigh => "#2E402E";
    public string SurfaceContainerHighest => "#192A1A";
}
