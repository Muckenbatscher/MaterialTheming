using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_HighContrast_Spec2025 : ITestTheme
{
    public string SourceColor => "#D77837"; //orange
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#2D211B";
    public string OnPrimary => "#EBD6CB";
    public string PrimaryContainer => "#5E4F47";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#29231F";
    public string OnSecondary => "#E4D8D2";
    public string SecondaryContainer => "#58504D";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#322104";
    public string OnTertiary => "#F6D5A9";
    public string TertiaryContainer => "#654E2D";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#4C0A00";
    public string OnError => "#FFCFC4";
    public string ErrorContainer => "#8D3621";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F6";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#282320";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FAF2EF";
    public string SurfaceContainer => "#F5ECE9";
    public string SurfaceContainerHigh => "#F0E6E2";
    public string SurfaceContainerHighest => "#EBE0DC";
}
