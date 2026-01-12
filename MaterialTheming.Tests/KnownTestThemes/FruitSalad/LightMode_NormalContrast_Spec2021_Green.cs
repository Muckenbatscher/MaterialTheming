using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_NormalContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#6D5E00";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#FCE365";
    public string OnPrimaryContainer => "#524600";

    public string Secondary => "#6C5E10";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#F6E388";
    public string OnSecondaryContainer => "#524600";

    public string Tertiary => "#36693D";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#B8F1B9";
    public string OnTertiaryContainer => "#1D5128";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#F2FCEE";
    public string OnSurface => "#151E15";
    public string OnSurfaceVariant => "#3A4B3A";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#ECF7E8";
    public string SurfaceContainer => "#E7F1E2";
    public string SurfaceContainerHigh => "#E1EBDD";
    public string SurfaceContainerHighest => "#DBE5D7";
}
