using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_NormalContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#DCB8FF";
    public string OnPrimary => "#490081";
    public string PrimaryContainer => "#6800B4";
    public string OnPrimaryContainer => "#F0DBFF";

    public string Secondary => "#DCBCE1";
    public string OnSecondary => "#3E2845";
    public string SecondaryContainer => "#563E5C";
    public string OnSecondaryContainer => "#F9D8FE";

    public string Tertiary => "#EDB5E2";
    public string OnTertiary => "#492245";
    public string TertiaryContainer => "#62385D";
    public string OnTertiaryContainer => "#FFD7F5";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#16111B";
    public string OnSurface => "#EADFED";
    public string OnSurfaceVariant => "#CEC2D4";

    public string SurfaceContainerLowest => "#110C16";
    public string SurfaceContainerLow => "#1F1923";
    public string SurfaceContainer => "#231D28";
    public string SurfaceContainerHigh => "#2E2832";
    public string SurfaceContainerHighest => "#39323D";
}
