using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_HighContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#FFFCC6";
    public string OnPrimary => "#3B3A00";
    public string PrimaryContainer => "#F5F200";
    public string OnPrimaryContainer => "#323100";

    public string Secondary => "#FFE485";
    public string OnSecondary => "#352B00";
    public string SecondaryContainer => "#C1A100";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#FFE2A9";
    public string OnTertiary => "#3A2900";
    public string TertiaryContainer => "#F7BE26";
    public string OnTertiaryContainer => "#191000";

    public string Error => "#FFDED7";
    public string OnError => "#5A0E00";
    public string ErrorContainer => "#FF7E5E";
    public string OnErrorContainer => "#000000";

    public string Surface => "#130E00";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#F9E59F";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#191300";
    public string SurfaceContainer => "#201900";
    public string SurfaceContainerHigh => "#271F00";
    public string SurfaceContainerHighest => "#2E2500";
}
