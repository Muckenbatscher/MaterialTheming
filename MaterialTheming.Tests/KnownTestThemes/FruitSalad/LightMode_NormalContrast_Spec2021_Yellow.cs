using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_NormalContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#8E4E00";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#FFDCC1";
    public string OnPrimaryContainer => "#6C3A00";

    public string Secondary => "#87521C";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#FFDCC1";
    public string OnSecondaryContainer => "#6B3B04";

    public string Tertiary => "#626117";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#E9E78E";
    public string OnTertiaryContainer => "#4A4900";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#FEFAE3";
    public string OnSurface => "#1D1C0E";
    public string OnSurfaceVariant => "#49482D";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F8F4DD";
    public string SurfaceContainer => "#F2EFD8";
    public string SurfaceContainerHigh => "#ECE9D2";
    public string SurfaceContainerHighest => "#E6E3CD";
}
