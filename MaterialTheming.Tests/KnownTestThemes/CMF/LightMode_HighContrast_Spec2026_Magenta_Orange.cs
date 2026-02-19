namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class LightMode_HighContrast_Spec2026_Magenta_Orange : ITestThemeSecondSourceColor
{
    public string SourceColor => "#E85DAE"; //Magenta
    public string SecondSourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#4B0033";
    public string OnPrimary => "#FFCCE3";
    public string PrimaryContainer => "#99176C";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#42112E";
    public string OnSecondary => "#FFCCE3";
    public string SecondaryContainer => "#793F5E";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#3F1900";
    public string OnTertiary => "#FFD1B7";
    public string TertiaryContainer => "#863D00";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#510005";
    public string OnError => "#FFCFCA";
    public string ErrorContainer => "#9E2022";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F8";
    public string SurfaceVariant => "#FFD8E8";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#39192A";
    public string SurfaceDim => "#FFCCE3";
    public string SurfaceBright => "#FFF8F8";
    public string SurfaceTint => "#4B0033";
    // Background
    public string Background => "#FFF8F8";
    public string OnBackground => "#000000";
    // Outline
    public string Outline => "#5C384A";
    public string OutlineVariant => "#6D475A";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#1F0414";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#FFACD5";
    // Primary Fixed
    public string PrimaryFixed => "#99176C";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#890160";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#793F5E";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#6B3452";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#863D00";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#743400";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0F4";
    public string SurfaceContainer => "#FFE8F0";
    public string SurfaceContainerHigh => "#FFE0EC";
    public string SurfaceContainerHighest => "#FFD8E8";
}
