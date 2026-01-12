using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Monochrome;

internal class DarkMode_NormalContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Monochrome;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#FFFFFF";
    public string OnPrimary => "#1B1B1B";
    public string PrimaryContainer => "#D4D4D4";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#C6C6C6";
    public string OnSecondary => "#1B1B1B";
    public string SecondaryContainer => "#474747";
    public string OnSecondaryContainer => "#E2E2E2";

    public string Tertiary => "#E2E2E2";
    public string OnTertiary => "#1B1B1B";
    public string TertiaryContainer => "#919191";
    public string OnTertiaryContainer => "#000000";

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
