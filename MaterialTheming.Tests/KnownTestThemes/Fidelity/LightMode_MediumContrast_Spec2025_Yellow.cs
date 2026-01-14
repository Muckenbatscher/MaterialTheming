using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class LightMode_MediumContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#393800";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#727000";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#39380C";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#716F3E";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#452178";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#7E5BB4";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FDF9EB";
    public string SurfaceVariant => "#E6E3CC";
    public string OnSurface => "#12110A";
    public string OnSurfaceVariant => "#383727";
    public string SurfaceDim => "#CAC7B9";
    public string SurfaceBright => "#FDF9EB";
    public string SurfaceTint => "#636100";
    // Background
    public string Background => "#FDF9EB";
    public string OnBackground => "#1C1C14";
    // Outline
    public string Outline => "#545342";
    public string OutlineVariant => "#6F6E5B";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#323127";
    public string InverseOnSurface => "#F5F1E3";
    public string InversePrimary => "#CECC50";
    // Primary Fixed
    public string PrimaryFixed => "#727000";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#595700";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#716F3E";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#585728";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#7E5BB4";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#654299";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F7F4E5";
    public string SurfaceContainer => "#ECE8DA";
    public string SurfaceContainerHigh => "#E0DDCF";
    public string SurfaceContainerHighest => "#D5D2C4";
}
