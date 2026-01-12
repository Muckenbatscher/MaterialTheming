using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_HighContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#EAF0FF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#BCC3D1";
    public string OnPrimaryContainer => "#050B16";

    public string Secondary => "#EDF0F9";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#C0C2CB";
    public string OnSecondaryContainer => "#080B12";

    public string Tertiary => "#EAF0FF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#B9C3D8";
    public string OnTertiaryContainer => "#020B1A";

    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";

    public string Surface => "#131315";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1F1F21";
    public string SurfaceContainer => "#303032";
    public string SurfaceContainerHigh => "#3B3B3D";
    public string SurfaceContainerHighest => "#474648";
}
