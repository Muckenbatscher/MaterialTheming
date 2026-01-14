using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_NormalContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#636100";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#ECE900";
    public string OnPrimaryContainer => "#4A4900";
    // Secondary
    public string Secondary => "#596239";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#DEE8B3";
    public string OnSecondaryContainer => "#424A23";
    // Tertiary
    public string Tertiary => "#4B6635";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#CCEDAE";
    public string OnTertiaryContainer => "#344E1F";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#FEFAE3";
    public string SurfaceVariant => "#E7E3C8";
    public string OnSurface => "#1D1C0E";
    public string OnSurfaceVariant => "#494833";
    public string SurfaceDim => "#DEDBC4";
    public string SurfaceBright => "#FEFAE3";
    public string SurfaceTint => "#636100";
    // Background
    public string Background => "#FEFAE3";
    public string OnBackground => "#1D1C0E";
    // Outline
    public string Outline => "#7A7861";
    public string OutlineVariant => "#CAC7AD";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#323122";
    public string InverseOnSurface => "#F5F1DA";
    public string InversePrimary => "#CFCC00";
    // Primary Fixed
    public string PrimaryFixed => "#ECE900";
    public string OnPrimaryFixed => "#1D1D00";
    public string PrimaryFixedDim => "#CFCC00";
    public string OnPrimaryFixedVariant => "#4A4900";
    // Secondary Fixed
    public string SecondaryFixed => "#DEE8B3";
    public string OnSecondaryFixed => "#171E00";
    public string SecondaryFixedDim => "#C2CC99";
    public string OnSecondaryFixedVariant => "#424A23";
    // Tertiary Fixed
    public string TertiaryFixed => "#CCEDAE";
    public string OnTertiaryFixed => "#0C2000";
    public string TertiaryFixedDim => "#B1D094";
    public string OnTertiaryFixedVariant => "#344E1F";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F8F4DD";
    public string SurfaceContainer => "#F2EFD8";
    public string SurfaceContainerHigh => "#ECE9D2";
    public string SurfaceContainerHighest => "#E6E3CD";
}
