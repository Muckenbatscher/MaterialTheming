using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_MediumContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#F6D5D1";
    public string OnPrimary => "#34211F";
    public string PrimaryContainer => "#A78A87";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#EED7D4";
    public string OnSecondary => "#302221";
    public string SecondaryContainer => "#A08C8A";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FED2CD";
    public string OnTertiary => "#381F1C";
    public string TertiaryContainer => "#AD8883";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#161312";
    public string SurfaceVariant => "#4A4645";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E3DBD9";
    public string SurfaceDim => "#161312";
    public string SurfaceBright => "#484343";
    public string SurfaceTint => "#DFBFBB";
    // Background
    public string Background => "#161312";
    public string OnBackground => "#E9E1DF";
    // Outline
    public string Outline => "#B7B0AF";
    public string OutlineVariant => "#958F8E";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E9E1DF";
    public string InverseOnSurface => "#2D2929";
    public string InversePrimary => "#594240";
    // Primary Fixed
    public string PrimaryFixed => "#FDDBD7";
    public string OnPrimaryFixed => "#1D0D0B";
    public string PrimaryFixedDim => "#DFBFBB";
    public string OnPrimaryFixedVariant => "#46312E";
    // Secondary Fixed
    public string SecondaryFixed => "#F5DDDA";
    public string OnSecondaryFixed => "#190E0D";
    public string SecondaryFixedDim => "#D8C2BF";
    public string OnSecondaryFixedVariant => "#413331";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFDAD6";
    public string OnTertiaryFixed => "#200B09";
    public string TertiaryFixedDim => "#E7BDB8";
    public string OnTertiaryFixedVariant => "#4B2F2C";
    // Surface Container
    public string SurfaceContainerLowest => "#090707";
    public string SurfaceContainerLow => "#201D1C";
    public string SurfaceContainer => "#2B2726";
    public string SurfaceContainerHigh => "#363231";
    public string SurfaceContainerHighest => "#413D3C";
}
