namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_NormalContrast_Spec2026_Watch_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFBFB8";
    public string OnPrimary => "#511511";
    public string PrimaryContainer => "#77312B";
    public string OnPrimaryContainer => "#FFD7D2";
    // Secondary
    public string Secondary => "#BBEBED";
    public string OnSecondary => "#154648";
    public string SecondaryContainer => "#1E4E4F";
    public string OnSecondaryContainer => "#B9E9EA";
    // Tertiary
    public string Tertiary => "#7ADBFF";
    public string OnTertiary => "#003746";
    public string TertiaryContainer => "#46C1E8";
    public string OnTertiaryContainer => "#002C39";
    // Error
    public string Error => "#FFBDC3";
    public string OnError => "#3F000F";
    public string ErrorContainer => "#7D2938";
    public string OnErrorContainer => "#FFD6D9";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#3B1D1A";
    public string OnSurface => "#FFE1DE";
    public string OnSurfaceVariant => "#E7C7C3";
    public string SurfaceDim => "#1A0A08";
    public string SurfaceBright => "#44231F";
    public string SurfaceTint => "#FFBFB8";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#BD9F9B";
    public string OutlineVariant => "#9B7F7C";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F7";
    public string InverseOnSurface => "#674F4C";
    public string InversePrimary => "#893F38";
    // Primary Fixed
    public string PrimaryFixed => "#FFBFB8";
    public string OnPrimaryFixed => "#511511";
    public string PrimaryFixedDim => "#FD9C91";
    public string OnPrimaryFixedVariant => "#77312B";
    // Secondary Fixed
    public string SecondaryFixed => "#BBEBED";
    public string OnSecondaryFixed => "#154648";
    public string SecondaryFixedDim => "#AEDDDE";
    public string OnSecondaryFixedVariant => "#1E4E4F";
    // Tertiary Fixed
    public string TertiaryFixed => "#7ADBFF";
    public string OnTertiaryFixed => "#003746";
    public string TertiaryFixedDim => "#57CFF7";
    public string OnTertiaryFixedVariant => "#004D61";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#34211F";
    public string SurfaceContainer => "#402B29";
    public string SurfaceContainerHigh => "#4C3634";
    public string SurfaceContainerHighest => "#3B1D1A";
}
