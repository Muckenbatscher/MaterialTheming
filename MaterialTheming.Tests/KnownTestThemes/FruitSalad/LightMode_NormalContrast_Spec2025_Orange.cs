using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_NormalContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#984061";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#FFD9E2";
    public string OnPrimaryContainer => "#7B2949";

    public string Secondary => "#8C4A60";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#FFD9E2";
    public string OnSecondaryContainer => "#703348";

    public string Tertiary => "#8C4F26";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#FFDBC8";
    public string OnTertiaryContainer => "#6F3811";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#FFF8F5";
    public string OnSurface => "#261910";
    public string OnSurfaceVariant => "#5C4131";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1EA";
    public string SurfaceContainer => "#FFEADF";
    public string SurfaceContainerHigh => "#FEE3D5";
    public string SurfaceContainerHighest => "#F8DDD0";
}
