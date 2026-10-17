namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_MediumContrast_Spec2026_Watch_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFFEFF";
    public string OnPrimary => "#140500";
    public string PrimaryContainer => "#B57750";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFEFF";
    public string OnSecondary => "#2A1508";
    public string SecondaryContainer => "#A07F6C";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFEFF";
    public string OnTertiary => "#221500";
    public string TertiaryContainer => "#E0B870";
    public string OnTertiaryContainer => "#412D00";
    // Error
    public string Error => "#FFBFB0";
    public string OnError => "#390600";
    public string ErrorContainer => "#CD6951";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#382011";
    public string OnSurface => "#FFFEFF";
    public string OnSurfaceVariant => "#E2C9BC";
    public string SurfaceDim => "#170B05";
    public string SurfaceBright => "#3F2617";
    public string SurfaceTint => "#FFFEFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#B8A195";
    public string OutlineVariant => "#978176";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F5";
    public string InverseOnSurface => "#45352B";
    public string InversePrimary => "#5A2C0B";
    // Primary Fixed
    public string PrimaryFixed => "#FFC29E";
    public string OnPrimaryFixed => "#140500";
    public string PrimaryFixedDim => "#F9B186";
    public string OnPrimaryFixedVariant => "#522606";
    // Secondary Fixed
    public string SecondaryFixed => "#FDD5BF";
    public string OnSecondaryFixed => "#2A1508";
    public string SecondaryFixedDim => "#EEC7B1";
    public string OnSecondaryFixedVariant => "#4F3627";
    // Tertiary Fixed
    public string TertiaryFixed => "#FED489";
    public string OnTertiaryFixed => "#221500";
    public string TertiaryFixedDim => "#EFC67C";
    public string OnTertiaryFixedVariant => "#4D3600";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#31231A";
    public string SurfaceContainer => "#3D2D24";
    public string SurfaceContainerHigh => "#48382E";
    public string SurfaceContainerHighest => "#382011";
}
