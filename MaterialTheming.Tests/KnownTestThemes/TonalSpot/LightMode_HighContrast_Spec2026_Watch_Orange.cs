namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_HighContrast_Spec2026_Watch_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFFFFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#DA966D";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFFFF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#C29E8A";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFFFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#E0B870";
    public string OnTertiaryContainer => "#060300";
    // Error
    public string Error => "#FFBFB0";
    public string OnError => "#000000";
    public string ErrorContainer => "#F4886D";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#382011";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFEFF";
    public string SurfaceDim => "#170B05";
    public string SurfaceBright => "#3F2617";
    public string SurfaceTint => "#FFFFFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#E2C9BC";
    public string OutlineVariant => "#B8A195";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F5";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#000000";
    // Primary Fixed
    public string PrimaryFixed => "#FFC29E";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#F9B186";
    public string OnPrimaryFixedVariant => "#140500";
    // Secondary Fixed
    public string SecondaryFixed => "#FDD5BF";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#EEC7B1";
    public string OnSecondaryFixedVariant => "#2A1508";
    // Tertiary Fixed
    public string TertiaryFixed => "#FED489";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#EFC67C";
    public string OnTertiaryFixedVariant => "#221500";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#31231A";
    public string SurfaceContainer => "#3D2D24";
    public string SurfaceContainerHigh => "#48382E";
    public string SurfaceContainerHighest => "#382011";
}
