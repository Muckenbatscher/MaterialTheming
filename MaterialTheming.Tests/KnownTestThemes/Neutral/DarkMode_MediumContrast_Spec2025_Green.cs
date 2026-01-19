namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_MediumContrast_Spec2025_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#C1C9BE";
    public string OnPrimary => "#313830";
    public string PrimaryContainer => "#6F776D";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#B8B9B4";
    public string OnSecondary => "#2A2D29";
    public string SecondaryContainer => "#737571";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#E9FFED";
    public string OnTertiary => "#3F5B49";
    public string TertiaryContainer => "#D3F3DB";
    public string OnTertiaryContainer => "#375341";
    // Error
    public string Error => "#FFA089";
    public string OnError => "#591001";
    public string ErrorContainer => "#BA573F";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#0E0E0D";
    public string SurfaceVariant => "#242624";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#B9B9B5";
    public string SurfaceDim => "#0E0E0D";
    public string SurfaceBright => "#2B2D2A";
    public string SurfaceTint => "#C1C9BE";
    // Background
    public string Background => "#0E0E0D";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#939490";
    public string OutlineVariant => "#757672";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FBF9F6";
    public string InverseOnSurface => "#383837";
    public string InversePrimary => "#50574E";
    // Primary Fixed
    public string PrimaryFixed => "#DDE5D9";
    public string OnPrimaryFixed => "#1A211A";
    public string PrimaryFixedDim => "#CFD7CB";
    public string OnPrimaryFixedVariant => "#3A4139";
    // Secondary Fixed
    public string SecondaryFixed => "#E2E3DD";
    public string OnSecondaryFixed => "#1E201D";
    public string SecondaryFixedDim => "#D4D5CF";
    public string OnSecondaryFixedVariant => "#3D403C";
    // Tertiary Fixed
    public string TertiaryFixed => "#DBFCE3";
    public string OnTertiaryFixed => "#163122";
    public string TertiaryFixedDim => "#CDEDD5";
    public string OnTertiaryFixedVariant => "#34503E";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#131412";
    public string SurfaceContainer => "#191A18";
    public string SurfaceContainerHigh => "#1F201E";
    public string SurfaceContainerHighest => "#242624";
}
