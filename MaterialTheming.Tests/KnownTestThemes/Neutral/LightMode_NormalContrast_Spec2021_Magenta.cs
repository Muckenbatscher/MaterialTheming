using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_NormalContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#6D5962";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#F7DBE6";
    public string OnPrimaryContainer => "#54424A";

    public string Secondary => "#685B60";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#F1DEE4";
    public string OnSecondaryContainer => "#504348";

    public string Tertiary => "#725763";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#FDD9E8";
    public string OnTertiaryContainer => "#58404B";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#FFF8F8";
    public string OnSurface => "#1E1B1C";
    public string OnSurfaceVariant => "#4A4647";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F9F2F3";
    public string SurfaceContainer => "#F3ECED";
    public string SurfaceContainerHigh => "#EEE6E7";
    public string SurfaceContainerHighest => "#E8E1E1";
}
