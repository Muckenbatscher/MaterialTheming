namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_MediumContrast_Spec2026_Watch_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFFEFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#9D73C8";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFEFF";
    public string OnSecondary => "#00022F";
    public string SecondaryContainer => "#7B81BC";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFEFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#67AAF0";
    public string OnTertiaryContainer => "#001C35";
    // Error
    public string Error => "#FFBDC3";
    public string OnError => "#3D000F";
    public string ErrorContainer => "#CC6674";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#1F2344";
    public string OnSurface => "#FFFEFF";
    public string OnSurfaceVariant => "#CACCEB";
    public string SurfaceDim => "#090C23";
    public string SurfaceBright => "#25294D";
    public string SurfaceTint => "#FFFEFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#A2A3C2";
    public string OutlineVariant => "#8284A0";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FBF8FF";
    public string InverseOnSurface => "#34364F";
    public string InversePrimary => "#4B2373";
    // Primary Fixed
    public string PrimaryFixed => "#E2C2FF";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#D3A6FF";
    public string OnPrimaryFixedVariant => "#3F1466";
    // Secondary Fixed
    public string SecondaryFixed => "#C7CBFF";
    public string OnSecondaryFixed => "#00022F";
    public string SecondaryFixedDim => "#B7BCFC";
    public string OnSecondaryFixedVariant => "#272D63";
    // Tertiary Fixed
    public string TertiaryFixed => "#ADD2FF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#75B8FF";
    public string OnTertiaryFixedVariant => "#002949";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#21243C";
    public string SurfaceContainer => "#2C2F47";
    public string SurfaceContainerHigh => "#373A53";
    public string SurfaceContainerHighest => "#1F2344";
}
