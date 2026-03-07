namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class DarkMode_MediumContrast_Spec2026_Magenta_Green : ITestThemeSecondSourceColor
{
    public string SourceColor => "#E85DAE"; //Magenta
    public string SecondSourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FF98CE";
    public string OnPrimary => "#5A003D";
    public string PrimaryContainer => "#F86ABC";
    public string OnPrimaryContainer => "#290019";
    // Secondary
    public string Secondary => "#ECA3C7";
    public string OnSecondary => "#4C1A37";
    public string SecondaryContainer => "#A06181";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#77CB81";
    public string OnTertiary => "#003411";
    public string TertiaryContainer => "#308443";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#FF9EA2";
    public string OnError => "#600015";
    public string ErrorContainer => "#CE4151";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#190911";
    public string SurfaceVariant => "#3B1B2C";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#DCABC1";
    public string SurfaceDim => "#190911";
    public string SurfaceBright => "#422133";
    public string SurfaceTint => "#FF98CE";
    // Background
    public string Background => "#190911";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#B4869C";
    public string OutlineVariant => "#94697D";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F8";
    public string InverseOnSurface => "#47323C";
    public string InversePrimary => "#9C1B6F";
    // Primary Fixed
    public string PrimaryFixed => "#F86ABC";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#E85DAE";
    public string OnPrimaryFixedVariant => "#000000";
    // Secondary Fixed
    public string SecondaryFixed => "#FBB1D5";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#ECA3C7";
    public string OnSecondaryFixedVariant => "#4C1A37";
    // Tertiary Fixed
    public string TertiaryFixed => "#308443";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#318543";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#210C18";
    public string SurfaceContainer => "#2A111F";
    public string SurfaceContainerHigh => "#321725";
    public string SurfaceContainerHighest => "#3B1B2C";
}
