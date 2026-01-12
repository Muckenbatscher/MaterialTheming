using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_HighContrast_Spec2025 : ITestTheme
{
    public string SourceColor => "#D77837"; //orange
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#FFEBEF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#FFABC4";
    public string OnPrimaryContainer => "#20000C";

    public string Secondary => "#FFEBEF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#FEABC4";
    public string OnSecondaryContainer => "#20000C";

    public string Tertiary => "#FFECE3";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#FFB181";
    public string OnTertiaryContainer => "#190600";

    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";

    public string Surface => "#1D1009";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#2A1D14";
    public string SurfaceContainer => "#3D2D24";
    public string SurfaceContainerHigh => "#48382E";
    public string SurfaceContainerHighest => "#554339";
}
