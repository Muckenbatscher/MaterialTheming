using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_HighContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#C5FEC6";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#99D09B";
    public string OnPrimaryContainer => "#000F02";

    public string Secondary => "#E1F6DE";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#B4C8B2";
    public string OnSecondaryContainer => "#020E03";

    public string Tertiary => "#CEF7FF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#9DCAD2";
    public string OnTertiaryContainer => "#000E10";

    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";

    public string Surface => "#101510";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1C211C";
    public string SurfaceContainer => "#2D322C";
    public string SurfaceContainerHigh => "#383D37";
    public string SurfaceContainerHighest => "#434842";
}
