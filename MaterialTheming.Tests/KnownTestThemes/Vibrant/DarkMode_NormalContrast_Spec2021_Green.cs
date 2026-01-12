using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_NormalContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#00E563";
    public string OnPrimary => "#003913";
    public string PrimaryContainer => "#00531F";
    public string OnPrimaryContainer => "#69FF89";

    public string Secondary => "#A6D0B8";
    public string OnSecondary => "#103726";
    public string SecondaryContainer => "#284E3C";
    public string OnSecondaryContainer => "#C2ECD3";

    public string Tertiary => "#8FD4C2";
    public string OnTertiary => "#00382E";
    public string TertiaryContainer => "#005144";
    public string OnTertiaryContainer => "#ABF0DE";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#0D150D";
    public string OnSurface => "#DBE5D7";
    public string OnSurfaceVariant => "#BDCABA";

    public string SurfaceContainerLowest => "#081008";
    public string SurfaceContainerLow => "#151E15";
    public string SurfaceContainer => "#192219";
    public string SurfaceContainerHigh => "#232C23";
    public string SurfaceContainerHighest => "#2E372D";
}
