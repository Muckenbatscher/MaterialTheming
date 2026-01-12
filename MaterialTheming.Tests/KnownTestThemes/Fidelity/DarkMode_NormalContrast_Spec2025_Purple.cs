using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class DarkMode_NormalContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#DCB8FF";
    public string OnPrimary => "#490180";
    public string PrimaryContainer => "#945CCD";
    public string OnPrimaryContainer => "#0B001B";

    public string Secondary => "#D7BCEF";
    public string OnSecondary => "#3C2750";
    public string SecondaryContainer => "#55406B";
    public string OnSecondaryContainer => "#C9AEE0";

    public string Tertiary => "#E1C556";
    public string OnTertiary => "#3A3000";
    public string TertiaryContainer => "#C4AA3D";
    public string OnTertiaryContainer => "#4C3F00";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#161219";
    public string OnSurface => "#E9E0EA";
    public string OnSurfaceVariant => "#CEC3D3";

    public string SurfaceContainerLowest => "#100D14";
    public string SurfaceContainerLow => "#1E1A21";
    public string SurfaceContainer => "#221E25";
    public string SurfaceContainerHigh => "#2D2830";
    public string SurfaceContainerHighest => "#38333B";
}
