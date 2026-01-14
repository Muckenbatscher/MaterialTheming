using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class DarkMode_MediumContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#CBDDFF";
    public string OnPrimary => "#00264C";
    public string PrimaryContainer => "#5892E1";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#CBDDFF";
    public string OnSecondary => "#112642";
    public string SecondaryContainer => "#7E92B3";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#F7CFFF";
    public string OnTertiary => "#420357";
    public string TertiaryContainer => "#B879CC";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#111318";
    public string SurfaceVariant => "#424751";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#D8DCE9";
    public string SurfaceDim => "#111318";
    public string SurfaceBright => "#42444A";
    public string SurfaceTint => "#A6C8FF";
    // Background
    public string Background => "#111318";
    public string OnBackground => "#E1E2E9";
    // Outline
    public string Outline => "#ADB2BE";
    public string OutlineVariant => "#8B909C";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E1E2E9";
    public string InverseOnSurface => "#282A2F";
    public string InversePrimary => "#004889";
    // Primary Fixed
    public string PrimaryFixed => "#D5E3FF";
    public string OnPrimaryFixed => "#001128";
    public string PrimaryFixedDim => "#A6C8FF";
    public string OnPrimaryFixedVariant => "#003669";
    // Secondary Fixed
    public string SecondaryFixed => "#D5E3FF";
    public string OnSecondaryFixed => "#001128";
    public string SecondaryFixedDim => "#B3C7EB";
    public string OnSecondaryFixedVariant => "#233753";
    // Tertiary Fixed
    public string TertiaryFixed => "#FAD7FF";
    public string OnTertiaryFixed => "#230030";
    public string TertiaryFixedDim => "#EEB0FF";
    public string OnTertiaryFixedVariant => "#541B69";
    // Surface Container
    public string SurfaceContainerLowest => "#05070C";
    public string SurfaceContainerLow => "#1B1E23";
    public string SurfaceContainer => "#25282D";
    public string SurfaceContainerHigh => "#303338";
    public string SurfaceContainerHighest => "#3B3E43";
}
