using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_HighContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#CEF7FF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#7ECFDD";
    public string OnPrimaryContainer => "#000E10";
    // Secondary
    public string Secondary => "#DAF5FA";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#ADC7CC";
    public string OnSecondaryContainer => "#000E10";
    // Tertiary
    public string Tertiary => "#EDEFFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#B7C2E6";
    public string OnTertiaryContainer => "#000926";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#0E1416";
    public string SurfaceVariant => "#3F484A";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#0E1416";
    public string SurfaceBright => "#4B5152";
    public string SurfaceTint => "#82D3E1";
    // Background
    public string Background => "#0E1416";
    public string OnBackground => "#DEE3E5";
    // Outline
    public string Outline => "#E8F2F4";
    public string OutlineVariant => "#BBC4C6";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#DEE3E5";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#00505A";
    // Primary Fixed
    public string PrimaryFixed => "#9EEFFE";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#82D3E1";
    public string OnPrimaryFixedVariant => "#001417";
    // Secondary Fixed
    public string SecondaryFixed => "#CDE7EC";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#B1CBD0";
    public string OnSecondaryFixedVariant => "#001417";
    // Tertiary Fixed
    public string TertiaryFixed => "#DAE2FF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#BBC6EA";
    public string OnTertiaryFixedVariant => "#04102C";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1B2122";
    public string SurfaceContainer => "#2B3133";
    public string SurfaceContainerHigh => "#363C3E";
    public string SurfaceContainerHighest => "#424849";
}
