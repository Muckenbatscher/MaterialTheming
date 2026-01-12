using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_NormalContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#686727";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#E9E698";
    public string OnPrimaryContainer => "#555416";

    public string Secondary => "#676648";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#E7E4BF";
    public string OnSecondaryContainer => "#545337";

    public string Tertiary => "#7E5F2B";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#FED494";
    public string OnTertiaryContainer => "#644715";

    public string Error => "#AE4025";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FD795A";
    public string OnErrorContainer => "#6E1400";

    public string Surface => "#FFFBFF";
    public string OnSurface => "#39382B";
    public string OnSurfaceVariant => "#666556";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FDF9EB";
    public string SurfaceContainer => "#F8F4E4";
    public string SurfaceContainerHigh => "#F2EEDD";
    public string SurfaceContainerHighest => "#ECE9D5";
}
