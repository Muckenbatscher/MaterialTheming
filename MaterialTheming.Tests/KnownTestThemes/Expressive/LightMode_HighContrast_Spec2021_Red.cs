namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_HighContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#002B5F";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#254881";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#292F09";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#464D24";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#0F330F";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#2D5129";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F6";
    public string SurfaceVariant => "#FDDCD0";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#C9B4AD";
    public string SurfaceBright => "#FFF8F6";
    public string SurfaceTint => "#3D5E98";
    // Background
    public string Background => "#FFF8F6";
    public string OnBackground => "#251914";
    // Outline
    public string Outline => "#3B2820";
    public string OutlineVariant => "#5A443C";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#3B2D28";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#ACC7FF";
    // Primary Fixed
    public string PrimaryFixed => "#254881";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#043169";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#464D24";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#2F3610";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#2D5129";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#163A15";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFEDE7";
    public string SurfaceContainer => "#F5DED6";
    public string SurfaceContainerHigh => "#E6D0C8";
    public string SurfaceContainerHighest => "#D8C2BB";
}
