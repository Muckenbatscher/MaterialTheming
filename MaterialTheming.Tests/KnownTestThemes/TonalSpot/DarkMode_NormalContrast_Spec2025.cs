using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_NormalContrast_Spec2025 : ITestTheme
{
    public string SourceColor => "#338745"; //green
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#ABD0AA";
    public string OnPrimary => "#27472B";
    public string PrimaryContainer => "#395A3C";
    public string OnPrimaryContainer => "#C7EDC6";

    public string Secondary => "#B8CCB5";
    public string OnSecondary => "#334434";
    public string SecondaryContainer => "#2F402F";
    public string OnSecondaryContainer => "#B1C5AE";

    public string Tertiary => "#F8FFBC";
    public string OnTertiary => "#5C632F";
    public string TertiaryContainer => "#E9F0AF";
    public string OnTertiaryContainer => "#545B28";

    public string Error => "#F97758";
    public string OnError => "#450900";
    public string ErrorContainer => "#85230A";
    public string OnErrorContainer => "#FF9B82";

    public string Surface => "#0C0F0B";
    public string OnSurface => "#E0E8DC";
    public string OnSurfaceVariant => "#A5ADA2";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#101510";
    public string SurfaceContainer => "#151B15";
    public string SurfaceContainerHigh => "#1B211B";
    public string SurfaceContainerHighest => "#202820";
}
