using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_MediumContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#C0C7D5";
    public string OnPrimary => "#303642";
    public string PrimaryContainer => "#6E7582";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#B7B8BF";
    public string OnSecondary => "#2A2C31";
    public string SecondaryContainer => "#73747A";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#EBE9FF";
    public string OnTertiary => "#4A4B65";
    public string TertiaryContainer => "#DBDAFB";
    public string OnTertiaryContainer => "#41425C";

    public string Error => "#FF9F99";
    public string OnError => "#5B0D10";
    public string ErrorContainer => "#BB5551";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#0E0E0F";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#B9B8BB";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#131314";
    public string SurfaceContainer => "#19191B";
    public string SurfaceContainerHigh => "#1F1F21";
    public string SurfaceContainerHighest => "#252628";
}
