using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_NormalContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#8A4484";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#FFD7F5";
    public string OnPrimaryContainer => "#6F2C6B";

    public string Secondary => "#804D79";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#FFD7F5";
    public string OnSecondaryContainer => "#653660";

    public string Tertiary => "#904A43";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#FFDAD6";
    public string OnTertiaryContainer => "#73332D";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#FFF8F7";
    public string OnSurface => "#271816";
    public string OnSurfaceVariant => "#5D3F3C";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0EE";
    public string SurfaceContainer => "#FFE9E6";
    public string SurfaceContainerHigh => "#FFE2DE";
    public string SurfaceContainerHighest => "#F9DCD9";
}
