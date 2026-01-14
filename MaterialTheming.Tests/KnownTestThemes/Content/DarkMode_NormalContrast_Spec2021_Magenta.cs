using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class DarkMode_NormalContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FFAFD6";
    public string OnPrimary => "#620043";
    public string PrimaryContainer => "#E85DAE";
    public string OnPrimaryContainer => "#55003A";
    // Secondary
    public string Secondary => "#FFAFD6";
    public string OnSecondary => "#531C3C";
    public string SecondaryContainer => "#713456";
    public string OnSecondaryContainer => "#EFA1C8";
    // Tertiary
    public string Tertiary => "#FFB4A5";
    public string OnTertiary => "#650B00";
    public string TertiaryContainer => "#F36145";
    public string OnTertiaryContainer => "#580800";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#1B1015";
    public string SurfaceVariant => "#55414A";
    public string OnSurface => "#F2DDE4";
    public string OnSurfaceVariant => "#DBBFCA";
    public string SurfaceDim => "#1B1015";
    public string SurfaceBright => "#43363B";
    public string SurfaceTint => "#FFAFD6";
    // Background
    public string Background => "#1B1015";
    public string OnBackground => "#F2DDE4";
    // Outline
    public string Outline => "#A38A94";
    public string OutlineVariant => "#55414A";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F2DDE4";
    public string InverseOnSurface => "#392D32";
    public string InversePrimary => "#A92779";
    // Primary Fixed
    public string PrimaryFixed => "#FFD8E8";
    public string OnPrimaryFixed => "#3C0028";
    public string PrimaryFixedDim => "#FFAFD6";
    public string OnPrimaryFixedVariant => "#8A0160";
    // Secondary Fixed
    public string SecondaryFixed => "#FFD8E8";
    public string OnSecondaryFixed => "#390526";
    public string SecondaryFixedDim => "#FFAFD6";
    public string OnSecondaryFixedVariant => "#6E3253";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFDAD3";
    public string OnTertiaryFixed => "#3E0400";
    public string TertiaryFixedDim => "#FFB4A5";
    public string OnTertiaryFixedVariant => "#8C1703";
    // Surface Container
    public string SurfaceContainerLowest => "#150B10";
    public string SurfaceContainerLow => "#23181D";
    public string SurfaceContainer => "#281C22";
    public string SurfaceContainerHigh => "#33272C";
    public string SurfaceContainerHighest => "#3E3137";
}
