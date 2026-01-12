using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_NormalContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#36693D";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#B8F1B9";
    public string OnPrimaryContainer => "#1D5128";

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

    public string Surface => "#F7FBF2";
    public string OnSurface => "#181D18";
    public string OnSurfaceVariant => "#424940";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F1F5EC";
    public string SurfaceContainer => "#EBEFE7";
    public string SurfaceContainerHigh => "#E5E9E1";
    public string SurfaceContainerHighest => "#E0E4DB";
}
