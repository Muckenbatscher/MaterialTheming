namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class DarkMode_HighContrast_Spec2026_Watch_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Content;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFFFFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#FF75C3";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFFFF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#D791B3";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFFFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#D584FF";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFBDC3";
    public string OnError => "#000000";
    public string ErrorContainer => "#FF7D8F";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#381D2B";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFEFF";
    public string SurfaceDim => "#1D0613";
    public string SurfaceBright => "#3F2332";
    public string SurfaceTint => "#FFFFFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#EDC2D5";
    public string OutlineVariant => "#C39BAC";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F8";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#000000";
    // Primary Fixed
    public string PrimaryFixed => "#FFBCDB";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#FF75C3";
    public string OnPrimaryFixedVariant => "#000000";
    // Secondary Fixed
    public string SecondaryFixed => "#FFBCDB";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#F5ABCF";
    public string OnSecondaryFixedVariant => "#1A000F";
    // Tertiary Fixed
    public string TertiaryFixed => "#ECBFFF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#D584FF";
    public string OnTertiaryFixedVariant => "#000000";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#381D2B";
    public string SurfaceContainer => "#442836";
    public string SurfaceContainerHigh => "#503241";
    public string SurfaceContainerHighest => "#381D2B";
}
