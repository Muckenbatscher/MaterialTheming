using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class DarkMode_NormalContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#50D8EC";
    public string OnPrimary => "#00363D";
    public string PrimaryContainer => "#004F58";
    public string OnPrimaryContainer => "#9AF0FF";

    public string Secondary => "#B1CBD0";
    public string OnSecondary => "#1C3438";
    public string SecondaryContainer => "#334B4F";
    public string OnSecondaryContainer => "#CDE7EC";

    public string Tertiary => "#BBC6EA";
    public string OnTertiary => "#252F4D";
    public string TertiaryContainer => "#3B4665";
    public string OnTertiaryContainer => "#DAE2FF";

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
