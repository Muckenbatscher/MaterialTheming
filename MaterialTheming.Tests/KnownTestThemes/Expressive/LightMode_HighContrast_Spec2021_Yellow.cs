using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_HighContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#501538";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#733356";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#12321D";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#305038";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#1F3103";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#3B4F1D";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FAFBEA";
    public string SurfaceVariant => "#E1E5CC";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#B8BAAB";
    public string SurfaceBright => "#FAFBEA";
    public string SurfaceTint => "#8C486C";
    // Background
    public string Background => "#FAFBEA";
    public string OnBackground => "#1A1D13";
    // Outline
    public string Outline => "#2A2E1E";
    public string OutlineVariant => "#474B39";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2F3227";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#FFAFD6";
    // Primary Fixed
    public string PrimaryFixed => "#733356";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#581C3F";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#305038";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#193923";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#3B4F1D";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#253808";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F1F2E2";
    public string SurfaceContainer => "#E2E4D4";
    public string SurfaceContainerHigh => "#D4D6C6";
    public string SurfaceContainerHighest => "#C6C8B8";
}
