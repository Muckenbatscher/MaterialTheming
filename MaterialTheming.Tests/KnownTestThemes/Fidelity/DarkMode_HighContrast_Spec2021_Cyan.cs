using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class DarkMode_HighContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#CEF7FF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#3FD4EA";
    public string OnPrimaryContainer => "#000E10";

    public string Secondary => "#CEF7FF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#9BCBD3";
    public string OnSecondaryContainer => "#000E10";

    public string Tertiary => "#FFECE2";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#FFB177";
    public string OnTertiaryContainer => "#170700";

    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";

    public string Surface => "#0E1416";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1A2122";
    public string SurfaceContainer => "#2B3133";
    public string SurfaceContainerHigh => "#363C3E";
    public string SurfaceContainerHighest => "#414849";
}
