using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class DarkMode_NormalContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#A6C8FF";
    public string OnPrimary => "#00315F";
    public string PrimaryContainer => "#004787";
    public string OnPrimaryContainer => "#D5E3FF";

    public string Secondary => "#BDC7DC";
    public string OnSecondary => "#273141";
    public string SecondaryContainer => "#3D4758";
    public string OnSecondaryContainer => "#D9E3F8";

    public string Tertiary => "#DABDE2";
    public string OnTertiary => "#3D2846";
    public string TertiaryContainer => "#553F5D";
    public string OnTertiaryContainer => "#F7D8FF";

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
