namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_NormalContrast_Spec2026_Watch_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#B4D0FF";
    public string OnPrimary => "#12335A";
    public string PrimaryContainer => "#2A4870";
    public string OnPrimaryContainer => "#D1E1FF";
    // Secondary
    public string Secondary => "#D9E3F8";
    public string OnSecondary => "#364051";
    public string SecondaryContainer => "#3D4758";
    public string OnSecondaryContainer => "#D6E0F6";
    // Tertiary
    public string Tertiary => "#D0C8FF";
    public string OnTertiary => "#322C5A";
    public string TertiaryContainer => "#B4ADE4";
    public string OnTertiaryContainer => "#27214F";
    // Error
    public string Error => "#FFBEB9";
    public string OnError => "#3F0004";
    public string ErrorContainer => "#7E2A29";
    public string OnErrorContainer => "#FFD7D4";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#1B2637";
    public string OnSurface => "#E4E8F4";
    public string OnSurfaceVariant => "#C9CEDA";
    public string SurfaceDim => "#090E17";
    public string SurfaceBright => "#212D3E";
    public string SurfaceTint => "#B4D0FF";
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
    public string InverseOnSurface => "#50555F";
    public string InversePrimary => "#39567F";
    // Primary Fixed
    public string PrimaryFixed => "#B4D0FF";
    public string OnPrimaryFixed => "#12335A";
    public string PrimaryFixedDim => "#A6C2F2";
    public string OnPrimaryFixedVariant => "#2A4870";
    // Secondary Fixed
    public string SecondaryFixed => "#D9E3F8";
    public string OnSecondaryFixed => "#364051";
    public string SecondaryFixedDim => "#CAD5EA";
    public string OnSecondaryFixedVariant => "#3D4758";
    // Tertiary Fixed
    public string TertiaryFixed => "#D0C8FF";
    public string OnTertiaryFixed => "#322C5A";
    public string TertiaryFixedDim => "#C2BAF3";
    public string OnTertiaryFixedVariant => "#474170";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#21262F";
    public string SurfaceContainer => "#2B313A";
    public string SurfaceContainerHigh => "#363C45";
    public string SurfaceContainerHighest => "#1B2637";
}
