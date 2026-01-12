using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_HighContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#DFE5F5";
    public string OnPrimary => "#262C38";
    public string PrimaryContainer => "#9DA4B2";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#E4E5EC";
    public string OnSecondary => "#2A2C31";
    public string SecondaryContainer => "#A2A3AA";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#EBE9FF";
    public string OnTertiary => "#2C2D46";
    public string TertiaryContainer => "#DBDAFB";
    public string OnTertiaryContainer => "#23243C";

    public string Error => "#FFDEDB";
    public string OnError => "#5A0D10";
    public string ErrorContainer => "#F5827C";
    public string OnErrorContainer => "#000000";

    public string Surface => "#0E0E0F";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E6E5E7";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#131314";
    public string SurfaceContainer => "#19191B";
    public string SurfaceContainerHigh => "#1F1F21";
    public string SurfaceContainerHighest => "#252628";
}
