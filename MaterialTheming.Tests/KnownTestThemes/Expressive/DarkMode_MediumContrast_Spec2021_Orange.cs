namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_MediumContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#DDD8FF";
    public string OnPrimary => "#221B5B";
    public string PrimaryContainer => "#8F89CF";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#C6E5BE";
    public string OnSecondary => "#132B11";
    public string SecondaryContainer => "#7C9876";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#A9EACE";
    public string OnTertiary => "#002C1F";
    public string TertiaryContainer => "#5E9D84";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#1A1209";
    public string SurfaceVariant => "#554433";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#F2D8C1";
    public string SurfaceDim => "#1A1209";
    public string SurfaceBright => "#4E4238";
    public string SurfaceTint => "#C6BFFF";
    // Background
    public string Background => "#1A1209";
    public string OnBackground => "#F2DFD1";
    // Outline
    public string Outline => "#C5AE99";
    public string OutlineVariant => "#A28C79";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F2DFD1";
    public string InverseOnSurface => "#32281F";
    public string InversePrimary => "#453F80";
    // Primary Fixed
    public string PrimaryFixed => "#E4DFFF";
    public string OnPrimaryFixed => "#0D0148";
    public string PrimaryFixedDim => "#C6BFFF";
    public string OnPrimaryFixedVariant => "#332D6D";
    // Secondary Fixed
    public string SecondaryFixed => "#CCEBC4";
    public string OnSecondaryFixed => "#011602";
    public string SecondaryFixedDim => "#B1CFA9";
    public string OnSecondaryFixedVariant => "#233C21";
    // Tertiary Fixed
    public string TertiaryFixed => "#AFF0D4";
    public string OnTertiaryFixed => "#00150D";
    public string TertiaryFixedDim => "#94D4B9";
    public string OnTertiaryFixedVariant => "#003F2D";
    // Surface Container
    public string SurfaceContainerLowest => "#0D0602";
    public string SurfaceContainerLow => "#251C13";
    public string SurfaceContainer => "#30261D";
    public string SurfaceContainerHigh => "#3B3127";
    public string SurfaceContainerHighest => "#473C31";
}
