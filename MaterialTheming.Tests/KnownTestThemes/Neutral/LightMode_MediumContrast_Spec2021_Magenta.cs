using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_MediumContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#433139";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#7D6770";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#3F3338";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#78696F";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#472F3A";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#816572";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F8";
    public string SurfaceVariant => "#E8E1E1";
    public string OnSurface => "#131011";
    public string OnSurfaceVariant => "#393536";
    public string SurfaceDim => "#CBC5C6";
    public string SurfaceBright => "#FFF8F8";
    public string SurfaceTint => "#6D5962";
    // Background
    public string Background => "#FFF8F8";
    public string OnBackground => "#1E1B1C";
    // Outline
    public string Outline => "#555152";
    public string OutlineVariant => "#716C6D";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#333030";
    public string InverseOnSurface => "#F6EFF0";
    public string InversePrimary => "#DAC0CA";
    // Primary Fixed
    public string PrimaryFixed => "#7D6770";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#634F58";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#78696F";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#5E5156";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#816572";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#684D59";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F9F2F3";
    public string SurfaceContainer => "#EEE6E7";
    public string SurfaceContainerHigh => "#E2DBDC";
    public string SurfaceContainerHighest => "#D7D0D1";
}
