namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_HighContrast_Spec2025_Watch_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFFFFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#15B6CA";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFFFF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#61B1C2";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFFFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#74A7F4";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFBEB9";
    public string OnError => "#000000";
    public string ErrorContainer => "#F58680";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#002A31";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FEFFFF";
    public string SurfaceDim => "#001115";
    public string SurfaceBright => "#003139";
    public string SurfaceTint => "#FFFFFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#B1D4DC";
    public string OutlineVariant => "#8AABB3";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#EFFCFF";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#000000";
    // Primary Fixed
    public string PrimaryFixed => "#65E9FE";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#53DAEF";
    public string OnPrimaryFixedVariant => "#00181C";
    // Secondary Fixed
    public string SecondaryFixed => "#9CECFE";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#8EDEEF";
    public string OnSecondaryFixedVariant => "#002127";
    // Tertiary Fixed
    public string TertiaryFixed => "#B5D0FF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#7FB2FF";
    public string OnTertiaryFixedVariant => "#000000";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#042A31";
    public string SurfaceContainer => "#12353C";
    public string SurfaceContainerHigh => "#1F4047";
    public string SurfaceContainerHighest => "#002A31";
}
