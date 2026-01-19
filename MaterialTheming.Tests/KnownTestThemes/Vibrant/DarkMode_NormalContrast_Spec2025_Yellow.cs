namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_NormalContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFFCC6";
    public string OnPrimary => "#636200";
    public string PrimaryContainer => "#F5F200";
    public string OnPrimaryContainer => "#5B5A00";
    // Secondary
    public string Secondary => "#FCD83F";
    public string OnSecondary => "#5B4B00";
    public string SecondaryContainer => "#705D00";
    public string OnSecondaryContainer => "#FFF7E7";
    // Tertiary
    public string Tertiary => "#FFCE5D";
    public string OnTertiary => "#5E4500";
    public string TertiaryContainer => "#F7BE26";
    public string OnTertiaryContainer => "#533D00";
    // Error
    public string Error => "#FF7351";
    public string OnError => "#450900";
    public string ErrorContainer => "#B92902";
    public string OnErrorContainer => "#FFD2C8";
    // Surface
    public string Surface => "#130E00";
    public string SurfaceVariant => "#2E2500";
    public string OnSurface => "#F9E59F";
    public string OnSurfaceVariant => "#BDAA6A";
    public string SurfaceDim => "#130E00";
    public string SurfaceBright => "#362B00";
    public string SurfaceTint => "#FFFCC6";
    // Background
    public string Background => "#130E00";
    public string OnBackground => "#F9E59F";
    // Outline
    public string Outline => "#84753A";
    public string OutlineVariant => "#544711";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8EF";
    public string InverseOnSurface => "#62541D";
    public string InversePrimary => "#636200";
    // Primary Fixed
    public string PrimaryFixed => "#F5F200";
    public string OnPrimaryFixed => "#484700";
    public string PrimaryFixedDim => "#E6E300";
    public string OnPrimaryFixedVariant => "#656400";
    // Secondary Fixed
    public string SecondaryFixed => "#FCD83F";
    public string OnSecondaryFixed => "#463900";
    public string SecondaryFixedDim => "#EDCA30";
    public string OnSecondaryFixedVariant => "#665500";
    // Tertiary Fixed
    public string TertiaryFixed => "#F7BE26";
    public string OnTertiaryFixed => "#3A2900";
    public string TertiaryFixedDim => "#E8B013";
    public string OnTertiaryFixedVariant => "#5E4500";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#191300";
    public string SurfaceContainer => "#201900";
    public string SurfaceContainerHigh => "#271F00";
    public string SurfaceContainerHighest => "#2E2500";
}
