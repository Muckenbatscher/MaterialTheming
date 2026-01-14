using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_NormalContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FFAFD6";
    public string OnPrimary => "#620043";
    public string PrimaryContainer => "#8A0060";
    public string OnPrimaryContainer => "#FFD8E8";
    // Secondary
    public string Secondary => "#F0B7C5";
    public string OnSecondary => "#4A2530";
    public string SecondaryContainer => "#643B46";
    public string OnSecondaryContainer => "#FFD9E1";
    // Tertiary
    public string Tertiary => "#FFB3B6";
    public string OnTertiary => "#532025";
    public string TertiaryContainer => "#6E353A";
    public string OnTertiaryContainer => "#FFDADA";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#1C1016";
    public string SurfaceVariant => "#54424A";
    public string OnSurface => "#F4DDE5";
    public string OnSurfaceVariant => "#DAC0CA";
    public string SurfaceDim => "#1C1016";
    public string SurfaceBright => "#44353C";
    public string SurfaceTint => "#FFAFD6";
    // Background
    public string Background => "#1C1016";
    public string OnBackground => "#F4DDE5";
    // Outline
    public string Outline => "#A28B94";
    public string OutlineVariant => "#54424A";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F4DDE5";
    public string InverseOnSurface => "#3B2C33";
    public string InversePrimary => "#B4007F";
    // Primary Fixed
    public string PrimaryFixed => "#FFD8E8";
    public string OnPrimaryFixed => "#3C0028";
    public string PrimaryFixedDim => "#FFAFD6";
    public string OnPrimaryFixedVariant => "#8A0060";
    // Secondary Fixed
    public string SecondaryFixed => "#FFD9E1";
    public string OnSecondaryFixed => "#31101B";
    public string SecondaryFixedDim => "#F0B7C5";
    public string OnSecondaryFixedVariant => "#643B46";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFDADA";
    public string OnTertiaryFixed => "#380B11";
    public string TertiaryFixedDim => "#FFB3B6";
    public string OnTertiaryFixedVariant => "#6E353A";
    // Surface Container
    public string SurfaceContainerLowest => "#160B10";
    public string SurfaceContainerLow => "#24181E";
    public string SurfaceContainer => "#291C22";
    public string SurfaceContainerHigh => "#34262C";
    public string SurfaceContainerHighest => "#3F3137";
}
