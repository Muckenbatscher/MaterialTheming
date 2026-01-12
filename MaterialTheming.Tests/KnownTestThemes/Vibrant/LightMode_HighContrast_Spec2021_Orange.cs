using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_HighContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#4B2000";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#783600";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#412605";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#634220";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#3D2800";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#614404";
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
