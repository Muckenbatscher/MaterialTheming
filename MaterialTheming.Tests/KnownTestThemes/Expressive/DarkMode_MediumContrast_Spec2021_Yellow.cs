using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_MediumContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FFCFE4";
    public string OnPrimary => "#480E31";
    public string PrimaryContainer => "#C679A0";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#C0E6C6";
    public string OnSecondary => "#0B2C17";
    public string SecondaryContainer => "#76997D";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#CCE5A3";
    public string OnTertiary => "#192A00";
    public string TertiaryContainer => "#81995E";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#12140B";
    public string SurfaceVariant => "#444937";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#DADFC6";
    public string SurfaceDim => "#12140B";
    public string SurfaceBright => "#43463A";
    public string SurfaceTint => "#FFAFD6";
    // Background
    public string Background => "#12140B";
    public string OnBackground => "#E2E4D4";
    // Outline
    public string Outline => "#B0B49D";
    public string OutlineVariant => "#8E937D";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E2E4D4";
    public string InverseOnSurface => "#292B21";
    public string InversePrimary => "#723255";
    // Primary Fixed
    public string PrimaryFixed => "#FFD8E8";
    public string OnPrimaryFixed => "#2A001A";
    public string PrimaryFixedDim => "#FFAFD6";
    public string OnPrimaryFixedVariant => "#5C2043";
    // Secondary Fixed
    public string SecondaryFixed => "#C6ECCC";
    public string OnSecondaryFixed => "#001507";
    public string SecondaryFixedDim => "#ABD0B1";
    public string OnSecondaryFixedVariant => "#1D3D26";
    // Tertiary Fixed
    public string TertiaryFixed => "#D2ECA9";
    public string OnTertiaryFixed => "#0A1400";
    public string TertiaryFixedDim => "#B6CF8F";
    public string OnTertiaryFixedVariant => "#293C0B";
    // Surface Container
    public string SurfaceContainerLowest => "#060802";
    public string SurfaceContainerLow => "#1C1F15";
    public string SurfaceContainer => "#26291F";
    public string SurfaceContainerHigh => "#313429";
    public string SurfaceContainerHighest => "#3C3F33";
}
