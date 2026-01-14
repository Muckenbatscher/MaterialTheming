using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_HighContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#2E2E00";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#4D4C00";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#282F0B";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#444D25";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#1A3206";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#365021";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FEFAE3";
    public string SurfaceVariant => "#E7E3C8";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#BCB9A4";
    public string SurfaceBright => "#FEFAE3";
    public string SurfaceTint => "#636100";
    // Background
    public string Background => "#FEFAE3";
    public string OnBackground => "#1D1C0E";
    // Outline
    public string Outline => "#2E2D1B";
    public string OutlineVariant => "#4B4A36";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#323122";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#CFCC00";
    // Primary Fixed
    public string PrimaryFixed => "#4D4C00";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#353400";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#444D25";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#2E3611";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#365021";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#21390C";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F5F1DA";
    public string SurfaceContainer => "#E6E3CD";
    public string SurfaceContainerHigh => "#D8D5BF";
    public string SurfaceContainerHighest => "#CAC7B1";
}
