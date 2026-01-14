using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_MediumContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#CAC7B6";
    public string OnPrimary => "#37372A";
    public string PrimaryContainer => "#777566";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#BCB8B0";
    public string OnSecondary => "#2D2C27";
    public string SecondaryContainer => "#76746D";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#F7FDD0";
    public string OnTertiary => "#525836";
    public string TertiaryContainer => "#E9EFC2";
    public string OnTertiaryContainer => "#4A502F";
    // Error
    public string Error => "#FFA089";
    public string OnError => "#591001";
    public string ErrorContainer => "#BA573F";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#0F0E0D";
    public string SurfaceVariant => "#272622";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#BBB8B2";
    public string SurfaceDim => "#0F0E0D";
    public string SurfaceBright => "#2D2C27";
    public string SurfaceTint => "#CAC7B6";
    // Background
    public string Background => "#0F0E0D";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#96938D";
    public string OutlineVariant => "#777570";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FDF9F5";
    public string InverseOnSurface => "#393836";
    public string InversePrimary => "#575648";
    // Primary Fixed
    public string PrimaryFixed => "#E6E3D1";
    public string OnPrimaryFixed => "#202015";
    public string PrimaryFixedDim => "#D8D5C3";
    public string OnPrimaryFixedVariant => "#414033";
    // Secondary Fixed
    public string SecondaryFixed => "#E6E2D9";
    public string OnSecondaryFixed => "#20201A";
    public string SecondaryFixedDim => "#D8D4CC";
    public string OnSecondaryFixedVariant => "#403F39";
    // Tertiary Fixed
    public string TertiaryFixed => "#F2F8CA";
    public string OnTertiaryFixed => "#292E10";
    public string TertiaryFixedDim => "#E3E9BD";
    public string OnTertiaryFixedVariant => "#474D2B";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#141311";
    public string SurfaceContainer => "#1A1A17";
    public string SurfaceContainerHigh => "#20201C";
    public string SurfaceContainerHighest => "#272622";
}
