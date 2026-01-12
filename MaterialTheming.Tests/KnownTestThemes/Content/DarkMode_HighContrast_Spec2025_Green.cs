using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class DarkMode_HighContrast_Spec2025_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#C2FFC4";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#80D58A";
    public string OnPrimaryContainer => "#000801";

    public string Secondary => "#D5FAD3";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#A9CCA8";
    public string OnSecondaryContainer => "#000F02";

    public string Tertiary => "#E8F0FF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#96C6FF";
    public string OnTertiaryContainer => "#000712";

    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";

    public string Surface => "#101510";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1C211B";
    public string SurfaceContainer => "#2D322C";
    public string SurfaceContainerHigh => "#383D37";
    public string SurfaceContainerHighest => "#434842";
}
