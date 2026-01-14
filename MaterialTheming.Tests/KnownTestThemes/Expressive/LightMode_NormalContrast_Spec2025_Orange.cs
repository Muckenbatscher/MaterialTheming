using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_NormalContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#97490C";
    public string OnPrimary => "#FFF7F5";
    public string PrimaryContainer => "#FFAF7D";
    public string OnPrimaryContainer => "#652C00";
    // Secondary
    public string Secondary => "#48617B";
    public string OnSecondary => "#F7F9FF";
    public string SecondaryContainer => "#CFE5FF";
    public string OnSecondaryContainer => "#3B546D";
    // Tertiary
    public string Tertiary => "#006497";
    public string OnTertiary => "#F6F9FF";
    public string TertiaryContainer => "#6FC0FF";
    public string OnTertiaryContainer => "#003A5A";
    // Error
    public string Error => "#AA371C";
    public string OnError => "#FFF7F6";
    public string ErrorContainer => "#FA7150";
    public string OnErrorContainer => "#671200";
    // Surface
    public string Surface => "#FFF8F5";
    public string SurfaceVariant => "#FFDCC1";
    public string OnSurface => "#4D2A04";
    public string OnSurfaceVariant => "#82552C";
    public string SurfaceDim => "#FFD1AD";
    public string SurfaceBright => "#FFF8F5";
    public string SurfaceTint => "#97490C";
    // Background
    public string Background => "#FFF8F5";
    public string OnBackground => "#4D2A04";
    // Outline
    public string Outline => "#A17045";
    public string OutlineVariant => "#DFA676";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#1B0A00";
    public string InverseOnSurface => "#B9967A";
    public string InversePrimary => "#F89555";
    // Primary Fixed
    public string PrimaryFixed => "#FFAF7D";
    public string OnPrimaryFixed => "#451C00";
    public string PrimaryFixedDim => "#FE9B5A";
    public string OnPrimaryFixedVariant => "#723300";
    // Secondary Fixed
    public string SecondaryFixed => "#CFE5FF";
    public string OnSecondaryFixed => "#28415A";
    public string SecondaryFixedDim => "#BDD7F5";
    public string OnSecondaryFixedVariant => "#455E77";
    // Tertiary Fixed
    public string TertiaryFixed => "#6FC0FF";
    public string OnTertiaryFixed => "#002338";
    public string TertiaryFixedDim => "#5FB2F1";
    public string OnTertiaryFixedVariant => "#004367";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1E8";
    public string SurfaceContainer => "#FFEADC";
    public string SurfaceContainerHigh => "#FFE3CF";
    public string SurfaceContainerHighest => "#FFDCC1";
}
