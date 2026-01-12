using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_NormalContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#4FD8EB";
    public string OnPrimary => "#00363D";
    public string PrimaryContainer => "#004F58";
    public string OnPrimaryContainer => "#98F0FF";

    public string Secondary => "#82D3E0";
    public string OnSecondary => "#00363D";
    public string SecondaryContainer => "#004F58";
    public string OnSecondaryContainer => "#9EEFFD";

    public string Tertiary => "#A6C8FF";
    public string OnTertiary => "#02315E";
    public string TertiaryContainer => "#234776";
    public string OnTertiaryContainer => "#D5E3FF";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#0E141C";
    public string OnSurface => "#DEE2EF";
    public string OnSurfaceVariant => "#BDC7DC";

    public string SurfaceContainerLowest => "#090E17";
    public string SurfaceContainerLow => "#171C24";
    public string SurfaceContainer => "#1B2029";
    public string SurfaceContainerHigh => "#252A33";
    public string SurfaceContainerHighest => "#30353E";
}
