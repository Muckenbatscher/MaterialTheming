using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_MediumContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#651738";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#AA4F6F";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#5B2238";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#9D586F";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#5A2802";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#9D5D33";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F5";
    public string OnSurface => "#1B0E07";
    public string OnSurfaceVariant => "#493121";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1EA";
    public string SurfaceContainer => "#FEE3D5";
    public string SurfaceContainerHigh => "#F2D8CA";
    public string SurfaceContainerHighest => "#E6CDBF";
}
