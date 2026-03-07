namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class DarkMode_NormalContrast_Spec2026_Magenta_Magenta : ITestThemeSecondSourceColor
{
    public string SourceColor => "#E85DAE"; //Magenta
    public string SecondSourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FC6DBF";
    public string OnPrimary => "#490031";
    public string PrimaryContainer => "#EB60B1";
    public string OnPrimaryContainer => "#2E001D";
    // Secondary
    public string Secondary => "#CE89AB";
    public string OnSecondary => "#3D0D2A";
    public string SecondaryContainer => "#511E3B";
    public string OnSecondaryContainer => "#E39BBE";
    // Tertiary
    public string Tertiary => "#E77EB6";
    public string OnTertiary => "#490031";
    public string TertiaryContainer => "#D871A9";
    public string OnTertiaryContainer => "#2E001D";
    // Error
    public string Error => "#FF6F7A";
    public string OnError => "#49000E";
    public string ErrorContainer => "#880524";
    public string OnErrorContainer => "#FFB7B9";
    // Surface
    public string Surface => "#190911";
    public string SurfaceVariant => "#3B1B2C";
    public string OnSurface => "#FFDCEA";
    public string OnSurfaceVariant => "#CE9EB4";
    public string SurfaceDim => "#190911";
    public string SurfaceBright => "#422133";
    public string SurfaceTint => "#FC6DBF";
    // Background
    public string Background => "#190911";
    public string OnBackground => "#FFDCEA";
    // Outline
    public string Outline => "#94697D";
    public string OutlineVariant => "#623D4F";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F8";
    public string InverseOnSurface => "#664F59";
    public string InversePrimary => "#A9287A";
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
    public string TertiaryFixed => "#D871A9";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#C8659B";
    public string OnTertiaryFixedVariant => "#43002C";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#210C18";
    public string SurfaceContainer => "#2A111F";
    public string SurfaceContainerHigh => "#321725";
    public string SurfaceContainerHighest => "#3B1B2C";
}
