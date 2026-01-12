using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_HighContrast_Spec2025_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#E0E8DC";
    public string OnPrimary => "#272E26";
    public string PrimaryContainer => "#9EA69B";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#E5E6E0";
    public string OnSecondary => "#2A2D29";
    public string SecondaryContainer => "#A2A49F";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#E9FFED";
    public string OnTertiary => "#233E2D";
    public string TertiaryContainer => "#D3F3DB";
    public string OnTertiaryContainer => "#1A3525";

    public string Error => "#FFDED7";
    public string OnError => "#591001";
    public string ErrorContainer => "#F48469";
    public string OnErrorContainer => "#000000";

    public string Surface => "#0E0E0D";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E6E6E1";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#131412";
    public string SurfaceContainer => "#191A18";
    public string SurfaceContainerHigh => "#1F201E";
    public string SurfaceContainerHighest => "#242624";
}
