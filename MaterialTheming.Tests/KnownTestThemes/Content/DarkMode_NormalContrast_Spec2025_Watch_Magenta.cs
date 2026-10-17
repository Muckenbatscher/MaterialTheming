namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class DarkMode_NormalContrast_Spec2025_Watch_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Content;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFBCDB";
    public string OnPrimary => "#3B0027";
    public string PrimaryContainer => "#8A0160";
    public string OnPrimaryContainer => "#FFD5E7";
    // Secondary
    public string Secondary => "#FFBCDB";
    public string OnSecondary => "#53203D";
    public string SecondaryContainer => "#6B3452";
    public string OnSecondaryContainer => "#FFD5E7";
    // Tertiary
    public string Tertiary => "#ECBFFF";
    public string OnTertiary => "#300048";
    public string TertiaryContainer => "#CB72FA";
    public string OnTertiaryContainer => "#0F001B";
    // Error
    public string Error => "#FFBDC3";
    public string OnError => "#3F000F";
    public string ErrorContainer => "#8E0A31";
    public string OnErrorContainer => "#FFD6D9";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#381D2B";
    public string OnSurface => "#FFE0EC";
    public string OnSurfaceVariant => "#EDC2D5";
    public string SurfaceDim => "#1D0613";
    public string SurfaceBright => "#3F2332";
    public string SurfaceTint => "#FFBCDB";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#C39BAC";
    public string OutlineVariant => "#A17B8C";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F8";
    public string InverseOnSurface => "#6C4C5B";
    public string InversePrimary => "#9C1B6F";
    // Primary Fixed
    public string PrimaryFixed => "#FFBCDB";
    public string OnPrimaryFixed => "#3B0027";
    public string PrimaryFixedDim => "#FF75C3";
    public string OnPrimaryFixedVariant => "#760051";
    // Secondary Fixed
    public string SecondaryFixed => "#FFBCDB";
    public string OnSecondaryFixed => "#53203D";
    public string SecondaryFixedDim => "#F5ABCF";
    public string OnSecondaryFixedVariant => "#6B3452";
    // Tertiary Fixed
    public string TertiaryFixed => "#ECBFFF";
    public string OnTertiaryFixed => "#300048";
    public string TertiaryFixedDim => "#D584FF";
    public string OnTertiaryFixedVariant => "#61008C";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#381D2B";
    public string SurfaceContainer => "#442836";
    public string SurfaceContainerHigh => "#503241";
    public string SurfaceContainerHighest => "#381D2B";
}
