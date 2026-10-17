namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_NormalContrast_Spec2025_Watch_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#B4D0FF";
    public string OnPrimary => "#00305F";
    public string PrimaryContainer => "#18477D";
    public string OnPrimaryContainer => "#D1E1FF";
    // Secondary
    public string Secondary => "#C4ECCF";
    public string OnSecondary => "#234632";
    public string SecondaryContainer => "#2B4E39";
    public string OnSecondaryContainer => "#C2EACD";
    // Tertiary
    public string Tertiary => "#EAFE8A";
    public string OnTertiary => "#434F00";
    public string TertiaryContainer => "#CEE171";
    public string OnTertiaryContainer => "#3B4600";
    // Error
    public string Error => "#FFBEB9";
    public string OnError => "#3F0004";
    public string ErrorContainer => "#7E2A29";
    public string OnErrorContainer => "#FFD7D4";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#19263A";
    public string OnSurface => "#E2E8F7";
    public string OnSurfaceVariant => "#C8CEDD";
    public string SurfaceDim => "#080E19";
    public string SurfaceBright => "#1D2D43";
    public string SurfaceTint => "#B4D0FF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#9FA6B4";
    public string OutlineVariant => "#7F8693";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F9F9FF";
    public string InverseOnSurface => "#4F5562";
    public string InversePrimary => "#2B568D";
    // Primary Fixed
    public string PrimaryFixed => "#B4D0FF";
    public string OnPrimaryFixed => "#00305F";
    public string PrimaryFixedDim => "#98C0FE";
    public string OnPrimaryFixedVariant => "#18477D";
    // Secondary Fixed
    public string SecondaryFixed => "#C4ECCF";
    public string OnSecondaryFixed => "#234632";
    public string SecondaryFixedDim => "#B6DEC2";
    public string OnSecondaryFixedVariant => "#2B4E39";
    // Tertiary Fixed
    public string TertiaryFixed => "#EAFE8A";
    public string OnTertiaryFixed => "#434F00";
    public string TertiaryFixedDim => "#DCEF7D";
    public string OnTertiaryFixedVariant => "#414C00";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1F2631";
    public string SurfaceContainer => "#2A313C";
    public string SurfaceContainerHigh => "#353C47";
    public string SurfaceContainerHighest => "#19263A";
}
