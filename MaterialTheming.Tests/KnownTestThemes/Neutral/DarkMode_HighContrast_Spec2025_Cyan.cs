using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_HighContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#DEE7E9";
    public string OnPrimary => "#252E2F";
    public string PrimaryContainer => "#9CA5A7";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#E4E6E6";
    public string OnSecondary => "#292D2D";
    public string SecondaryContainer => "#A1A4A5";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#EFF8FF";
    public string OnTertiary => "#1F3A48";
    public string TertiaryContainer => "#D0ECFF";
    public string OnTertiaryContainer => "#16313F";

    public string Error => "#FFDEDB";
    public string OnError => "#5A0D10";
    public string ErrorContainer => "#F5827C";
    public string OnErrorContainer => "#000000";

    public string Surface => "#0E0E0E";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E5E5E6";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#121414";
    public string SurfaceContainer => "#181A1A";
    public string SurfaceContainerHigh => "#1E2020";
    public string SurfaceContainerHighest => "#242627";
}
