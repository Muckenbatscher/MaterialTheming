using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_NormalContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#D1F8FF";
    public string OnPrimary => "#00646F";
    public string PrimaryContainer => "#9EEFFE";
    public string OnPrimaryContainer => "#005B65";

    public string Secondary => "#CFC2DA";
    public string OnSecondary => "#453C50";
    public string SecondaryContainer => "#2A2235";
    public string OnSecondaryContainer => "#AB9FB7";

    public string Tertiary => "#DEB7FF";
    public string OnTertiary => "#552B7B";
    public string TertiaryContainer => "#D5A5FE";
    public string OnTertiaryContainer => "#4B2171";

    public string Error => "#FF716C";
    public string OnError => "#490006";
    public string ErrorContainer => "#8A1A1E";
    public string OnErrorContainer => "#FF9993";

    public string Surface => "#001116";
    public string OnSurface => "#C5ECFA";
    public string OnSurfaceVariant => "#8CB1BE";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#00161D";
    public string SurfaceContainer => "#001D25";
    public string SurfaceContainerHigh => "#00232C";
    public string SurfaceContainerHighest => "#002A34";
}
