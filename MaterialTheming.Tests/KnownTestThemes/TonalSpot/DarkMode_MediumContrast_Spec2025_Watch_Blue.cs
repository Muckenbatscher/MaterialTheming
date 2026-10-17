namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_MediumContrast_Spec2025_Watch_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFFEFF";
    public string OnPrimary => "#000819";
    public string PrimaryContainer => "#6B87B3";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFEFF";
    public string OnSecondary => "#16202F";
    public string SecondaryContainer => "#7C8699";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFEFF";
    public string OnTertiary => "#07002F";
    public string TertiaryContainer => "#B4ADE4";
    public string OnTertiaryContainer => "#27214F";
    // Error
    public string Error => "#FFBEB9";
    public string OnError => "#3D0004";
    public string ErrorContainer => "#CE6762";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#1B2637";
    public string OnSurface => "#FFFEFF";
    public string OnSurfaceVariant => "#C9CEDA";
    public string SurfaceDim => "#090E17";
    public string SurfaceBright => "#212D3E";
    public string SurfaceTint => "#FFFEFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#A1A6B1";
    public string OutlineVariant => "#818691";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F9F9FF";
    public string InverseOnSurface => "#333842";
    public string InversePrimary => "#1A3960";
    // Primary Fixed
    public string PrimaryFixed => "#B4D0FF";
    public string OnPrimaryFixed => "#000819";
    public string PrimaryFixedDim => "#A6C2F2";
    public string OnPrimaryFixedVariant => "#12335A";
    // Secondary Fixed
    public string SecondaryFixed => "#D9E3F8";
    public string OnSecondaryFixed => "#16202F";
    public string SecondaryFixedDim => "#CAD5EA";
    public string OnSecondaryFixedVariant => "#364051";
    // Tertiary Fixed
    public string TertiaryFixed => "#D0C8FF";
    public string OnTertiaryFixed => "#07002F";
    public string TertiaryFixedDim => "#C2BAF3";
    public string OnTertiaryFixedVariant => "#322C5A";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#21262F";
    public string SurfaceContainer => "#2B313A";
    public string SurfaceContainerHigh => "#363C45";
    public string SurfaceContainerHighest => "#1B2637";
}
