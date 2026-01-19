namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_MediumContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#7FEDFF";
    public string OnPrimary => "#004C55";
    public string PrimaryContainer => "#00E3FC";
    public string OnPrimaryContainer => "#00434B";
    // Secondary
    public string Secondary => "#00D5FF";
    public string OnSecondary => "#003A47";
    public string SecondaryContainer => "#007F99";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#8EBAFF";
    public string OnTertiary => "#002C59";
    public string TertiaryContainer => "#5EA2FF";
    public string OnTertiaryContainer => "#00142F";
    // Error
    public string Error => "#FF9F99";
    public string OnError => "#60000A";
    public string ErrorContainer => "#D7383B";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#001016";
    public string SurfaceVariant => "#002A34";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#8DC1D2";
    public string SurfaceDim => "#001016";
    public string SurfaceBright => "#00313C";
    public string SurfaceTint => "#7FEDFF";
    // Background
    public string Background => "#001016";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#689BAC";
    public string OutlineVariant => "#497D8D";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F2FBFF";
    public string InverseOnSurface => "#003E4C";
    public string InversePrimary => "#005E69";
    // Primary Fixed
    public string PrimaryFixed => "#00E3FC";
    public string OnPrimaryFixed => "#000A0D";
    public string PrimaryFixedDim => "#00D4EC";
    public string OnPrimaryFixedVariant => "#00383F";
    // Secondary Fixed
    public string SecondaryFixed => "#76DFFF";
    public string OnSecondaryFixed => "#000F15";
    public string SecondaryFixedDim => "#00D5FF";
    public string OnSecondaryFixedVariant => "#003A47";
    // Tertiary Fixed
    public string TertiaryFixed => "#7FB2FF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#64A4FF";
    public string OnTertiaryFixedVariant => "#001835";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#00161D";
    public string SurfaceContainer => "#001D25";
    public string SurfaceContainerHigh => "#00232C";
    public string SurfaceContainerHighest => "#002A34";
}
