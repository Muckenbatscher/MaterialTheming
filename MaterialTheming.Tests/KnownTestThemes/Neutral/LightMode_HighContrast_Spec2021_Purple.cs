using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_HighContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#302937";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#4E4654";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#2F2A33";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#4D4750";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#32283B";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#504559";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FDF8FA";
    public string SurfaceVariant => "#E6E1E3";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#BCB8B9";
    public string SurfaceBright => "#FDF8FA";
    public string SurfaceTint => "#645B6A";
    // Background
    public string Background => "#FDF8FA";
    public string OnBackground => "#1C1B1D";
    // Outline
    public string Outline => "#2D2C2D";
    public string OutlineVariant => "#4B484A";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#323031";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#CEC2D4";
    // Primary Fixed
    public string PrimaryFixed => "#4E4654";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#37303D";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#4D4750";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#363139";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#504559";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#392F42";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F5EFF1";
    public string SurfaceContainer => "#E6E1E3";
    public string SurfaceContainerHigh => "#D8D3D5";
    public string SurfaceContainerHighest => "#CAC5C7";
}
