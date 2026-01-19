namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_MediumContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFFCC6";
    public string OnPrimary => "#595800";
    public string PrimaryContainer => "#F5F200";
    public string OnPrimaryContainer => "#514F00";
    // Secondary
    public string Secondary => "#FCD83F";
    public string OnSecondary => "#504200";
    public string SecondaryContainer => "#8A7300";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#FFCE5D";
    public string OnTertiary => "#523C00";
    public string TertiaryContainer => "#F7BE26";
    public string OnTertiaryContainer => "#473300";
    // Error
    public string Error => "#FFA089";
    public string OnError => "#5A0E00";
    public string ErrorContainer => "#D53D18";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#130E00";
    public string SurfaceVariant => "#2E2500";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#CBB876";
    public string SurfaceDim => "#130E00";
    public string SurfaceBright => "#362B00";
    public string SurfaceTint => "#FFFCC6";
    // Background
    public string Background => "#130E00";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#A49355";
    public string OutlineVariant => "#84753A";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8EF";
    public string InverseOnSurface => "#433702";
    public string InversePrimary => "#595800";
    // Primary Fixed
    public string PrimaryFixed => "#F5F200";
    public string OnPrimaryFixed => "#282700";
    public string PrimaryFixedDim => "#E6E300";
    public string OnPrimaryFixedVariant => "#484700";
    // Secondary Fixed
    public string SecondaryFixed => "#FCD83F";
    public string OnSecondaryFixed => "#1E1700";
    public string SecondaryFixedDim => "#EDCA30";
    public string OnSecondaryFixedVariant => "#463900";
    // Tertiary Fixed
    public string TertiaryFixed => "#F7BE26";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#E8B013";
    public string OnTertiaryFixedVariant => "#3A2900";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#191300";
    public string SurfaceContainer => "#201900";
    public string SurfaceContainerHigh => "#271F00";
    public string SurfaceContainerHighest => "#2E2500";
}
