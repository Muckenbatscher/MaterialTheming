using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class DarkMode_NormalContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#DCB8FF";
    public string OnPrimary => "#431A6B";
    public string PrimaryContainer => "#5B3383";
    public string OnPrimaryContainer => "#F0DBFF";

    public string Secondary => "#D0C1DA";
    public string OnSecondary => "#362C3F";
    public string SecondaryContainer => "#4D4357";
    public string OnSecondaryContainer => "#EDDDF6";

    public string Tertiary => "#F3B7BE";
    public string OnTertiary => "#4B252B";
    public string TertiaryContainer => "#653A41";
    public string OnTertiaryContainer => "#FFD9DD";

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
