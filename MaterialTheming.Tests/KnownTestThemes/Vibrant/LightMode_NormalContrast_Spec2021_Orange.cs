using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_NormalContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#994700";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#FFDBC8";
    public string OnPrimaryContainer => "#743400";

    public string Secondary => "#7A5732";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#FFDCBD";
    public string OnSecondaryContainer => "#60401D";

    public string Tertiary => "#79591B";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#FFDEAA";
    public string OnTertiaryContainer => "#5F4102";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#FFF8F5";
    public string OnSurface => "#261910";
    public string OnSurfaceVariant => "#574236";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1EA";
    public string SurfaceContainer => "#FFEADF";
    public string SurfaceContainerHigh => "#FEE3D5";
    public string SurfaceContainerHighest => "#F8DDD0";
}
