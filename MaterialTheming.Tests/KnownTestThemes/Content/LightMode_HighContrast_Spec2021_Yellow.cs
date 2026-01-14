using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class LightMode_HighContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#2E2E00";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#4D4C00";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#2E2E04";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#4C4B1E";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#003502";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#10550E";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FDF9EB";
    public string SurfaceVariant => "#E6E3CC";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#BCB9AC";
    public string SurfaceBright => "#FDF9EB";
    public string SurfaceTint => "#636100";
    // Background
    public string Background => "#FDF9EB";
    public string OnBackground => "#1C1C14";
    // Outline
    public string Outline => "#2D2D1D";
    public string OutlineVariant => "#4B4A39";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#323127";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#CECC50";
    // Primary Fixed
    public string PrimaryFixed => "#4D4C00";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#353400";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#4C4B1E";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#353409";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#10550E";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#003C02";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F5F1E3";
    public string SurfaceContainer => "#E6E3D5";
    public string SurfaceContainerHigh => "#D8D4C7";
    public string SurfaceContainerHighest => "#CAC7B9";
}
