using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class LightMode_HighContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#2E2E00";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#4D4C00";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#2E2E04";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#4C4B1E";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#3A146D";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#59368D";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FDF9EB";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F5F1E3";
    public string SurfaceContainer => "#E6E3D5";
    public string SurfaceContainerHigh => "#D8D4C7";
    public string SurfaceContainerHighest => "#CAC7B9";
}
