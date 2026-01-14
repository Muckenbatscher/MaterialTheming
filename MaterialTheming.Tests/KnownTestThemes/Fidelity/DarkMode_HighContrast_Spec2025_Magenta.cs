using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class DarkMode_HighContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Fidelity;
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
    public string SecondaryContainer => "#FBABD2";
    public string OnSecondaryContainer => "#1F0013";
    // Tertiary
    public string Tertiary => "#CBFFA7";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#82D84F";
    public string OnTertiaryContainer => "#030E00";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#1B1015";
    public string SurfaceVariant => "#55414A";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#1B1015";
    public string SurfaceBright => "#5A4C52";
    public string SurfaceTint => "#FFAFD6";
    // Background
    public string Background => "#1B1015";
    public string OnBackground => "#F2DDE4";
    // Outline
    public string Outline => "#FFEBF2";
    public string OutlineVariant => "#D7BBC6";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F2DDE4";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#8B0461";
    // Primary Fixed
    public string PrimaryFixed => "#FFD8E8";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#FFAFD6";
    public string OnPrimaryFixedVariant => "#2A001A";
    // Secondary Fixed
    public string SecondaryFixed => "#FFD8E8";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#FFAFD6";
    public string OnSecondaryFixedVariant => "#2A001A";
    // Tertiary Fixed
    public string TertiaryFixed => "#A1F96B";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#86DC52";
    public string OnTertiaryFixedVariant => "#051500";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#281C22";
    public string SurfaceContainer => "#392D32";
    public string SurfaceContainerHigh => "#45383D";
    public string SurfaceContainerHighest => "#514349";
}
