namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_MediumContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#3B4446";
    public string OnPrimary => "#D2DBDD";
    public string PrimaryContainer => "#6D7678";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#404344";
    public string OnSecondary => "#D8DADA";
    public string SecondaryContainer => "#727576";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#2C4655";
    public string OnTertiary => "#C2DEF0";
    public string TertiaryContainer => "#5E7888";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#7A2524";
    public string OnError => "#FFCECA";
    public string ErrorContainer => "#BB5551";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FBF9F8";
    public string SurfaceVariant => "#E2E2E3";
    public string OnSurface => "#222425";
    public string OnSurfaceVariant => "#414344";
    public string SurfaceDim => "#D9DADA";
    public string SurfaceBright => "#FBF9F8";
    public string SurfaceTint => "#3B4446";
    // Background
    public string Background => "#FBF9F8";
    public string OnBackground => "#222425";
    // Outline
    public string Outline => "#5D5F60";
    public string OutlineVariant => "#797B7B";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#0E0E0E";
    public string InverseOnSurface => "#C6C4C4";
    public string InversePrimary => "#E6F0F2";
    // Primary Fixed
    public string PrimaryFixed => "#6D7678";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#606A6C";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#727576";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#656969";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#5E7888";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#516C7C";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F5F3F3";
    public string SurfaceContainer => "#EEEEED";
    public string SurfaceContainerHigh => "#E8E8E8";
    public string SurfaceContainerHighest => "#E2E2E3";
}
