namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class LightMode_NormalContrast_Spec2026_Watch_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Content;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFBFB8";
    public string OnPrimary => "#400002";
    public string PrimaryContainer => "#8E1313";
    public string OnPrimaryContainer => "#FFD7D2";
    // Secondary
    public string Secondary => "#FFBFB8";
    public string OnSecondary => "#561E1A";
    public string SecondaryContainer => "#72342E";
    public string OnSecondaryContainer => "#FFD7D2";
    // Tertiary
    public string Tertiary => "#FFBCD8";
    public string OnTertiary => "#3C0024";
    public string TertiaryContainer => "#F564B0";
    public string OnTertiaryContainer => "#15000A";
    // Error
    public string Error => "#FFBDC3";
    public string OnError => "#3F000F";
    public string ErrorContainer => "#8F0930";
    public string OnErrorContainer => "#FFD6D9";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#3C1D1A";
    public string OnSurface => "#FFE1DE";
    public string OnSurfaceVariant => "#F6C2BB";
    public string SurfaceDim => "#1F0605";
    public string SurfaceBright => "#432320";
    public string SurfaceTint => "#FFBFB8";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#CB9A94";
    public string OutlineVariant => "#A87B75";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F7";
    public string InverseOnSurface => "#724B47";
    public string InversePrimary => "#A3231F";
    // Primary Fixed
    public string PrimaryFixed => "#FFBFB8";
    public string OnPrimaryFixed => "#400002";
    public string PrimaryFixedDim => "#FF8074";
    public string OnPrimaryFixedVariant => "#7D0209";
    // Secondary Fixed
    public string SecondaryFixed => "#FFBFB8";
    public string OnSecondaryFixed => "#561E1A";
    public string SecondaryFixedDim => "#FFA89E";
    public string OnSecondaryFixedVariant => "#72342E";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFBCD8";
    public string OnTertiaryFixed => "#3C0024";
    public string TertiaryFixedDim => "#FF77BC";
    public string OnTertiaryFixedVariant => "#77004C";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#3C1D1A";
    public string SurfaceContainer => "#482724";
    public string SurfaceContainerHigh => "#55322E";
    public string SurfaceContainerHighest => "#3C1D1A";
}
