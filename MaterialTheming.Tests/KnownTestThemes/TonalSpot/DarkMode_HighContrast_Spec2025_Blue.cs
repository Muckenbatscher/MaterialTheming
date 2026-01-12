using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_HighContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#D9E6FF";
    public string OnPrimary => "#162D4A";
    public string PrimaryContainer => "#90A5C8";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#DCE6FB";
    public string OnSecondary => "#222C3C";
    public string SecondaryContainer => "#9AA4B8";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#ECE0FF";
    public string OnTertiary => "#31254C";
    public string TertiaryContainer => "#DACAFB";
    public string OnTertiaryContainer => "#21163C";

    public string Error => "#FFDEDB";
    public string OnError => "#60000A";
    public string ErrorContainer => "#FF7C76";
    public string OnErrorContainer => "#000000";

    public string Surface => "#0C0E12";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E2E5EF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#111318";
    public string SurfaceContainer => "#171A1F";
    public string SurfaceContainerHigh => "#1C2026";
    public string SurfaceContainerHighest => "#22262D";
}
