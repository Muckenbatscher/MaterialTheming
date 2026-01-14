using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class DarkMode_MediumContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#7CECFF";
    public string OnPrimary => "#002A30";
    public string PrimaryContainer => "#00BCD1";
    public string OnPrimaryContainer => "#00242A";
    // Secondary
    public string Secondary => "#B5E4EE";
    public string OnSecondary => "#002A30";
    public string SecondaryContainer => "#6A98A1";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFD4B6";
    public string OnTertiary => "#3E1D00";
    public string TertiaryContainer => "#F39445";
    public string OnTertiaryContainer => "#371800";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#0E1416";
    public string SurfaceVariant => "#3C494B";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#D1DFE2";
    public string SurfaceDim => "#0E1416";
    public string SurfaceBright => "#3F4647";
    public string SurfaceTint => "#45D8EE";
    // Background
    public string Background => "#0E1416";
    public string OnBackground => "#DDE4E5";
    // Outline
    public string Outline => "#A7B4B7";
    public string OutlineVariant => "#859395";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#DDE4E5";
    public string InverseOnSurface => "#252B2C";
    public string InversePrimary => "#00505A";
    // Primary Fixed
    public string PrimaryFixed => "#9AF0FF";
    public string OnPrimaryFixed => "#001417";
    public string PrimaryFixedDim => "#45D8EE";
    public string OnPrimaryFixedVariant => "#003C44";
    // Secondary Fixed
    public string SecondaryFixed => "#BBEBF4";
    public string OnSecondaryFixed => "#001417";
    public string SecondaryFixedDim => "#9FCED7";
    public string OnSecondaryFixedVariant => "#043C44";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFDCC4";
    public string OnTertiaryFixed => "#200C00";
    public string TertiaryFixedDim => "#FFB781";
    public string OnTertiaryFixedVariant => "#572A00";
    // Surface Container
    public string SurfaceContainerLowest => "#040809";
    public string SurfaceContainerLow => "#181F20";
    public string SurfaceContainer => "#23292A";
    public string SurfaceContainerHigh => "#2D3435";
    public string SurfaceContainerHighest => "#383F40";
}
