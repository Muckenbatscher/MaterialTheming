namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class DarkMode_MediumContrast_Spec2025_Watch_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Content;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFFEFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#DB52A3";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFEFF";
    public string OnSecondary => "#1A000F";
    public string SecondaryContainer => "#B37293";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFEFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#CB72FA";
    public string OnTertiaryContainer => "#0F001B";
    // Error
    public string Error => "#FFBDC3";
    public string OnError => "#3D000F";
    public string ErrorContainer => "#E5516B";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#381D2B";
    public string OnSurface => "#FFFEFF";
    public string OnSurfaceVariant => "#EDC2D5";
    public string SurfaceDim => "#1D0613";
    public string SurfaceBright => "#3F2332";
    public string SurfaceTint => "#FFFEFF";
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
    public string InverseOnSurface => "#4D2F3E";
    public string InversePrimary => "#70004D";
    // Primary Fixed
    public string PrimaryFixed => "#FFBCDB";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#FF75C3";
    public string OnPrimaryFixedVariant => "#3B0027";
    // Secondary Fixed
    public string SecondaryFixed => "#FFBCDB";
    public string OnSecondaryFixed => "#1A000F";
    public string SecondaryFixedDim => "#F5ABCF";
    public string OnSecondaryFixedVariant => "#53203D";
    // Tertiary Fixed
    public string TertiaryFixed => "#ECBFFF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#D584FF";
    public string OnTertiaryFixedVariant => "#300048";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#381D2B";
    public string SurfaceContainer => "#442836";
    public string SurfaceContainerHigh => "#503241";
    public string SurfaceContainerHighest => "#381D2B";
}
