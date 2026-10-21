namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_MediumContrast_Spec2026_Watch_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FEFFFF";
    public string OnPrimary => "#00181C";
    public string PrimaryContainer => "#0093A4";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FEFFFF";
    public string OnSecondary => "#002127";
    public string SecondaryContainer => "#3D90A1";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFEFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#71A5F1";
    public string OnTertiaryContainer => "#001835";
    // Error
    public string Error => "#FFBEB9";
    public string OnError => "#3D0004";
    public string ErrorContainer => "#CE6762";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#002A31";
    public string OnSurface => "#FEFFFF";
    public string OnSurfaceVariant => "#B1D4DC";
    public string SurfaceDim => "#001115";
    public string SurfaceBright => "#003139";
    public string SurfaceTint => "#FEFFFF";
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
    public string InverseOnSurface => "#1B3D44";
    public string InversePrimary => "#003F47";
    // Primary Fixed
    public string PrimaryFixed => "#65E9FE";
    public string OnPrimaryFixed => "#00181C";
    public string PrimaryFixedDim => "#53DAEF";
    public string OnPrimaryFixedVariant => "#003E46";
    // Secondary Fixed
    public string SecondaryFixed => "#9CECFE";
    public string OnSecondaryFixed => "#002127";
    public string SecondaryFixedDim => "#8EDEEF";
    public string OnSecondaryFixedVariant => "#00444F";
    // Tertiary Fixed
    public string TertiaryFixed => "#B5D0FF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#7FB2FF";
    public string OnTertiaryFixedVariant => "#00254D";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#042A31";
    public string SurfaceContainer => "#12353C";
    public string SurfaceContainerHigh => "#1F4047";
    public string SurfaceContainerHighest => "#002A31";
}
