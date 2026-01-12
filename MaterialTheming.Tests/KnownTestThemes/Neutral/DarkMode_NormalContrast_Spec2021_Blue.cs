using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_NormalContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#C0C7D5";
    public string OnPrimary => "#2A313C";
    public string PrimaryContainer => "#404753";
    public string OnPrimaryContainer => "#DCE2F2";

    public string Secondary => "#C4C6CF";
    public string OnSecondary => "#2D3038";
    public string SecondaryContainer => "#43474E";
    public string OnSecondaryContainer => "#E0E2EC";

    public string Tertiary => "#BDC7DC";
    public string OnTertiary => "#273141";
    public string TertiaryContainer => "#3D4758";
    public string OnTertiaryContainer => "#D9E3F8";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#131315";
    public string OnSurface => "#E4E2E3";
    public string OnSurfaceVariant => "#C8C6C7";

    public string SurfaceContainerLowest => "#0E0E0F";
    public string SurfaceContainerLow => "#1B1B1D";
    public string SurfaceContainer => "#1F1F21";
    public string SurfaceContainerHigh => "#2A2A2B";
    public string SurfaceContainerHighest => "#353536";
}
