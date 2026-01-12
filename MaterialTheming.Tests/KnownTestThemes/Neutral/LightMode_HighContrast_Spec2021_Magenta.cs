using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_HighContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#38272F";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#57444C";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#34292E";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#52464B";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#3C2630";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#5B424E";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F8";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F6EFF0";
    public string SurfaceContainer => "#E8E1E1";
    public string SurfaceContainerHigh => "#DAD3D3";
    public string SurfaceContainerHighest => "#CBC5C6";
}
