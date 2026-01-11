using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_HighContrast_Spec2021 : ITestTheme
{
    public string SourceColor => "#D77837"; //orange
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#580B2E";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#7E2B4B";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#4F182E";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#73354B";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#4B2000";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#723A13";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F5";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFEDE5";
    public string SurfaceContainer => "#F8DDD0";
    public string SurfaceContainerHigh => "#E9CFC2";
    public string SurfaceContainerHighest => "#DBC2B4";
}
