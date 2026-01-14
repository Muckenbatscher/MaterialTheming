using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_NormalContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#5C5698";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#E4DFFF";
    public string OnPrimaryContainer => "#443E7F";
    // Secondary
    public string Secondary => "#4B6546";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#CCEBC4";
    public string OnSecondaryContainer => "#334D30";
    // Tertiary
    public string Tertiary => "#2A6953";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#AFF0D4";
    public string OnTertiaryContainer => "#08513C";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#FFF8F5";
    public string SurfaceVariant => "#F8DEC7";
    public string OnSurface => "#231A11";
    public string OnSurfaceVariant => "#554433";
    public string SurfaceDim => "#E9D7C8";
    public string SurfaceBright => "#FFF8F5";
    public string SurfaceTint => "#5C5698";
    // Background
    public string Background => "#FFF8F5";
    public string OnBackground => "#231A11";
    // Outline
    public string Outline => "#887361";
    public string OutlineVariant => "#DBC2AC";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#392E25";
    public string InverseOnSurface => "#FFEEE0";
    public string InversePrimary => "#C6BFFF";
    // Primary Fixed
    public string PrimaryFixed => "#E4DFFF";
    public string OnPrimaryFixed => "#180F51";
    public string PrimaryFixedDim => "#C6BFFF";
    public string OnPrimaryFixedVariant => "#443E7F";
    // Secondary Fixed
    public string SecondaryFixed => "#CCEBC4";
    public string OnSecondaryFixed => "#082008";
    public string SecondaryFixedDim => "#B1CFA9";
    public string OnSecondaryFixedVariant => "#334D30";
    // Tertiary Fixed
    public string TertiaryFixed => "#AFF0D4";
    public string OnTertiaryFixed => "#002116";
    public string TertiaryFixedDim => "#94D4B9";
    public string OnTertiaryFixedVariant => "#08513C";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1E7";
    public string SurfaceContainer => "#FDEBDC";
    public string SurfaceContainerHigh => "#F8E5D6";
    public string SurfaceContainerHighest => "#F2DFD1";
}
