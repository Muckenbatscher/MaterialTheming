namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class LightMode_NormalContrast_Spec2025_Watch_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Content;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#E2C2FF";
    public string OnPrimary => "#2B0050";
    public string PrimaryContainer => "#612798";
    public string OnPrimaryContainer => "#EED8FF";
    // Secondary
    public string Secondary => "#E6CAFE";
    public string OnSecondary => "#422D57";
    public string SecondaryContainer => "#533E68";
    public string OnSecondaryContainer => "#EED8FF";
    // Tertiary
    public string Tertiary => "#C5CCFF";
    public string OnTertiary => "#001058";
    public string TertiaryContainer => "#7C90FF";
    public string OnTertiaryContainer => "#000323";
    // Error
    public string Error => "#FFBDC3";
    public string OnError => "#3F000F";
    public string ErrorContainer => "#871C34";
    public string OnErrorContainer => "#FFD6D9";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#2D2139";
    public string OnSurface => "#F4E2FF";
    public string OnSurfaceVariant => "#DAC7E7";
    public string SurfaceDim => "#140920";
    public string SurfaceBright => "#33273F";
    public string SurfaceTint => "#E2C2FF";
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
    public string InverseOnSurface => "#5E4F6A";
    public string InversePrimary => "#7038A8";
    // Primary Fixed
    public string PrimaryFixed => "#E2C2FF";
    public string OnPrimaryFixed => "#2B0050";
    public string PrimaryFixedDim => "#C58CFF";
    public string OnPrimaryFixedVariant => "#55178C";
    // Secondary Fixed
    public string SecondaryFixed => "#E6CAFE";
    public string OnSecondaryFixed => "#422D57";
    public string SecondaryFixedDim => "#D7BCEF";
    public string OnSecondaryFixedVariant => "#533E68";
    // Tertiary Fixed
    public string TertiaryFixed => "#C5CCFF";
    public string OnTertiaryFixed => "#001058";
    public string TertiaryFixedDim => "#8E9FFF";
    public string OnTertiaryFixedVariant => "#0F2CA0";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#2D2139";
    public string SurfaceContainer => "#382B44";
    public string SurfaceContainerHigh => "#43364F";
    public string SurfaceContainerHighest => "#2D2139";
}
