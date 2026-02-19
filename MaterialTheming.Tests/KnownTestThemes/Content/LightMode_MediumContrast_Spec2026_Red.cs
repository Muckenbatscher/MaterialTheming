namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class LightMode_MediumContrast_Spec2026_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#740006";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#C43C34";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#60221D";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#A4574F";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#4C3100";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#946300";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F7";
    public string SurfaceVariant => "#FEDAD6";
    public string OnSurface => "#1A0E0D";
    public string OnSurfaceVariant => "#47312E";
    public string SurfaceDim => "#D9C1BE";
    public string SurfaceBright => "#FFF8F7";
    public string SurfaceTint => "#B02D28";
    // Background
    public string Background => "#FFF8F7";
    public string OnBackground => "#261817";
    // Outline
    public string Outline => "#664C49";
    public string OutlineVariant => "#826663";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#3C2D2B";
    public string InverseOnSurface => "#FFEDEA";
    public string InversePrimary => "#FFB4AB";
    // Primary Fixed
    public string PrimaryFixed => "#C43C34";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#A2231F";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#A4574F";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#873F38";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#946300";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#744D00";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0EE";
    public string SurfaceContainer => "#FCE2DF";
    public string SurfaceContainerHigh => "#F0D7D4";
    public string SurfaceContainerHighest => "#E5CCC9";
}
