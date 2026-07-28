namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_HighContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFDCEA";
    public string OnPrimary => "#4C1937";
    public string PrimaryContainer => "#D68EB2";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#CFEBE7";
    public string OnSecondary => "#17302E";
    public string SecondaryContainer => "#8EA9A5";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#89FFED";
    public string OnTertiary => "#003630";
    public string TertiaryContainer => "#6EF2DF";
    public string OnTertiaryContainer => "#002C27";
    // Error
    public string Error => "#FFDDDF";
    public string OnError => "#5F001C";
    public string ErrorContainer => "#FF798C";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#190911";
    public string SurfaceVariant => "#3A1C2C";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFDCEA";
    public string SurfaceDim => "#190911";
    public string SurfaceBright => "#432133";
    public string SurfaceTint => "#FFDCEA";
    // Background
    public string Background => "#190911";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#DAACC1";
    public string OutlineVariant => "#C497AB";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F8";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#5B2544";
    // Primary Fixed
    public string PrimaryFixed => "#F9ADD2";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#EAA0C4";
    public string OnPrimaryFixedVariant => "#000000";
    // Secondary Fixed
    public string SecondaryFixed => "#DAF7F2";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#CCE8E4";
    public string OnSecondaryFixedVariant => "#152E2C";
    // Tertiary Fixed
    public string TertiaryFixed => "#6EF2DF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#5EE3D1";
    public string OnTertiaryFixedVariant => "#001F1B";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#200D17";
    public string SurfaceContainer => "#29121E";
    public string SurfaceContainerHigh => "#311725";
    public string SurfaceContainerHighest => "#3A1C2C";
}
