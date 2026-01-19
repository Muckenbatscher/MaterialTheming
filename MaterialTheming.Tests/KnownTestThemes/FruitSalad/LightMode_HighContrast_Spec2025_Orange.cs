namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_HighContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#580B2E";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#7E2B4B";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#4F182E";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#73354B";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#4B2000";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#723A13";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F5";
    public string SurfaceVariant => "#FFDBC8";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#CCB4A7";
    public string SurfaceBright => "#FFF8F5";
    public string SurfaceTint => "#984061";
    // Background
    public string Background => "#FFF8F5";
    public string OnBackground => "#261910";
    // Outline
    public string Outline => "#3E2718";
    public string OutlineVariant => "#5E4333";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#3D2D24";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#FFB1C8";
    // Primary Fixed
    public string PrimaryFixed => "#7E2B4B";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#611335";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#73354B";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#571F34";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#723A13";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#552500";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFEDE5";
    public string SurfaceContainer => "#F8DDD0";
    public string SurfaceContainerHigh => "#E9CFC2";
    public string SurfaceContainerHighest => "#DBC2B4";
}
