using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_NormalContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#006571";
    public string OnPrimary => "#D8F9FF";
    public string PrimaryContainer => "#00E3FC";
    public string OnPrimaryContainer => "#004D57";
    // Secondary
    public string Secondary => "#006479";
    public string OnSecondary => "#E0F6FF";
    public string SecondaryContainer => "#76DFFF";
    public string OnSecondaryContainer => "#004E5F";
    // Tertiary
    public string Tertiary => "#005BAD";
    public string OnTertiary => "#EEF2FF";
    public string TertiaryContainer => "#7FB2FF";
    public string OnTertiaryContainer => "#003061";
    // Error
    public string Error => "#B31B25";
    public string OnError => "#FFEFEE";
    public string ErrorContainer => "#FB5151";
    public string OnErrorContainer => "#570008";
    // Surface
    public string Surface => "#EAF9FF";
    public string SurfaceVariant => "#A0E7FF";
    public string OnSurface => "#003440";
    public string OnSurfaceVariant => "#2D6272";
    public string SurfaceDim => "#8EE0FA";
    public string SurfaceBright => "#EAF9FF";
    public string SurfaceTint => "#006571";
    // Background
    public string Background => "#EAF9FF";
    public string OnBackground => "#003440";
    // Outline
    public string Outline => "#4B7E8E";
    public string OutlineVariant => "#81B5C6";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#001016";
    public string InverseOnSurface => "#71A4B5";
    public string InversePrimary => "#00E3FC";
    // Primary Fixed
    public string PrimaryFixed => "#00E3FC";
    public string OnPrimaryFixed => "#00383F";
    public string PrimaryFixedDim => "#00D4EC";
    public string OnPrimaryFixedVariant => "#005762";
    // Secondary Fixed
    public string SecondaryFixed => "#76DFFF";
    public string OnSecondaryFixed => "#003A47";
    public string SecondaryFixedDim => "#00D5FF";
    public string OnSecondaryFixedVariant => "#00586B";
    // Tertiary Fixed
    public string TertiaryFixed => "#7FB2FF";
    public string OnTertiaryFixed => "#001835";
    public string TertiaryFixedDim => "#64A4FF";
    public string OnTertiaryFixedVariant => "#003970";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#DBF5FF";
    public string SurfaceContainer => "#C3EFFF";
    public string SurfaceContainerHigh => "#B2EBFF";
    public string SurfaceContainerHighest => "#A0E7FF";
}
