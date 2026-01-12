using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_MediumContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#B2C8ED";
    public string OnPrimary => "#213755";
    public string PrimaryContainer => "#617597";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#BDC7DC";
    public string OnSecondary => "#2D3747";
    public string SecondaryContainer => "#6B7588";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#E7DAFF";
    public string OnTertiary => "#4B4068";
    public string TertiaryContainer => "#DACAFB";
    public string OnTertiaryContainer => "#42375F";

    public string Error => "#FF9F99";
    public string OnError => "#60000A";
    public string ErrorContainer => "#C54D4A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#0C0E12";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#B5B9C2";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#111318";
    public string SurfaceContainer => "#171A1F";
    public string SurfaceContainerHigh => "#1C2026";
    public string SurfaceContainerHighest => "#22262D";
}
