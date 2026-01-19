namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_NormalContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFB8AF";
    public string OnPrimary => "#6D2F29";
    public string PrimaryContainer => "#FDA49A";
    public string OnPrimaryContainer => "#612621";
    // Secondary
    public string Secondary => "#B3CAD5";
    public string OnSecondary => "#2E434C";
    public string SecondaryContainer => "#132931";
    public string OnSecondaryContainer => "#91A7B2";
    // Tertiary
    public string Tertiary => "#7FE2FF";
    public string OnTertiary => "#005061";
    public string TertiaryContainer => "#58D6F7";
    public string OnTertiaryContainer => "#004756";
    // Error
    public string Error => "#FD6F85";
    public string OnError => "#490013";
    public string ErrorContainer => "#8A1632";
    public string OnErrorContainer => "#FF97A3";
    // Surface
    public string Surface => "#1B0905";
    public string SurfaceVariant => "#3E1C12";
    public string OnSurface => "#FFDED6";
    public string OnSurfaceVariant => "#D59E8F";
    public string SurfaceDim => "#1B0905";
    public string SurfaceBright => "#472116";
    public string SurfaceTint => "#FFB8AF";
    // Background
    public string Background => "#1B0905";
    public string OnBackground => "#FFDED6";
    // Outline
    public string Outline => "#996A5C";
    public string OutlineVariant => "#663E32";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F6";
    public string InverseOnSurface => "#6A4F47";
    public string InversePrimary => "#914B44";
    // Primary Fixed
    public string PrimaryFixed => "#FFACA2";
    public string OnPrimaryFixed => "#4B1511";
    public string PrimaryFixedDim => "#F49C93";
    public string OnPrimaryFixedVariant => "#71322C";
    // Secondary Fixed
    public string SecondaryFixed => "#DAF2FD";
    public string OnSecondaryFixed => "#344952";
    public string SecondaryFixedDim => "#CCE3EE";
    public string OnSecondaryFixedVariant => "#50666F";
    // Tertiary Fixed
    public string TertiaryFixed => "#58D6F7";
    public string OnTertiaryFixed => "#00313C";
    public string TertiaryFixedDim => "#46C8E9";
    public string OnTertiaryFixedVariant => "#005061";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#230D07";
    public string SurfaceContainer => "#2C130B";
    public string SurfaceContainerHigh => "#35170F";
    public string SurfaceContainerHighest => "#3E1C12";
}
