using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_MediumContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#98E9F8";
    public string OnPrimary => "#002A30";
    public string PrimaryContainer => "#499CAA";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#C7E1E6";
    public string OnSecondary => "#10292D";
    public string SecondaryContainer => "#7C959A";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#D1DBFF";
    public string OnTertiary => "#192541";
    public string TertiaryContainer => "#8590B2";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#0E1416";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#D4DEE0";

    public string SurfaceContainerLowest => "#040809";
    public string SurfaceContainerLow => "#191F20";
    public string SurfaceContainer => "#23292A";
    public string SurfaceContainerHigh => "#2E3435";
    public string SurfaceContainerHighest => "#393F40";
}
