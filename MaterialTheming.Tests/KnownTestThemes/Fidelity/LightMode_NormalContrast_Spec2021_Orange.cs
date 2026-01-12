using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class LightMode_NormalContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#984804";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#D77837";
    public string OnPrimaryContainer => "#481E00";

    public string Secondary => "#805439";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#FDC2A0";
    public string OnSecondaryContainer => "#794E33";

    public string Tertiary => "#00677E";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#009EBF";
    public string OnTertiaryContainer => "#002E3A";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#FFF8F5";
    public string OnSurface => "#221A15";
    public string OnSurfaceVariant => "#554339";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1EA";
    public string SurfaceContainer => "#FCEAE2";
    public string SurfaceContainerHigh => "#F6E5DC";
    public string SurfaceContainerHighest => "#F1DFD7";
}
