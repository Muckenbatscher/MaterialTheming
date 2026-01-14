using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_NormalContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#705A4D";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#FBDCCC";
    public string OnPrimaryContainer => "#574236";
    // Secondary
    public string Secondary => "#6B5B53";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#F4DED3";
    public string OnSecondaryContainer => "#52443C";
    // Tertiary
    public string Tertiary => "#765847";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#FFDBC8";
    public string OnTertiaryContainer => "#5C4131";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#FFF8F5";
    public string SurfaceVariant => "#E9E1DE";
    public string OnSurface => "#1E1B19";
    public string OnSurfaceVariant => "#4A4644";
    public string SurfaceDim => "#E0D8D6";
    public string SurfaceBright => "#FFF8F5";
    public string SurfaceTint => "#705A4D";
    // Background
    public string Background => "#FFF8F5";
    public string OnBackground => "#1E1B19";
    // Outline
    public string Outline => "#7B7674";
    public string OutlineVariant => "#CCC5C2";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#33302E";
    public string InverseOnSurface => "#F7EFEC";
    public string InversePrimary => "#DEC1B1";
    // Primary Fixed
    public string PrimaryFixed => "#FBDCCC";
    public string OnPrimaryFixed => "#28180E";
    public string PrimaryFixedDim => "#DEC1B1";
    public string OnPrimaryFixedVariant => "#574236";
    // Secondary Fixed
    public string SecondaryFixed => "#F4DED3";
    public string OnSecondaryFixed => "#241913";
    public string SecondaryFixedDim => "#D7C2B8";
    public string OnSecondaryFixedVariant => "#52443C";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFDBC8";
    public string OnTertiaryFixed => "#2B1609";
    public string TertiaryFixedDim => "#E5BFA9";
    public string OnTertiaryFixedVariant => "#5C4131";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FAF2EF";
    public string SurfaceContainer => "#F4ECE9";
    public string SurfaceContainerHigh => "#EEE6E4";
    public string SurfaceContainerHighest => "#E9E1DE";
}
