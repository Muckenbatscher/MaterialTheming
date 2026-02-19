namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class DarkMode_HighContrast_Spec2026_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFDCEA";
    public string OnPrimary => "#5A003D";
    public string PrimaryContainer => "#FF71C2";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFDCEA";
    public string OnSecondary => "#4C1A37";
    public string SecondaryContainer => "#D58FB1";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFDCEA";
    public string OnTertiary => "#59033D";
    public string TertiaryContainer => "#EB81BA";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFDEDB";
    public string OnError => "#600008";
    public string ErrorContainer => "#FF7C74";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#190911";
    public string SurfaceVariant => "#3B1B2C";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFDCEA";
    public string SurfaceDim => "#190911";
    public string SurfaceBright => "#422133";
    public string SurfaceTint => "#FFDCEA";
    // Background
    public string Background => "#190911";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#DCABC1";
    public string OutlineVariant => "#C696AC";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F8";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#70004D";
    // Primary Fixed
    public string PrimaryFixed => "#FF71C2";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#FF71C2";
    public string OnPrimaryFixedVariant => "#000000";
    // Secondary Fixed
    public string SecondaryFixed => "#FBB1D5";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#ECA3C7";
    public string OnSecondaryFixedVariant => "#000000";
    // Tertiary Fixed
    public string TertiaryFixed => "#EB81BA";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#EB81BA";
    public string OnTertiaryFixedVariant => "#000000";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#210C18";
    public string SurfaceContainer => "#2A111F";
    public string SurfaceContainerHigh => "#321725";
    public string SurfaceContainerHighest => "#3B1B2C";
}
