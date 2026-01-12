using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_NormalContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#FFAFD6";
    public string OnPrimary => "#620043";
    public string PrimaryContainer => "#8A0060";
    public string OnPrimaryContainer => "#FFD8E8";

    public string Secondary => "#F0B7C5";
    public string OnSecondary => "#4A2530";
    public string SecondaryContainer => "#643B46";
    public string OnSecondaryContainer => "#FFD9E1";

    public string Tertiary => "#FFB3B6";
    public string OnTertiary => "#532025";
    public string TertiaryContainer => "#6E353A";
    public string OnTertiaryContainer => "#FFDADA";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#1C1016";
    public string OnSurface => "#F4DDE5";
    public string OnSurfaceVariant => "#DAC0CA";

    public string SurfaceContainerLowest => "#160B10";
    public string SurfaceContainerLow => "#24181E";
    public string SurfaceContainer => "#291C22";
    public string SurfaceContainerHigh => "#34262C";
    public string SurfaceContainerHighest => "#3F3137";
}
