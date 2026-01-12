using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class DarkMode_NormalContrast_Spec2025 : ITestTheme
{
    public string SourceColor => "#338745"; //green
    public bool IsDark => true;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#88D990";
    public string OnPrimary => "#003913";
    public string PrimaryContainer => "#00531F";
    public string OnPrimaryContainer => "#A3F5AA";

    public string Secondary => "#B8CCB5";
    public string OnSecondary => "#243424";
    public string SecondaryContainer => "#3A4B3A";
    public string OnSecondaryContainer => "#D4E8D1";

    public string Tertiary => "#A1CED6";
    public string OnTertiary => "#00363D";
    public string TertiaryContainer => "#1F4D54";
    public string OnTertiaryContainer => "#BDEAF3";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#131313";
    public string OnSurface => "#E2E2E2";
    public string OnSurfaceVariant => "#C6C6C6";

    public string SurfaceContainerLowest => "#0E0E0E";
    public string SurfaceContainerLow => "#1B1B1B";
    public string SurfaceContainer => "#1F1F1F";
    public string SurfaceContainerHigh => "#2A2A2A";
    public string SurfaceContainerHighest => "#353535";
}
