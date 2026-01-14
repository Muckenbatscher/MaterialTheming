using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class DarkMode_HighContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFEBF2";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#FFA9D4";
    public string OnPrimaryContainer => "#1F0013";
    // Secondary
    public string Secondary => "#FFEBF2";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#DBBAC8";
    public string OnSecondaryContainer => "#17060F";
    // Tertiary
    public string Tertiary => "#FFECE3";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#EEB797";
    public string OnTertiaryContainer => "#190600";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#131313";
    public string SurfaceVariant => "#474747";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#131313";
    public string SurfaceBright => "#505050";
    public string SurfaceTint => "#FFAFD6";
    // Background
    public string Background => "#131313";
    public string OnBackground => "#E2E2E2";
    // Outline
    public string Outline => "#F0F0F0";
    public string OutlineVariant => "#C2C2C2";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E2E2E2";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#792B58";
    // Primary Fixed
    public string PrimaryFixed => "#FFD8E8";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#FFAFD6";
    public string OnPrimaryFixedVariant => "#2A001A";
    // Secondary Fixed
    public string SecondaryFixed => "#FDD9E8";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#E0BDCC";
    public string OnSecondaryFixedVariant => "#1E0B15";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFDBC8";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#F3BB9A";
    public string OnTertiaryFixedVariant => "#220A00";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1F1F1F";
    public string SurfaceContainer => "#303030";
    public string SurfaceContainerHigh => "#3B3B3B";
    public string SurfaceContainerHighest => "#474747";
}
