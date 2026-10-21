namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_NormalContrast_Spec2025_Watch_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFC29E";
    public string OnPrimary => "#4F2100";
    public string PrimaryContainer => "#723608";
    public string OnPrimaryContainer => "#FFD8C3";
    // Secondary
    public string Secondary => "#C0E9FB";
    public string OnSecondary => "#1B4453";
    public string SecondaryContainer => "#244C5A";
    public string OnSecondaryContainer => "#BEE6F8";
    // Tertiary
    public string Tertiary => "#AAD3FF";
    public string OnTertiary => "#002C4A";
    public string TertiaryContainer => "#65AEF2";
    public string OnTertiaryContainer => "#001F37";
    // Error
    public string Error => "#FFBFB0";
    public string OnError => "#3B0600";
    public string ErrorContainer => "#7D2C19";
    public string OnErrorContainer => "#FFD7CE";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#391F0E";
    public string OnSurface => "#FFE2D4";
    public string OnSurfaceVariant => "#E6C8B8";
    public string SurfaceDim => "#190B04";
    public string SurfaceBright => "#422511";
    public string SurfaceTint => "#FFC29E";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#BCA091";
    public string OutlineVariant => "#9A8072";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F5";
    public string InverseOnSurface => "#665044";
    public string InversePrimary => "#844416";
    // Primary Fixed
    public string PrimaryFixed => "#FFC29E";
    public string OnPrimaryFixed => "#4F2100";
    public string PrimaryFixedDim => "#FEA771";
    public string OnPrimaryFixedVariant => "#723608";
    // Secondary Fixed
    public string SecondaryFixed => "#C0E9FB";
    public string OnSecondaryFixed => "#1B4453";
    public string SecondaryFixedDim => "#B2DBEC";
    public string OnSecondaryFixedVariant => "#244C5A";
    // Tertiary Fixed
    public string TertiaryFixed => "#AAD3FF";
    public string OnTertiaryFixed => "#002C4A";
    public string TertiaryFixedDim => "#74BBFF";
    public string OnTertiaryFixedVariant => "#004A78";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#332218";
    public string SurfaceContainer => "#3F2C21";
    public string SurfaceContainerHigh => "#4B372C";
    public string SurfaceContainerHighest => "#391F0E";
}
