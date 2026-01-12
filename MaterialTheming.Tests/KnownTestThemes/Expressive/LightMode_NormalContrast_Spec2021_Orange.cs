using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_NormalContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#5C5698";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#E4DFFF";
    public string OnPrimaryContainer => "#443E7F";

    public string Secondary => "#4B6546";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#CCEBC4";
    public string OnSecondaryContainer => "#334D30";

    public string Tertiary => "#2A6953";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#AFF0D4";
    public string OnTertiaryContainer => "#08513C";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#FFF8F5";
    public string OnSurface => "#231A11";
    public string OnSurfaceVariant => "#554433";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1E7";
    public string SurfaceContainer => "#FDEBDC";
    public string SurfaceContainerHigh => "#F8E5D6";
    public string SurfaceContainerHighest => "#F2DFD1";
}
