using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_HighContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#BBEEF8";
    public string OnPrimary => "#003138";
    public string PrimaryContainer => "#7AACB5";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#D0EAEF";
    public string OnSecondary => "#173034";
    public string SecondaryContainer => "#8FA8AD";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#D4E7FF";
    public string OnTertiary => "#082E4B";
    public string TertiaryContainer => "#BADAFF";
    public string OnTertiaryContainer => "#00233E";

    public string Error => "#FFDEDB";
    public string OnError => "#60000A";
    public string ErrorContainer => "#FF7C76";
    public string OnErrorContainer => "#000000";

    public string Surface => "#0A0F10";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#DDE7E9";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#0E1416";
    public string SurfaceContainer => "#131B1C";
    public string SurfaceContainerHigh => "#192123";
    public string SurfaceContainerHighest => "#1E2729";
}
