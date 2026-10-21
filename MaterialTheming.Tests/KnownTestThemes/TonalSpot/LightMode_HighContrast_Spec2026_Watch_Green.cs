namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_HighContrast_Spec2026_Watch_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFFFFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#83B184";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFFFF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#98AB95";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFFFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#C4CC85";
    public string OnTertiaryContainer => "#101300";
    // Error
    public string Error => "#FFBFB0";
    public string OnError => "#000000";
    public string ErrorContainer => "#F4886D";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#182A1A";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFA";
    public string SurfaceDim => "#081008";
    public string SurfaceBright => "#1F3020";
    public string SurfaceTint => "#FFFFFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#C7D1C3";
    public string OutlineVariant => "#9EA99C";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F2FCEE";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#000000";
    // Primary Fixed
    public string PrimaryFixed => "#BEEFBE";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#B0E1B0";
    public string OnPrimaryFixedVariant => "#00260A";
    // Secondary Fixed
    public string SecondaryFixed => "#D4E8D1";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#C6DAC3";
    public string OnSecondaryFixedVariant => "#132314";
    // Tertiary Fixed
    public string TertiaryFixed => "#E0E99E";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#D2DA91";
    public string OnTertiaryFixedVariant => "#1D2200";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1F281F";
    public string SurfaceContainer => "#2A3329";
    public string SurfaceContainerHigh => "#353E34";
    public string SurfaceContainerHighest => "#182A1A";
}
