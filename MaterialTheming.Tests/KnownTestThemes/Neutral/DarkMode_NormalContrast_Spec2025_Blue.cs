using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_NormalContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#C0C7D5";
    public string OnPrimary => "#3A404C";
    public string PrimaryContainer => "#404753";
    public string OnPrimaryContainer => "#CAD0DF";

    public string Secondary => "#9C9EA4";
    public string OnSecondary => "#1E2025";
    public string SecondaryContainer => "#393B41";
    public string OnSecondaryContainer => "#BEBFC5";

    public string Tertiary => "#EBE9FF";
    public string OnTertiary => "#54546F";
    public string TertiaryContainer => "#DBDAFB";
    public string OnTertiaryContainer => "#4B4C67";

    public string Error => "#EE7D77";
    public string OnError => "#490106";
    public string ErrorContainer => "#7F2927";
    public string OnErrorContainer => "#FF9993";

    public string Surface => "#0E0E0F";
    public string OnSurface => "#E6E5E7";
    public string OnSurfaceVariant => "#ABAAAD";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#131314";
    public string SurfaceContainer => "#19191B";
    public string SurfaceContainerHigh => "#1F1F21";
    public string SurfaceContainerHighest => "#252628";
}
