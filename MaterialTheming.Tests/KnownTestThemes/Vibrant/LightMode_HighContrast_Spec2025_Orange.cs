using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_HighContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#381600";
    public string OnPrimary => "#FFC9AB";
    public string PrimaryContainer => "#813B00";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#331900";
    public string OnSecondary => "#FFCA9F";
    public string SecondaryContainer => "#784100";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#2B1D00";
    public string OnTertiary => "#FFCE63";
    public string TertiaryContainer => "#664A00";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#440800";
    public string OnError => "#FFC8BB";
    public string ErrorContainer => "#991F00";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF4EF";
    public string SurfaceVariant => "#FFD5B4";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#331900";
    public string SurfaceDim => "#FFCA9F";
    public string SurfaceBright => "#FFF4EF";
    public string SurfaceTint => "#381600";
    // Background
    public string Background => "#FFF4EF";
    public string OnBackground => "#000000";
    // Outline
    public string Outline => "#5C3611";
    public string OutlineVariant => "#6E451F";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#1B0A00";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#FFB486";
    // Primary Fixed
    public string PrimaryFixed => "#813B00";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#6F3200";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#784100";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#673700";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#664A00";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#573F00";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFEEE2";
    public string SurfaceContainer => "#FFE3CF";
    public string SurfaceContainerHigh => "#FFDCC1";
    public string SurfaceContainerHighest => "#FFD5B4";
}
