namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_MediumContrast_Spec2026_Watch_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFFFFA";
    public string OnPrimary => "#00260A";
    public string PrimaryContainer => "#639066";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFFFA";
    public string OnSecondary => "#132314";
    public string SecondaryContainer => "#788B76";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFEFF";
    public string OnTertiary => "#1D2200";
    public string TertiaryContainer => "#C4CC85";
    public string OnTertiaryContainer => "#333A01";
    // Error
    public string Error => "#FFBFB0";
    public string OnError => "#390600";
    public string ErrorContainer => "#CD6951";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#182A1A";
    public string OnSurface => "#FFFFFA";
    public string OnSurfaceVariant => "#C7D1C3";
    public string SurfaceDim => "#081008";
    public string SurfaceBright => "#1F3020";
    public string SurfaceTint => "#FFFFFA";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#9EA99C";
    public string OutlineVariant => "#7E887C";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F2FCEE";
    public string InverseOnSurface => "#313B31";
    public string InversePrimary => "#15401E";
    // Primary Fixed
    public string PrimaryFixed => "#BEEFBE";
    public string OnPrimaryFixed => "#00260A";
    public string PrimaryFixedDim => "#B0E1B0";
    public string OnPrimaryFixedVariant => "#1D4825";
    // Secondary Fixed
    public string SecondaryFixed => "#D4E8D1";
    public string OnSecondaryFixed => "#132314";
    public string SecondaryFixedDim => "#C6DAC3";
    public string OnSecondaryFixedVariant => "#334433";
    // Tertiary Fixed
    public string TertiaryFixed => "#E0E99E";
    public string OnTertiaryFixed => "#1D2200";
    public string TertiaryFixedDim => "#D2DA91";
    public string OnTertiaryFixedVariant => "#3C4309";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1F281F";
    public string SurfaceContainer => "#2A3329";
    public string SurfaceContainerHigh => "#353E34";
    public string SurfaceContainerHighest => "#182A1A";
}
