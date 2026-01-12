using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class LightMode_NormalContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#1B6C31";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#A3F5AA";
    public string OnPrimaryContainer => "#00531F";

    public string Secondary => "#516350";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#D4E8D1";
    public string OnSecondaryContainer => "#3A4B3A";

    public string Tertiary => "#39656C";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#BDEAF3";
    public string OnTertiaryContainer => "#1F4D54";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#F9F9F9";
    public string OnSurface => "#1B1B1B";
    public string OnSurfaceVariant => "#474747";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F3F3F3";
    public string SurfaceContainer => "#EEEEEE";
    public string SurfaceContainerHigh => "#E8E8E8";
    public string SurfaceContainerHighest => "#E2E2E2";
}
