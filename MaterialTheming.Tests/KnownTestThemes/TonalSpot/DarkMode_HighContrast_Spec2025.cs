using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_HighContrast_Spec2025 : ITestTheme
{
    public string SourceColor => "#338745"; //green
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#C9EFC8";
    public string OnPrimary => "#133218";
    public string PrimaryContainer => "#89AD89";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#D7EBD3";
    public string OnSecondary => "#1F3020";
    public string SecondaryContainer => "#96A993";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#F8FFBC";
    public string OnTertiary => "#363B0C";
    public string TertiaryContainer => "#E9F0AF";
    public string OnTertiaryContainer => "#2D3304";

    public string Error => "#FFDED7";
    public string OnError => "#5A0E00";
    public string ErrorContainer => "#FF7E5E";
    public string OnErrorContainer => "#000000";

    public string Surface => "#0C0F0B";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E0E8DC";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#101510";
    public string SurfaceContainer => "#151B15";
    public string SurfaceContainerHigh => "#1B211B";
    public string SurfaceContainerHighest => "#202820";
}
