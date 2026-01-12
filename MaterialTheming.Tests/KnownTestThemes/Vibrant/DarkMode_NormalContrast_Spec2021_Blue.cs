using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_NormalContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#A6C8FF";
    public string OnPrimary => "#00315F";
    public string PrimaryContainer => "#004787";
    public string OnPrimaryContainer => "#D5E3FF";

    public string Secondary => "#BDC5EB";
    public string OnSecondary => "#272F4D";
    public string SecondaryContainer => "#3E4565";
    public string OnSecondaryContainer => "#DCE1FF";

    public string Tertiary => "#C6C0F9";
    public string OnTertiary => "#2E2A59";
    public string TertiaryContainer => "#454171";
    public string OnTertiaryContainer => "#E4DFFF";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#0E141C";
    public string OnSurface => "#DEE2EF";
    public string OnSurfaceVariant => "#C0C7D5";

    public string SurfaceContainerLowest => "#090E17";
    public string SurfaceContainerLow => "#171C24";
    public string SurfaceContainer => "#1B2029";
    public string SurfaceContainerHigh => "#252A33";
    public string SurfaceContainerHighest => "#30353E";
}
