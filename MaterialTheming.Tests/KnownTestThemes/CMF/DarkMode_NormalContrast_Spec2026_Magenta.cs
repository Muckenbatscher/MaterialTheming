namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class DarkMode_NormalContrast_Spec2026_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#F86ABC";
    public string OnPrimary => "#45002E";
    public string PrimaryContainer => "#F86ABC";
    public string OnPrimaryContainer => "#45002E";
    // Secondary
    public string Secondary => "#CE89AB";
    public string OnSecondary => "#3D0D2A";
    public string SecondaryContainer => "#511E3B";
    public string OnSecondaryContainer => "#E39BBE";
    // Tertiary
    public string Tertiary => "#E47CB4";
    public string OnTertiary => "#45002E";
    public string TertiaryContainer => "#E47CB4";
    public string OnTertiaryContainer => "#45002E";
    // Error
    public string Error => "#FF7169";
    public string OnError => "#490004";
    public string ErrorContainer => "#7D010E";
    public string OnErrorContainer => "#FFA9A2";
    // Surface
    public string Surface => "#190911";
    public string SurfaceVariant => "#3B1B2C";
    public string OnSurface => "#FFDCEA";
    public string OnSurfaceVariant => "#CE9EB4";
    public string SurfaceDim => "#190911";
    public string SurfaceBright => "#422133";
    public string SurfaceTint => "#F86ABC";
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
    public string PrimaryFixed => "#F86ABC";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#E85DAE";
    public string OnPrimaryFixedVariant => "#56003A";
    // Secondary Fixed
    public string SecondaryFixed => "#FBB1D5";
    public string OnSecondaryFixed => "#4C1A37";
    public string SecondaryFixedDim => "#ECA3C7";
    public string OnSecondaryFixedVariant => "#6E3755";
    // Tertiary Fixed
    public string TertiaryFixed => "#E47CB4";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#D56FA6";
    public string OnTertiaryFixedVariant => "#56013A";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#210C18";
    public string SurfaceContainer => "#2A111F";
    public string SurfaceContainerHigh => "#321725";
    public string SurfaceContainerHighest => "#3B1B2C";
}
