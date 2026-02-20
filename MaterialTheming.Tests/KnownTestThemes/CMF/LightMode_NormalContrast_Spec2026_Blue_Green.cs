namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class LightMode_NormalContrast_Spec2026_Blue_Green : ITestThemeSecondSourceColor
{
    public string SourceColor => "#185FAA"; //Blue
    public string SecondSourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#185FAA";
    public string OnPrimary => "#F6F7FF";
    public string PrimaryContainer => "#2B6CB7";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#4C607F";
    public string OnSecondary => "#F8F8FF";
    public string SecondaryContainer => "#C1D5F9";
    public string OnSecondaryContainer => "#364A67";
    // Tertiary
    public string Tertiary => "#136E2F";
    public string OnTertiary => "#E9FFE5";
    public string TertiaryContainer => "#308443";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#9F403C";
    public string OnError => "#FFF7F6";
    public string ErrorContainer => "#FB877F";
    public string OnErrorContainer => "#570B0D";
    // Surface
    public string Surface => "#F9F9FF";
    public string SurfaceVariant => "#D8E3FA";
    public string OnSurface => "#283344";
    public string OnSurfaceVariant => "#546073";
    public string SurfaceDim => "#CFDAF1";
    public string SurfaceBright => "#F9F9FF";
    public string SurfaceTint => "#185FAA";
    // Background
    public string Background => "#F9F9FF";
    public string OnBackground => "#283344";
    // Outline
    public string Outline => "#707B8F";
    public string OutlineVariant => "#A7B2C8";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#040E1E";
    public string InverseOnSurface => "#989DA8";
    public string InversePrimary => "#6CA5F5";
    // Primary Fixed
    public string PrimaryFixed => "#2B6CB7";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#185FAA";
    public string OnPrimaryFixedVariant => "#C5DAFF";
    // Secondary Fixed
    public string SecondaryFixed => "#C1D5F9";
    public string OnSecondaryFixed => "#233753";
    public string SecondaryFixedDim => "#B3C7EB";
    public string OnSecondaryFixedVariant => "#405371";
    // Tertiary Fixed
    public string TertiaryFixed => "#308443";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#217737";
    public string OnTertiaryFixedVariant => "#A5FCAD";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F0F3FF";
    public string SurfaceContainer => "#E7EEFF";
    public string SurfaceContainerHigh => "#DFE8FC";
    public string SurfaceContainerHighest => "#D8E3FA";
}
