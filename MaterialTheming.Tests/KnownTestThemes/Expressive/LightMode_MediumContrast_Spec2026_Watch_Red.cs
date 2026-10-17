namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_MediumContrast_Spec2026_Watch_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFFEFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#C46D64";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FDFFFE";
    public string OnSecondary => "#002425";
    public string SecondaryContainer => "#608D8F";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFEFF";
    public string OnTertiary => "#000A0F";
    public string TertiaryContainer => "#46C1E8";
    public string OnTertiaryContainer => "#002C39";
    // Error
    public string Error => "#FFBDC3";
    public string OnError => "#3D000F";
    public string ErrorContainer => "#CC6674";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#3B1D1A";
    public string OnSurface => "#FFFEFF";
    public string OnSurfaceVariant => "#E7C7C3";
    public string SurfaceDim => "#1A0A08";
    public string SurfaceBright => "#44231F";
    public string SurfaceTint => "#FFFEFF";
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
    public string InverseOnSurface => "#483330";
    public string InversePrimary => "#64231D";
    // Primary Fixed
    public string PrimaryFixed => "#FFBFB8";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#FD9C91";
    public string OnPrimaryFixedVariant => "#511511";
    // Secondary Fixed
    public string SecondaryFixed => "#BBEBED";
    public string OnSecondaryFixed => "#002425";
    public string SecondaryFixedDim => "#AEDDDE";
    public string OnSecondaryFixedVariant => "#154648";
    // Tertiary Fixed
    public string TertiaryFixed => "#7ADBFF";
    public string OnTertiaryFixed => "#000A0F";
    public string TertiaryFixedDim => "#57CFF7";
    public string OnTertiaryFixedVariant => "#003746";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#34211F";
    public string SurfaceContainer => "#402B29";
    public string SurfaceContainerHigh => "#4C3634";
    public string SurfaceContainerHighest => "#3B1D1A";
}
