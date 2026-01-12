using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_NormalContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#DAC0CA";
    public string OnPrimary => "#3D2C33";
    public string PrimaryContainer => "#54424A";
    public string OnPrimaryContainer => "#F7DBE6";

    public string Secondary => "#D4C2C8";
    public string OnSecondary => "#392D32";
    public string SecondaryContainer => "#504348";
    public string OnSecondaryContainer => "#F1DEE4";

    public string Tertiary => "#E0BDCC";
    public string OnTertiary => "#402A35";
    public string TertiaryContainer => "#58404B";
    public string OnTertiaryContainer => "#FDD9E8";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#151314";
    public string OnSurface => "#E8E1E1";
    public string OnSurfaceVariant => "#CBC5C6";

    public string SurfaceContainerLowest => "#100E0E";
    public string SurfaceContainerLow => "#1E1B1C";
    public string SurfaceContainer => "#221F20";
    public string SurfaceContainerHigh => "#2C292A";
    public string SurfaceContainerHighest => "#373435";
}
