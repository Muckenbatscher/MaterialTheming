using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_MediumContrast_Spec2025_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#C1C9BE";
    public string OnPrimary => "#313830";
    public string PrimaryContainer => "#6F776D";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#B8B9B4";
    public string OnSecondary => "#2A2D29";
    public string SecondaryContainer => "#737571";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#E9FFED";
    public string OnTertiary => "#3F5B49";
    public string TertiaryContainer => "#D3F3DB";
    public string OnTertiaryContainer => "#375341";

    public string Error => "#FFA089";
    public string OnError => "#591001";
    public string ErrorContainer => "#BA573F";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#0E0E0D";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#B9B9B5";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#131412";
    public string SurfaceContainer => "#191A18";
    public string SurfaceContainerHigh => "#1F201E";
    public string SurfaceContainerHighest => "#242624";
}
