namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class LightMode_MediumContrast_Spec2026_Blue_Blue : ITestThemeSecondSourceColor
{
    public string SourceColor => "#185FAA"; //Blue
    public string SecondSourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#004380";
    public string OnPrimary => "#C6DBFF";
    public string PrimaryContainer => "#185FAA";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#304461";
    public string OnSecondary => "#C6DBFF";
    public string SecondaryContainer => "#627595";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#1A4375";
    public string OnTertiary => "#C6DBFF";
    public string TertiaryContainer => "#3A6092";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#7A2521";
    public string OnError => "#FFCEC9";
    public string ErrorContainer => "#BB554D";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F9F9FF";
    public string SurfaceVariant => "#D8E3FA";
    public string OnSurface => "#192435";
    public string OnSurfaceVariant => "#384355";
    public string SurfaceDim => "#CFDAF1";
    public string SurfaceBright => "#F9F9FF";
    public string SurfaceTint => "#004380";
    // Background
    public string Background => "#F9F9FF";
    public string OnBackground => "#192435";
    // Outline
    public string Outline => "#546073";
    public string OutlineVariant => "#707B8F";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#040E1E";
    public string InverseOnSurface => "#C0C5D1";
    public string InversePrimary => "#6CA5F5";
    // Primary Fixed
    public string PrimaryFixed => "#185FAA";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#00539B";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#627595";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#566988";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#3A6092";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#2D5386";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F0F3FF";
    public string SurfaceContainer => "#E7EEFF";
    public string SurfaceContainerHigh => "#DFE8FC";
    public string SurfaceContainerHighest => "#D8E3FA";
}
