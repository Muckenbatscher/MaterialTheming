using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_MediumContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#383724";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#6F6E58";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#37372A";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#6F6E5F";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#38371D";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#706E50";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FDF9F4";
    public string SurfaceVariant => "#E6E2DD";
    public string OnSurface => "#12110F";
    public string OnSurfaceVariant => "#373633";
    public string SurfaceDim => "#C9C6C2";
    public string SurfaceBright => "#FDF9F4";
    public string SurfaceTint => "#615F4A";
    // Background
    public string Background => "#FDF9F4";
    public string OnBackground => "#1C1C19";
    // Outline
    public string Outline => "#54524F";
    public string OutlineVariant => "#6F6D69";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#31302D";
    public string InverseOnSurface => "#F4F0EB";
    public string InversePrimary => "#CAC7AD";
    // Primary Fixed
    public string PrimaryFixed => "#6F6E58";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#575641";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#6F6E5F";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#575548";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#706E50";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#57563A";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F7F3EE";
    public string SurfaceContainer => "#EBE7E3";
    public string SurfaceContainerHigh => "#E0DCD8";
    public string SurfaceContainerHighest => "#D5D1CD";
}
