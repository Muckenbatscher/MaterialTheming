using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_MediumContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#542C00";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#A35B03";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#542C00";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#996029";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#393800";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#717025";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FEFAE3";
    public string SurfaceVariant => "#E7E4BF";
    public string OnSurface => "#121205";
    public string OnSurfaceVariant => "#38371D";
    public string SurfaceDim => "#CAC7B1";
    public string SurfaceBright => "#FEFAE3";
    public string SurfaceTint => "#8E4E00";
    // Background
    public string Background => "#FEFAE3";
    public string OnBackground => "#1D1C0E";
    // Outline
    public string Outline => "#555437";
    public string OutlineVariant => "#706E50";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#323122";
    public string InverseOnSurface => "#F5F1DA";
    public string InversePrimary => "#FFB779";
    // Primary Fixed
    public string PrimaryFixed => "#A35B03";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#814600";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#996029";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#7C4813";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#717025";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#58570D";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F8F4DD";
    public string SurfaceContainer => "#ECE9D2";
    public string SurfaceContainerHigh => "#E1DEC7";
    public string SurfaceContainerHighest => "#D5D2BC";
}
