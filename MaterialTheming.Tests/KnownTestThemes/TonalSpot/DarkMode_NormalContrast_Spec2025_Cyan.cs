using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_NormalContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#9DCFD8";
    public string OnPrimary => "#0E474F";
    public string PrimaryContainer => "#265962";
    public string OnPrimaryContainer => "#B9ECF6";

    public string Secondary => "#B1CBD0";
    public string OnSecondary => "#2C4448";
    public string SecondaryContainer => "#273F43";
    public string OnSecondaryContainer => "#AAC4C9";

    public string Tertiary => "#D4E7FF";
    public string OnTertiary => "#375675";
    public string TertiaryContainer => "#BADAFF";
    public string OnTertiaryContainer => "#2E4D6C";

    public string Error => "#FA746F";
    public string OnError => "#490006";
    public string ErrorContainer => "#871F21";
    public string OnErrorContainer => "#FF9993";

    public string Surface => "#0A0F10";
    public string OnSurface => "#DDE7E9";
    public string OnSurfaceVariant => "#A2ADAF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#0E1416";
    public string SurfaceContainer => "#131B1C";
    public string SurfaceContainerHigh => "#192123";
    public string SurfaceContainerHighest => "#1E2729";
}
