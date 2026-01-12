using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class DarkMode_NormalContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#FFB4AB";
    public string OnPrimary => "#5F1411";
    public string PrimaryContainer => "#7D2B25";
    public string OnPrimaryContainer => "#FFDAD6";

    public string Secondary => "#E7BDB8";
    public string OnSecondary => "#442926";
    public string SecondaryContainer => "#5D3F3C";
    public string OnSecondaryContainer => "#FFDAD6";

    public string Tertiary => "#E0C38C";
    public string OnTertiary => "#3F2E04";
    public string TertiaryContainer => "#584419";
    public string OnTertiaryContainer => "#FDDFA6";

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
