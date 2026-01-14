using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_NormalContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#8C4F26";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#FFDBC8";
    public string OnPrimaryContainer => "#6F3811";
    // Secondary
    public string Secondary => "#765847";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#FFDBC8";
    public string OnSecondaryContainer => "#5C4131";
    // Tertiary
    public string Tertiary => "#626033";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#E8E5AC";
    public string OnTertiaryContainer => "#49491E";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#FFF8F5";
    public string SurfaceVariant => "#F4DED3";
    public string OnSurface => "#221A15";
    public string OnSurfaceVariant => "#52443C";
    public string SurfaceDim => "#E7D7CF";
    public string SurfaceBright => "#FFF8F5";
    public string SurfaceTint => "#8C4F26";
    // Background
    public string Background => "#FFF8F5";
    public string OnBackground => "#221A15";
    // Outline
    public string Outline => "#85746B";
    public string OutlineVariant => "#D7C2B8";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#382E29";
    public string InverseOnSurface => "#FFEDE5";
    public string InversePrimary => "#FFB68B";
    // Primary Fixed
    public string PrimaryFixed => "#FFDBC8";
    public string OnPrimaryFixed => "#321300";
    public string PrimaryFixedDim => "#FFB68B";
    public string OnPrimaryFixedVariant => "#6F3811";
    // Secondary Fixed
    public string SecondaryFixed => "#FFDBC8";
    public string OnSecondaryFixed => "#2B1609";
    public string SecondaryFixedDim => "#E5BFA9";
    public string OnSecondaryFixedVariant => "#5C4131";
    // Tertiary Fixed
    public string TertiaryFixed => "#E8E5AC";
    public string OnTertiaryFixed => "#1D1D00";
    public string TertiaryFixedDim => "#CBC992";
    public string OnTertiaryFixedVariant => "#49491E";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1EA";
    public string SurfaceContainer => "#FCEAE2";
    public string SurfaceContainerHigh => "#F6E5DD";
    public string SurfaceContainerHighest => "#F0DFD7";
}
