using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_NormalContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#B2C8ED";
    public string OnPrimary => "#2C415F";
    public string PrimaryContainer => "#3F5373";
    public string OnPrimaryContainer => "#D6E4FF";

    public string Secondary => "#BDC7DC";
    public string OnSecondary => "#374151";
    public string SecondaryContainer => "#323C4C";
    public string OnSecondaryContainer => "#B5C0D4";

    public string Tertiary => "#E7DAFF";
    public string OnTertiary => "#554972";
    public string TertiaryContainer => "#DACAFB";
    public string OnTertiaryContainer => "#4D4169";

    public string Error => "#FA746F";
    public string OnError => "#490006";
    public string ErrorContainer => "#871F21";
    public string OnErrorContainer => "#FF9993";

    public string Surface => "#0C0E12";
    public string OnSurface => "#E2E5EF";
    public string OnSurfaceVariant => "#A8ABB4";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#111318";
    public string SurfaceContainer => "#171A1F";
    public string SurfaceContainerHigh => "#1C2026";
    public string SurfaceContainerHighest => "#22262D";
}
