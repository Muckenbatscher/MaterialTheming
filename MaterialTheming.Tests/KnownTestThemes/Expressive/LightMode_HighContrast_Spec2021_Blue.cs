using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_HighContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#0A3400";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#29531A";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#432133";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#633E51";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#1D2955";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#3B4774";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FAF8FF";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F1F0FA";
    public string SurfaceContainer => "#E2E1EC";
    public string SurfaceContainerHigh => "#D4D3DE";
    public string SurfaceContainerHighest => "#C6C5D0";
}
