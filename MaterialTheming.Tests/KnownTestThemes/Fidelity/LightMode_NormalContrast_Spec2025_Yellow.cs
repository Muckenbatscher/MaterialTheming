using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class LightMode_NormalContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#636100";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#B2B037";
    public string OnPrimaryContainer => "#434200";
    // Secondary
    public string Secondary => "#626031";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#E5E3A7";
    public string OnSecondaryContainer => "#666535";
    // Tertiary
    public string Tertiary => "#6F4CA4";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#BF9AF8";
    public string OnTertiaryContainer => "#4F2C82";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#FDF9EB";
    public string SurfaceVariant => "#E6E3CC";
    public string OnSurface => "#1C1C14";
    public string OnSurfaceVariant => "#484736";
    public string SurfaceDim => "#DDDACC";
    public string SurfaceBright => "#FDF9EB";
    public string SurfaceTint => "#636100";
    // Background
    public string Background => "#FDF9EB";
    public string OnBackground => "#1C1C14";
    // Outline
    public string Outline => "#7A7864";
    public string OutlineVariant => "#CAC7B1";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#323127";
    public string InverseOnSurface => "#F5F1E3";
    public string InversePrimary => "#CECC50";
    // Primary Fixed
    public string PrimaryFixed => "#EAE869";
    public string OnPrimaryFixed => "#1D1D00";
    public string PrimaryFixedDim => "#CECC50";
    public string OnPrimaryFixedVariant => "#4A4900";
    // Secondary Fixed
    public string SecondaryFixed => "#E8E5AA";
    public string OnSecondaryFixed => "#1D1D00";
    public string SecondaryFixedDim => "#CCC990";
    public string OnSecondaryFixedVariant => "#49491C";
    // Tertiary Fixed
    public string TertiaryFixed => "#ECDCFF";
    public string OnTertiaryFixed => "#280056";
    public string TertiaryFixedDim => "#D6BAFF";
    public string OnTertiaryFixedVariant => "#56348A";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F7F4E5";
    public string SurfaceContainer => "#F2EEE0";
    public string SurfaceContainerHigh => "#ECE8DA";
    public string SurfaceContainerHighest => "#E6E3D5";
}
