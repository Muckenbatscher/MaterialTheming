using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_HighContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#501538";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#733356";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#12321D";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#305038";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#1F3103";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#3B4F1D";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FAFBEA";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F1F2E2";
    public string SurfaceContainer => "#E2E4D4";
    public string SurfaceContainerHigh => "#D4D6C6";
    public string SurfaceContainerHighest => "#C6C8B8";
}
