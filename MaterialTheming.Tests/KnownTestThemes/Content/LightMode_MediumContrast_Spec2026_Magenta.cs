namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class LightMode_MediumContrast_Spec2026_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#6C004A";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#BC3889";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#5A2142";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#9B587B";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#6F0D00";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#C33F26";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F8";
    public string SurfaceVariant => "#F8DBE6";
    public string OnSurface => "#180E13";
    public string OnSurfaceVariant => "#433139";
    public string SurfaceDim => "#D5C2C8";
    public string SurfaceBright => "#FFF8F8";
    public string SurfaceTint => "#A92779";
    // Background
    public string Background => "#FFF8F8";
    public string OnBackground => "#23181D";
    // Outline
    public string Outline => "#614D56";
    public string OutlineVariant => "#7D6771";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#392D32";
    public string InverseOnSurface => "#FFECF2";
    public string InversePrimary => "#FFAFD6";
    // Primary Fixed
    public string PrimaryFixed => "#BC3889";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#9C1B6F";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#9B587B";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#7F4062";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#C33F26";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#A12610";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0F4";
    public string SurfaceContainer => "#F8E3EA";
    public string SurfaceContainerHigh => "#ECD8DF";
    public string SurfaceContainerHighest => "#E0CDD3";
}
