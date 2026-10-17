namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class DarkMode_NormalContrast_Spec2026_Watch_Magenta_Cyan : ITestThemeSecondSourceColor
{
    public string SourceColor => "#E85DAE"; //Magenta
    public string SecondSourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.CMF;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#EC60B1";
    public string OnPrimary => "#2E001D";
    public string PrimaryContainer => "#EB60B1";
    public string OnPrimaryContainer => "#2E001D";
    // Secondary
    public string Secondary => "#C27FA1";
    public string OnSecondary => "#2D011D";
    public string SecondaryContainer => "#511E3B";
    public string OnSecondaryContainer => "#E39BBE";
    // Tertiary
    public string Tertiary => "#00BCD1";
    public string OnTertiary => "#003138";
    public string TertiaryContainer => "#00BCD1";
    public string OnTertiaryContainer => "#003138";
    // Error
    public string Error => "#FB6270";
    public string OnError => "#380009";
    public string ErrorContainer => "#880524";
    public string OnErrorContainer => "#FFB7B9";
    // Surface
    public string Surface => "#190911";
    public string SurfaceVariant => "#3B1B2C";
    public string OnSurface => "#FFDCEA";
    public string OnSurfaceVariant => "#CE9EB4";
    public string SurfaceDim => "#190911";
    public string SurfaceBright => "#422133";
    public string SurfaceTint => "#EC60B1";
    // Background
    public string Background => "#190911";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#94697D";
    public string OutlineVariant => "#623D4F";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F8";
    public string InverseOnSurface => "#664F59";
    public string InversePrimary => "#9C1B6F";
    // Primary Fixed
    public string PrimaryFixed => "#EB60B1";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#DB53A3";
    public string OnPrimaryFixedVariant => "#43002C";
    // Secondary Fixed
    public string SecondaryFixed => "#FBB1D5";
    public string OnSecondaryFixed => "#4C1A37";
    public string SecondaryFixedDim => "#ECA3C7";
    public string OnSecondaryFixedVariant => "#6E3755";
    // Tertiary Fixed
    public string TertiaryFixed => "#00BCD1";
    public string OnTertiaryFixed => "#001316";
    public string TertiaryFixedDim => "#00ADC1";
    public string OnTertiaryFixedVariant => "#003B43";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#210C18";
    public string SurfaceContainer => "#2A111F";
    public string SurfaceContainerHigh => "#321725";
    public string SurfaceContainerHighest => "#3B1B2C";
}
