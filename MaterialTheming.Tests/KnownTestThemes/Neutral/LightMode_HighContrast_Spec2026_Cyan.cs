namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_HighContrast_Spec2026_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#1C2527";
    public string OnPrimary => "#D2DCDE";
    public string PrimaryContainer => "#4A5456";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#212425";
    public string OnSecondary => "#D8DADB";
    public string SecondaryContainer => "#4F5353";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#0A2735";
    public string OnTertiary => "#C2DEF1";
    public string TertiaryContainer => "#3B5565";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#4F0409";
    public string OnError => "#FFCFCB";
    public string ErrorContainer => "#8E3432";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FBF9F8";
    public string SurfaceVariant => "#E2E2E3";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#222425";
    public string SurfaceDim => "#D9DADA";
    public string SurfaceBright => "#FBF9F8";
    public string SurfaceTint => "#1C2527";
    // Background
    public string Background => "#FBF9F8";
    public string OnBackground => "#000000";
    // Outline
    public string Outline => "#414344";
    public string OutlineVariant => "#505253";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#0E0E0E";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#E6F0F2";
    // Primary Fixed
    public string PrimaryFixed => "#4A5456";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#3F484A";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#4F5353";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#444748";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#3B5565";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#304A59";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F5F3F3";
    public string SurfaceContainer => "#EEEEED";
    public string SurfaceContainerHigh => "#E8E8E8";
    public string SurfaceContainerHighest => "#E2E2E3";
}
