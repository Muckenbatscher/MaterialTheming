using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_MediumContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#E0DDC2";
    public string OnPrimary => "#272615";
    public string PrimaryContainer => "#94927A";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#E0DDCB";
    public string OnSecondary => "#27261B";
    public string SecondaryContainer => "#939181";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#E1DEB9";
    public string OnTertiary => "#27270E";
    public string TertiaryContainer => "#949271";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#141311";
    public string SurfaceVariant => "#484744";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#DFDCD7";
    public string SurfaceDim => "#141311";
    public string SurfaceBright => "#464441";
    public string SurfaceTint => "#CAC7AD";
    // Background
    public string Background => "#141311";
    public string OnBackground => "#E6E2DD";
    // Outline
    public string Outline => "#B4B1AD";
    public string OutlineVariant => "#92908C";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E6E2DD";
    public string InverseOnSurface => "#2B2A27";
    public string InversePrimary => "#4A4935";
    // Primary Fixed
    public string PrimaryFixed => "#E7E3C8";
    public string OnPrimaryFixed => "#121204";
    public string PrimaryFixedDim => "#CAC7AD";
    public string OnPrimaryFixedVariant => "#383724";
    // Secondary Fixed
    public string SecondaryFixed => "#E6E3D1";
    public string OnSecondaryFixed => "#121208";
    public string SecondaryFixedDim => "#CAC7B6";
    public string OnSecondaryFixedVariant => "#37372A";
    // Tertiary Fixed
    public string TertiaryFixed => "#E7E4BF";
    public string OnTertiaryFixed => "#121201";
    public string TertiaryFixedDim => "#CBC8A4";
    public string OnTertiaryFixedVariant => "#38371D";
    // Surface Container
    public string SurfaceContainerLowest => "#080706";
    public string SurfaceContainerLow => "#1E1E1B";
    public string SurfaceContainer => "#292825";
    public string SurfaceContainerHigh => "#333230";
    public string SurfaceContainerHighest => "#3F3D3B";
}
