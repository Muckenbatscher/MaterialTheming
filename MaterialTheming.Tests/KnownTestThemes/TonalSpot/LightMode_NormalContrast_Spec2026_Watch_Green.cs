namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_NormalContrast_Spec2026_Watch_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#BEEFBE";
    public string OnPrimary => "#1D4825";
    public string PrimaryContainer => "#25502C";
    public string OnPrimaryContainer => "#BCECBC";
    // Secondary
    public string Secondary => "#D4E8D1";
    public string OnSecondary => "#334433";
    public string SecondaryContainer => "#3A4B3A";
    public string OnSecondaryContainer => "#D2E6CE";
    // Tertiary
    public string Tertiary => "#E0E99E";
    public string OnTertiary => "#3C4309";
    public string TertiaryContainer => "#C4CC85";
    public string OnTertiaryContainer => "#333A01";
    // Error
    public string Error => "#FFBFB0";
    public string OnError => "#3B0600";
    public string ErrorContainer => "#7D2C19";
    public string OnErrorContainer => "#FFD7CE";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#182A1A";
    public string OnSurface => "#E1EBDD";
    public string OnSurfaceVariant => "#C7D1C3";
    public string SurfaceDim => "#081008";
    public string SurfaceBright => "#1F3020";
    public string SurfaceTint => "#BEEFBE";
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
    public string InverseOnSurface => "#4E584D";
    public string InversePrimary => "#335E39";
    // Primary Fixed
    public string PrimaryFixed => "#BEEFBE";
    public string OnPrimaryFixed => "#1D4825";
    public string PrimaryFixedDim => "#B0E1B0";
    public string OnPrimaryFixedVariant => "#25502C";
    // Secondary Fixed
    public string SecondaryFixed => "#D4E8D1";
    public string OnSecondaryFixed => "#334433";
    public string SecondaryFixedDim => "#C6DAC3";
    public string OnSecondaryFixedVariant => "#3A4B3A";
    // Tertiary Fixed
    public string TertiaryFixed => "#E0E99E";
    public string OnTertiaryFixed => "#3C4309";
    public string TertiaryFixedDim => "#D2DA91";
    public string OnTertiaryFixedVariant => "#444B11";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1F281F";
    public string SurfaceContainer => "#2A3329";
    public string SurfaceContainerHigh => "#353E34";
    public string SurfaceContainerHighest => "#182A1A";
}
