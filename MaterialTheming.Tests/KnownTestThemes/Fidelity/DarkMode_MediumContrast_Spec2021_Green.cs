using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class DarkMode_MediumContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#99F0A2";
    public string OnPrimary => "#002D0D";
    public string PrimaryContainer => "#4EA25C";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#C2E6C0";
    public string OnSecondary => "#0D2B13";
    public string SecondaryContainer => "#789978";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#FFD1D9";
    public string OnTertiary => "#510121";
    public string TertiaryContainer => "#DA6F8A";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#101510";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#D5DFD1";

    public string SurfaceContainerLowest => "#050805";
    public string SurfaceContainerLow => "#1A1F19";
    public string SurfaceContainer => "#242924";
    public string SurfaceContainerHigh => "#2F342E";
    public string SurfaceContainerHighest => "#3A3F39";
}
