using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class DarkMode_NormalContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#FFAFD6";
    public string OnPrimary => "#5B1140";
    public string PrimaryContainer => "#772957";
    public string OnPrimaryContainer => "#FFD8E8";

    public string Secondary => "#E0BDCC";
    public string OnSecondary => "#402A35";
    public string SecondaryContainer => "#58404B";
    public string OnSecondaryContainer => "#FDD9E8";

    public string Tertiary => "#F3BB9A";
    public string OnTertiary => "#4A2811";
    public string TertiaryContainer => "#643D25";
    public string OnTertiaryContainer => "#FFDBC8";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#131313";
    public string OnSurface => "#E2E2E2";
    public string OnSurfaceVariant => "#C6C6C6";

    public string SurfaceContainerLowest => "#0E0E0E";
    public string SurfaceContainerLow => "#1B1B1B";
    public string SurfaceContainer => "#1F1F1F";
    public string SurfaceContainerHigh => "#2A2A2A";
    public string SurfaceContainerHighest => "#353535";
}
