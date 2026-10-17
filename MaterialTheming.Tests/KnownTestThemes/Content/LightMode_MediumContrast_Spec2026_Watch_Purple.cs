namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class LightMode_MediumContrast_Spec2026_Watch_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Content;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFFEFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#A46BDD";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFEFF";
    public string OnSecondary => "#1B062F";
    public string SecondaryContainer => "#947CAB";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFEFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#7C90FF";
    public string OnTertiaryContainer => "#000323";
    // Error
    public string Error => "#FFBDC3";
    public string OnError => "#3D000F";
    public string ErrorContainer => "#DA5C6F";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#2D2139";
    public string OnSurface => "#FFFEFF";
    public string OnSurfaceVariant => "#DAC7E7";
    public string SurfaceDim => "#140920";
    public string SurfaceBright => "#33273F";
    public string SurfaceTint => "#FFFEFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#B19FBE";
    public string OutlineVariant => "#90809D";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF7FE";
    public string InverseOnSurface => "#40334C";
    public string InversePrimary => "#511289";
    // Primary Fixed
    public string PrimaryFixed => "#E2C2FF";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#C58CFF";
    public string OnPrimaryFixedVariant => "#2B0050";
    // Secondary Fixed
    public string SecondaryFixed => "#E6CAFE";
    public string OnSecondaryFixed => "#1B062F";
    public string SecondaryFixedDim => "#D7BCEF";
    public string OnSecondaryFixedVariant => "#422D57";
    // Tertiary Fixed
    public string TertiaryFixed => "#C5CCFF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#8E9FFF";
    public string OnTertiaryFixedVariant => "#001058";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#2D2139";
    public string SurfaceContainer => "#382B44";
    public string SurfaceContainerHigh => "#43364F";
    public string SurfaceContainerHighest => "#2D2139";
}
