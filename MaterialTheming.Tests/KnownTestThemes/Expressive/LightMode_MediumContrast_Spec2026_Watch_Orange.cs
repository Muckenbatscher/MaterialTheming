namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_MediumContrast_Spec2026_Watch_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFFEFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#BF7341";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFEFF";
    public string OnSecondary => "#00232E";
    public string SecondaryContainer => "#658B9B";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFEFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#65AEF2";
    public string OnTertiaryContainer => "#001F37";
    // Error
    public string Error => "#FFBFB0";
    public string OnError => "#390600";
    public string ErrorContainer => "#CD6951";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#391F0E";
    public string OnSurface => "#FFFEFF";
    public string OnSurfaceVariant => "#E6C8B8";
    public string SurfaceDim => "#190B04";
    public string SurfaceBright => "#422511";
    public string SurfaceTint => "#FFFEFF";
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
    public string InverseOnSurface => "#473429";
    public string InversePrimary => "#5E2900";
    // Primary Fixed
    public string PrimaryFixed => "#FFC29E";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#FEA771";
    public string OnPrimaryFixedVariant => "#4F2100";
    // Secondary Fixed
    public string SecondaryFixed => "#C0E9FB";
    public string OnSecondaryFixed => "#00232E";
    public string SecondaryFixedDim => "#B2DBEC";
    public string OnSecondaryFixedVariant => "#1B4453";
    // Tertiary Fixed
    public string TertiaryFixed => "#AAD3FF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#74BBFF";
    public string OnTertiaryFixedVariant => "#002C4A";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#332218";
    public string SurfaceContainer => "#3F2C21";
    public string SurfaceContainerHigh => "#4B372C";
    public string SurfaceContainerHighest => "#391F0E";
}
