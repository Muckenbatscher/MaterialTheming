namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class LightMode_NormalContrast_Spec2026_Blue_Yellow : ITestThemeSecondSourceColor
{
    public string SourceColor => "#185FAA"; //Blue
    public string SecondSourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#00539B";
    public string OnPrimary => "#D6E4FF";
    public string PrimaryContainer => "#185FAA";
    public string OnPrimaryContainer => "#F6F7FF";
    // Secondary
    public string Secondary => "#4C607F";
    public string OnSecondary => "#F8F8FF";
    public string SecondaryContainer => "#C1D5F9";
    public string OnSecondaryContainer => "#364A67";
    // Tertiary
    public string Tertiary => "#636200";
    public string OnTertiary => "#FFFCBB";
    public string TertiaryContainer => "#B2B037";
    public string OnTertiaryContainer => "#2F2E00";
    // Error
    public string Error => "#9F413A";
    public string OnError => "#FFF7F6";
    public string ErrorContainer => "#FB877D";
    public string OnErrorContainer => "#570B0B";
    // Surface
    public string Surface => "#F9F9FF";
    public string SurfaceVariant => "#D8E3FA";
    public string OnSurface => "#283344";
    public string OnSurfaceVariant => "#546073";
    public string SurfaceDim => "#CFDAF1";
    public string SurfaceBright => "#F9F9FF";
    public string SurfaceTint => "#00539B";
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
    public string PrimaryFixed => "#185FAA";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#00539B";
    public string OnPrimaryFixedVariant => "#C5DAFF";
    // Secondary Fixed
    public string SecondaryFixed => "#C1D5F9";
    public string OnSecondaryFixed => "#233753";
    public string SecondaryFixedDim => "#B3C7EB";
    public string OnSecondaryFixedVariant => "#405371";
    // Tertiary Fixed
    public string TertiaryFixed => "#B2B037";
    public string OnTertiaryFixed => "#121100";
    public string TertiaryFixedDim => "#A4A22A";
    public string OnTertiaryFixedVariant => "#383700";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F0F3FF";
    public string SurfaceContainer => "#E7EEFF";
    public string SurfaceContainerHigh => "#DFE8FC";
    public string SurfaceContainerHighest => "#D8E3FA";
}
