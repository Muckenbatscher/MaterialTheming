using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_NormalContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#7FEDFF";
    public string OnPrimary => "#005761";
    public string PrimaryContainer => "#00E3FC";
    public string OnPrimaryContainer => "#004D57";
    // Secondary
    public string Secondary => "#00D5FF";
    public string OnSecondary => "#004554";
    public string SecondaryContainer => "#00677D";
    public string OnSecondaryContainer => "#EDFAFF";
    // Tertiary
    public string Tertiary => "#7AAFFF";
    public string OnTertiary => "#002E5D";
    public string TertiaryContainer => "#5EA2FF";
    public string OnTertiaryContainer => "#002348";
    // Error
    public string Error => "#FF716C";
    public string OnError => "#490006";
    public string ErrorContainer => "#9F0519";
    public string OnErrorContainer => "#FFA8A3";
    // Surface
    public string Surface => "#001016";
    public string SurfaceVariant => "#002A34";
    public string OnSurface => "#BBEDFF";
    public string OnSurfaceVariant => "#7FB3C4";
    public string SurfaceDim => "#001016";
    public string SurfaceBright => "#00313C";
    public string SurfaceTint => "#7FEDFF";
    // Background
    public string Background => "#001016";
    public string OnBackground => "#BBEDFF";
    // Outline
    public string Outline => "#497D8D";
    public string OutlineVariant => "#144E5D";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F2FBFF";
    public string InverseOnSurface => "#265C6B";
    public string InversePrimary => "#006975";
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
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#00161D";
    public string SurfaceContainer => "#001D25";
    public string SurfaceContainerHigh => "#00232C";
    public string SurfaceContainerHighest => "#002A34";
}
