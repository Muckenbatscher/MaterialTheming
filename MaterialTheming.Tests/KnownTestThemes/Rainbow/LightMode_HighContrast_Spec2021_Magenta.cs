using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class LightMode_HighContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#560B3B";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#7A2C5A";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#3C2630";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#5B424E";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#45240D";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#674027";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F9F9F9";
    public string SurfaceVariant => "#E2E2E2";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#B9B9B9";
    public string SurfaceBright => "#F9F9F9";
    public string SurfaceTint => "#944170";
    // Background
    public string Background => "#F9F9F9";
    public string OnBackground => "#1B1B1B";
    // Outline
    public string Outline => "#2C2C2C";
    public string OutlineVariant => "#494949";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#303030";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#FFAFD6";
    // Primary Fixed
    public string PrimaryFixed => "#7A2C5A";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#5E1342";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#5B424E";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#432C37";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#674027";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#4D2A13";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F1F1F1";
    public string SurfaceContainer => "#E2E2E2";
    public string SurfaceContainerHigh => "#D4D4D4";
    public string SurfaceContainerHighest => "#C6C6C6";
}
