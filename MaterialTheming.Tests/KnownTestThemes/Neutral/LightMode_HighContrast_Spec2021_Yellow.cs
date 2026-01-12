using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_HighContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#2E2D1B";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#4B4A36";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#2D2D21";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#4B4A3C";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#2E2D14";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#4B4A2F";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FDF9F4";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F4F0EB";
    public string SurfaceContainer => "#E6E2DD";
    public string SurfaceContainerHigh => "#D7D4CF";
    public string SurfaceContainerHighest => "#C9C6C2";
}
