using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_MediumContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#D1F8FF";
    public string OnPrimary => "#005964";
    public string PrimaryContainer => "#9EEFFE";
    public string OnPrimaryContainer => "#00505A";

    public string Secondary => "#CFC2DA";
    public string OnSecondary => "#3B3246";
    public string SecondaryContainer => "#7B7086";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#DEB7FF";
    public string OnTertiary => "#4B2070";
    public string TertiaryContainer => "#D5A5FE";
    public string OnTertiaryContainer => "#401465";

    public string Error => "#FF9F99";
    public string OnError => "#60000A";
    public string ErrorContainer => "#C94947";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#001116";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#99BFCC";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#00161D";
    public string SurfaceContainer => "#001D25";
    public string SurfaceContainerHigh => "#00232C";
    public string SurfaceContainerHighest => "#002A34";
}
