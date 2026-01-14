using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_NormalContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#CAC7B6";
    public string OnPrimary => "#424134";
    public string PrimaryContainer => "#48473A";
    public string OnPrimaryContainer => "#D4D1BF";
    // Secondary
    public string Secondary => "#A09E96";
    public string OnSecondary => "#21201B";
    public string SecondaryContainer => "#3D3B35";
    public string OnSecondaryContainer => "#C2BFB7";
    // Tertiary
    public string Tertiary => "#F7FDD0";
    public string OnTertiary => "#5C623F";
    public string TertiaryContainer => "#E9EFC2";
    public string OnTertiaryContainer => "#545A38";
    // Error
    public string Error => "#ED7F64";
    public string OnError => "#450900";
    public string ErrorContainer => "#7E2B17";
    public string OnErrorContainer => "#FF9B82";
    // Surface
    public string Surface => "#0F0E0D";
    public string SurfaceVariant => "#272622";
    public string OnSurface => "#E9E5DE";
    public string OnSurfaceVariant => "#AEABA5";
    public string SurfaceDim => "#0F0E0D";
    public string SurfaceBright => "#2D2C27";
    public string SurfaceTint => "#CAC7B6";
    // Background
    public string Background => "#0F0E0D";
    public string OnBackground => "#E9E5DE";
    // Outline
    public string Outline => "#777570";
    public string OutlineVariant => "#494843";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FDF9F5";
    public string InverseOnSurface => "#565552";
    public string InversePrimary => "#615F51";
    // Primary Fixed
    public string PrimaryFixed => "#E6E3D1";
    public string OnPrimaryFixed => "#414033";
    public string PrimaryFixedDim => "#D8D5C3";
    public string OnPrimaryFixedVariant => "#5D5C4E";
    // Secondary Fixed
    public string SecondaryFixed => "#E6E2D9";
    public string OnSecondaryFixed => "#403F39";
    public string SecondaryFixedDim => "#D8D4CC";
    public string OnSecondaryFixedVariant => "#5D5B55";
    // Tertiary Fixed
    public string TertiaryFixed => "#F2F8CA";
    public string OnTertiaryFixed => "#474D2B";
    public string TertiaryFixedDim => "#E3E9BD";
    public string OnTertiaryFixedVariant => "#636946";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#141311";
    public string SurfaceContainer => "#1A1A17";
    public string SurfaceContainerHigh => "#20201C";
    public string SurfaceContainerHighest => "#272622";
}
