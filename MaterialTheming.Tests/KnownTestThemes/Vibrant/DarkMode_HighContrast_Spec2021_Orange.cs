using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_HighContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#FFECE3";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#FFB181";
    public string OnPrimaryContainer => "#190600";

    public string Secondary => "#FFEDDE";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#E8BA8D";
    public string OnSecondaryContainer => "#150800";

    public string Tertiary => "#FFEED6";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#E7BC74";
    public string OnTertiaryContainer => "#120A00";

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
