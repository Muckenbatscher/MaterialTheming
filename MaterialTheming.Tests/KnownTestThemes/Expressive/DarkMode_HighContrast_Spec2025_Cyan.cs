using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_HighContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#D1F8FF";
    public string OnPrimary => "#003940";
    public string PrimaryContainer => "#9EEFFE";
    public string OnPrimaryContainer => "#002F35";

    public string Secondary => "#EEE0FA";
    public string OnSecondary => "#31283B";
    public string SecondaryContainer => "#AB9FB7";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#F3DEFF";
    public string OnTertiary => "#401465";
    public string TertiaryContainer => "#D5A5FE";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFDEDB";
    public string OnError => "#60000A";
    public string ErrorContainer => "#FF7C76";
    public string OnErrorContainer => "#000000";

    public string Surface => "#001116";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#C5ECFA";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#00161D";
    public string SurfaceContainer => "#001D25";
    public string SurfaceContainerHigh => "#00232C";
    public string SurfaceContainerHighest => "#002A34";
}
