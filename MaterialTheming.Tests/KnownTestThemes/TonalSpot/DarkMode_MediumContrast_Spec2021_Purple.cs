using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_MediumContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#ECD3FF";
    public string OnPrimary => "#33184D";
    public string PrimaryContainer => "#A384C0";
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
    public string Surface => "#151218";
    public string SurfaceVariant => "#4A454E";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E3D9E4";
    public string SurfaceDim => "#151218";
    public string SurfaceBright => "#474349";
    public string SurfaceTint => "#DBB9F9";
    // Background
    public string Background => "#151218";
    public string OnBackground => "#E8E0E8";
    // Outline
    public string Outline => "#B7AFBA";
    public string OutlineVariant => "#958E98";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E8E0E8";
    public string InverseOnSurface => "#2C292E";
    public string InversePrimary => "#573C72";
    // Primary Fixed
    public string PrimaryFixed => "#F0DBFF";
    public string OnPrimaryFixed => "#1D0137";
    public string PrimaryFixedDim => "#DBB9F9";
    public string OnPrimaryFixedVariant => "#442A5F";
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
    public string SurfaceContainerLowest => "#09060B";
    public string SurfaceContainerLow => "#201C22";
    public string SurfaceContainer => "#2A272C";
    public string SurfaceContainerHigh => "#353137";
    public string SurfaceContainerHighest => "#403C42";
}
