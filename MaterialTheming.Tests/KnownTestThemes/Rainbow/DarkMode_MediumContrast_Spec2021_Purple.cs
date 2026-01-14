using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class DarkMode_MediumContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#ECD3FF";
    public string OnPrimary => "#380B60";
    public string PrimaryContainer => "#A97ED4";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#E6D7F0";
    public string OnSecondary => "#2B2234";
    public string SecondaryContainer => "#998CA3";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFD1D6";
    public string OnTertiary => "#3F1A20";
    public string TertiaryContainer => "#B88389";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#131313";
    public string SurfaceVariant => "#474747";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#DCDCDC";
    public string SurfaceDim => "#131313";
    public string SurfaceBright => "#444444";
    public string SurfaceTint => "#DCB8FF";
    // Background
    public string Background => "#131313";
    public string OnBackground => "#E2E2E2";
    // Outline
    public string Outline => "#B2B2B2";
    public string OutlineVariant => "#909090";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E2E2E2";
    public string InverseOnSurface => "#2A2A2A";
    public string InversePrimary => "#5C3485";
    // Primary Fixed
    public string PrimaryFixed => "#F0DBFF";
    public string OnPrimaryFixed => "#1D0039";
    public string PrimaryFixedDim => "#DCB8FF";
    public string OnPrimaryFixedVariant => "#492171";
    // Secondary Fixed
    public string SecondaryFixed => "#EDDDF6";
    public string OnSecondaryFixed => "#160D1F";
    public string SecondaryFixedDim => "#D0C1DA";
    public string OnSecondaryFixedVariant => "#3C3245";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFD9DD";
    public string OnTertiaryFixed => "#25060C";
    public string TertiaryFixedDim => "#F3B7BE";
    public string OnTertiaryFixedVariant => "#522A30";
    // Surface Container
    public string SurfaceContainerLowest => "#070707";
    public string SurfaceContainerLow => "#1D1D1D";
    public string SurfaceContainer => "#282828";
    public string SurfaceContainerHigh => "#323232";
    public string SurfaceContainerHighest => "#3E3E3E";
}
