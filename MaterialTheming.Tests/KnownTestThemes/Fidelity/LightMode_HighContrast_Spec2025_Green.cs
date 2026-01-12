using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class LightMode_HighContrast_Spec2025_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#003411";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#005520";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#143219";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#325034";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#5A0827";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#812944";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#F6FBF2";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#EEF2E9";
    public string SurfaceContainer => "#DFE4DB";
    public string SurfaceContainerHigh => "#D1D6CD";
    public string SurfaceContainerHighest => "#C3C8BF";
}
