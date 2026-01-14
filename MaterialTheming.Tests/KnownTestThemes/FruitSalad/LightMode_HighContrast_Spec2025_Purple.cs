using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_HighContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#002C58";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#00498B";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#002C58";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#264A79";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#3A1F54";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#583D73";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF7FE";
    public string SurfaceVariant => "#EDDDF6";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#BFB5C3";
    public string SurfaceBright => "#FFF7FE";
    public string SurfaceTint => "#215FA6";
    // Background
    public string Background => "#FFF7FE";
    public string OnBackground => "#1F1923";
    // Outline
    public string Outline => "#32283B";
    public string OutlineVariant => "#504559";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#342E39";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#A6C8FF";
    // Primary Fixed
    public string PrimaryFixed => "#00498B";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#003364";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#264A79";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#063361";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#583D73";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#40265B";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F8EDFC";
    public string SurfaceContainer => "#EADFED";
    public string SurfaceContainerHigh => "#DBD1DF";
    public string SurfaceContainerHighest => "#CDC3D1";
}
