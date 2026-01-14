using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_MediumContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#3B3341";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#736A79";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#39343D";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#716B74";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#3C3245";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#75697E";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FDF8FA";
    public string SurfaceVariant => "#E6E1E3";
    public string OnSurface => "#121112";
    public string OnSurfaceVariant => "#373637";
    public string SurfaceDim => "#CAC5C7";
    public string SurfaceBright => "#FDF8FA";
    public string SurfaceTint => "#645B6A";
    // Background
    public string Background => "#FDF8FA";
    public string OnBackground => "#1C1B1D";
    // Outline
    public string Outline => "#545253";
    public string OutlineVariant => "#6F6C6E";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#323031";
    public string InverseOnSurface => "#F5EFF1";
    public string InversePrimary => "#CEC2D4";
    // Primary Fixed
    public string PrimaryFixed => "#736A79";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#5A5260";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#716B74";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#59535C";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#75697E";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#5C5065";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F8F2F4";
    public string SurfaceContainer => "#ECE7E9";
    public string SurfaceContainerHigh => "#E0DBDD";
    public string SurfaceContainerHighest => "#D5D0D2";
}
