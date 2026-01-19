namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_HighContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFFCC6";
    public string OnPrimary => "#3B3A00";
    public string PrimaryContainer => "#F5F200";
    public string OnPrimaryContainer => "#323100";
    // Secondary
    public string Secondary => "#FFE485";
    public string OnSecondary => "#352B00";
    public string SecondaryContainer => "#C1A100";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFE2A9";
    public string OnTertiary => "#3A2900";
    public string TertiaryContainer => "#F7BE26";
    public string OnTertiaryContainer => "#191000";
    // Error
    public string Error => "#FFDED7";
    public string OnError => "#5A0E00";
    public string ErrorContainer => "#FF7E5E";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#130E00";
    public string SurfaceVariant => "#2E2500";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#F9E59F";
    public string SurfaceDim => "#130E00";
    public string SurfaceBright => "#362B00";
    public string SurfaceTint => "#FFFCC6";
    // Background
    public string Background => "#130E00";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#CBB876";
    public string OutlineVariant => "#B5A364";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8EF";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#3B3A00";
    // Primary Fixed
    public string PrimaryFixed => "#F5F200";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#E6E300";
    public string OnPrimaryFixedVariant => "#282700";
    // Secondary Fixed
    public string SecondaryFixed => "#FCD83F";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#EDCA30";
    public string OnSecondaryFixedVariant => "#1E1700";
    // Tertiary Fixed
    public string TertiaryFixed => "#F7BE26";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#E8B013";
    public string OnTertiaryFixedVariant => "#000000";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#191300";
    public string SurfaceContainer => "#201900";
    public string SurfaceContainerHigh => "#271F00";
    public string SurfaceContainerHighest => "#2E2500";
}
