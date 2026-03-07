namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class LightMode_HighContrast_Spec2026_Blue_Yellow : ITestThemeSecondSourceColor
{
    public string SourceColor => "#185FAA"; //Blue
    public string SecondSourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#002449";
    public string OnPrimary => "#C7DBFF";
    public string PrimaryContainer => "#00529B";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#0F2440";
    public string OnSecondary => "#C7DBFF";
    public string SecondaryContainer => "#3F5371";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#262500";
    public string OnTertiary => "#E2DF62";
    public string TertiaryContainer => "#565500";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#4F0406";
    public string OnError => "#FFCFCA";
    public string ErrorContainer => "#8E342E";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F9F9FF";
    public string SurfaceVariant => "#D8E3FA";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#192435";
    public string SurfaceDim => "#CFDAF1";
    public string SurfaceBright => "#F9F9FF";
    public string SurfaceTint => "#002449";
    // Background
    public string Background => "#F9F9FF";
    public string OnBackground => "#000000";
    // Outline
    public string Outline => "#384355";
    public string OutlineVariant => "#485365";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#040E1E";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#A3C6FF";
    // Primary Fixed
    public string PrimaryFixed => "#00529B";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#004786";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#3F5371";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#344765";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#565500";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#4A4900";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F0F3FF";
    public string SurfaceContainer => "#E7EEFF";
    public string SurfaceContainerHigh => "#DFE8FC";
    public string SurfaceContainerHighest => "#D8E3FA";
}
