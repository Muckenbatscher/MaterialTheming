namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_NormalContrast_Spec2026_Watch_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#E2C2FF";
    public string OnPrimary => "#3F1466";
    public string PrimaryContainer => "#5B3383";
    public string OnPrimaryContainer => "#EED8FF";
    // Secondary
    public string Secondary => "#C7CBFF";
    public string OnSecondary => "#272D63";
    public string SecondaryContainer => "#3C4279";
    public string OnSecondaryContainer => "#DCDEFF";
    // Tertiary
    public string Tertiary => "#ADD2FF";
    public string OnTertiary => "#002949";
    public string TertiaryContainer => "#67AAF0";
    public string OnTertiaryContainer => "#001C35";
    // Error
    public string Error => "#FFBDC3";
    public string OnError => "#3F000F";
    public string ErrorContainer => "#7D2938";
    public string OnErrorContainer => "#FFD6D9";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#1F2344";
    public string OnSurface => "#E6E6FF";
    public string OnSurfaceVariant => "#CACCEB";
    public string SurfaceDim => "#090C23";
    public string SurfaceBright => "#25294D";
    public string SurfaceTint => "#E2C2FF";
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
    public string InverseOnSurface => "#51536E";
    public string InversePrimary => "#6A4293";
    // Primary Fixed
    public string PrimaryFixed => "#E2C2FF";
    public string OnPrimaryFixed => "#3F1466";
    public string PrimaryFixedDim => "#D3A6FF";
    public string OnPrimaryFixedVariant => "#5B3383";
    // Secondary Fixed
    public string SecondaryFixed => "#C7CBFF";
    public string OnSecondaryFixed => "#272D63";
    public string SecondaryFixedDim => "#B7BCFC";
    public string OnSecondaryFixedVariant => "#3C4279";
    // Tertiary Fixed
    public string TertiaryFixed => "#ADD2FF";
    public string OnTertiaryFixed => "#002949";
    public string TertiaryFixedDim => "#75B8FF";
    public string OnTertiaryFixedVariant => "#00487A";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#21243C";
    public string SurfaceContainer => "#2C2F47";
    public string SurfaceContainerHigh => "#373A53";
    public string SurfaceContainerHighest => "#1F2344";
}
