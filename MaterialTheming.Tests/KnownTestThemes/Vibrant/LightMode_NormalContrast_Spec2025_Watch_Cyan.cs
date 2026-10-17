namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_NormalContrast_Spec2025_Watch_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#65E9FE";
    public string OnPrimary => "#003E46";
    public string PrimaryContainer => "#004F58";
    public string OnPrimaryContainer => "#90EEFF";
    // Secondary
    public string Secondary => "#9CECFE";
    public string OnSecondary => "#00444F";
    public string SecondaryContainer => "#004E5A";
    public string OnSecondaryContainer => "#9DECFE";
    // Tertiary
    public string Tertiary => "#B5D0FF";
    public string OnTertiary => "#00254D";
    public string TertiaryContainer => "#71A5F1";
    public string OnTertiaryContainer => "#001835";
    // Error
    public string Error => "#FFBEB9";
    public string OnError => "#3F0004";
    public string ErrorContainer => "#7E2A29";
    public string OnErrorContainer => "#FFD7D4";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#002A31";
    public string OnSurface => "#CBEEF7";
    public string OnSurfaceVariant => "#B1D4DC";
    public string SurfaceDim => "#001115";
    public string SurfaceBright => "#003139";
    public string SurfaceTint => "#65E9FE";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#8AABB3";
    public string OutlineVariant => "#6A8B93";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#EFFCFF";
    public string InverseOnSurface => "#395A61";
    public string InversePrimary => "#005E69";
    // Primary Fixed
    public string PrimaryFixed => "#65E9FE";
    public string OnPrimaryFixed => "#003E46";
    public string PrimaryFixedDim => "#53DAEF";
    public string OnPrimaryFixedVariant => "#004F58";
    // Secondary Fixed
    public string SecondaryFixed => "#9CECFE";
    public string OnSecondaryFixed => "#00444F";
    public string SecondaryFixedDim => "#8EDEEF";
    public string OnSecondaryFixedVariant => "#004E5A";
    // Tertiary Fixed
    public string TertiaryFixed => "#B5D0FF";
    public string OnTertiaryFixed => "#00254D";
    public string TertiaryFixedDim => "#7FB2FF";
    public string OnTertiaryFixedVariant => "#004382";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#042A31";
    public string SurfaceContainer => "#12353C";
    public string SurfaceContainerHigh => "#1F4047";
    public string SurfaceContainerHighest => "#002A31";
}
