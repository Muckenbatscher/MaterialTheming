namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class DarkMode_NormalContrast_Spec2026_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#DCB8FF";
    public string OnPrimary => "#490180";
    public string PrimaryContainer => "#945CCD";
    public string OnPrimaryContainer => "#0B001B";
    // Secondary
    public string Secondary => "#D7BCEF";
    public string OnSecondary => "#3C2750";
    public string SecondaryContainer => "#55406B";
    public string OnSecondaryContainer => "#C9AEE0";
    // Tertiary
    public string Tertiary => "#FFAFD1";
    public string OnTertiary => "#63003D";
    public string TertiaryContainer => "#C04D87";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#161219";
    public string SurfaceVariant => "#4C4451";
    public string OnSurface => "#E9E0EA";
    public string OnSurfaceVariant => "#CEC3D3";
    public string SurfaceDim => "#161219";
    public string SurfaceBright => "#3C373F";
    public string SurfaceTint => "#DCB8FF";
    // Background
    public string Background => "#161219";
    public string OnBackground => "#E9E0EA";
    // Outline
    public string Outline => "#978D9D";
    public string OutlineVariant => "#4C4451";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E9E0EA";
    public string InverseOnSurface => "#332F36";
    public string InversePrimary => "#7A42B2";
    // Primary Fixed
    public string PrimaryFixed => "#F0DBFF";
    public string OnPrimaryFixed => "#2C0051";
    public string PrimaryFixedDim => "#DCB8FF";
    public string OnPrimaryFixedVariant => "#612798";
    // Secondary Fixed
    public string SecondaryFixed => "#F0DBFF";
    public string OnSecondaryFixed => "#26113A";
    public string SecondaryFixedDim => "#D7BCEF";
    public string OnSecondaryFixedVariant => "#533E68";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFD8E6";
    public string OnTertiaryFixed => "#3D0024";
    public string TertiaryFixedDim => "#FFAFD1";
    public string OnTertiaryFixedVariant => "#831A55";
    // Surface Container
    public string SurfaceContainerLowest => "#100D14";
    public string SurfaceContainerLow => "#1E1A21";
    public string SurfaceContainer => "#221E25";
    public string SurfaceContainerHigh => "#2D2830";
    public string SurfaceContainerHighest => "#38333B";
}
