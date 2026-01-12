using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_NormalContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#A6C8FF";
    public string OnPrimary => "#02315E";
    public string PrimaryContainer => "#234776";
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

    public string Surface => "#111318";
    public string OnSurface => "#E1E2E9";
    public string OnSurfaceVariant => "#C4C6CF";

    public string SurfaceContainerLowest => "#0C0E13";
    public string SurfaceContainerLow => "#191C20";
    public string SurfaceContainer => "#1D2024";
    public string SurfaceContainerHigh => "#282A2F";
    public string SurfaceContainerHighest => "#32353A";
}
