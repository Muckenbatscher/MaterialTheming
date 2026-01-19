namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_HighContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#4B2000";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#783600";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#412605";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#634220";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#3D2800";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#614404";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F5";
    public string SurfaceVariant => "#FBDCCC";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#CCB4A7";
    public string SurfaceBright => "#FFF8F5";
    public string SurfaceTint => "#994700";
    // Background
    public string Background => "#FFF8F5";
    public string OnBackground => "#261910";
    // Outline
    public string Outline => "#3A281D";
    public string OutlineVariant => "#5A4539";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#3D2D24";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#FFB68B";
    // Primary Fixed
    public string PrimaryFixed => "#783600";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#552500";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#634220";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#492C0B";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#614404";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#452E00";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFEDE5";
    public string SurfaceContainer => "#F8DDD0";
    public string SurfaceContainerHigh => "#E9CFC2";
    public string SurfaceContainerHighest => "#DBC2B4";
}
