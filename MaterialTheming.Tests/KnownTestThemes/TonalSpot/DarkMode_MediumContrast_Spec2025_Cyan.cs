using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_MediumContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#9DCFD8";
    public string OnPrimary => "#003C44";
    public string PrimaryContainer => "#4B7C85";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#B1CBD0";
    public string OnSecondary => "#223A3E";
    public string SecondaryContainer => "#60797D";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#D4E7FF";
    public string OnTertiary => "#2C4C6A";
    public string TertiaryContainer => "#BADAFF";
    public string OnTertiaryContainer => "#234361";

    public string Error => "#FF9F99";
    public string OnError => "#60000A";
    public string ErrorContainer => "#C54D4A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#0A0F10";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#B0BBBD";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#0E1416";
    public string SurfaceContainer => "#131B1C";
    public string SurfaceContainerHigh => "#192123";
    public string SurfaceContainerHighest => "#1E2729";
}
