using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_NormalContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#CEC2D4";
    public string OnPrimary => "#352E3B";
    public string PrimaryContainer => "#4C4452";
    public string OnPrimaryContainer => "#EBDEF0";

    public string Secondary => "#CCC4CE";
    public string OnSecondary => "#332F37";
    public string SecondaryContainer => "#4A454E";
    public string OnSecondaryContainer => "#E9DFEB";

    public string Tertiary => "#D0C1DA";
    public string OnTertiary => "#362C3F";
    public string TertiaryContainer => "#4D4357";
    public string OnTertiaryContainer => "#EDDDF6";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#141314";
    public string OnSurface => "#E6E1E3";
    public string OnSurfaceVariant => "#CAC5C7";

    public string SurfaceContainerLowest => "#0F0E0F";
    public string SurfaceContainerLow => "#1C1B1D";
    public string SurfaceContainer => "#211F21";
    public string SurfaceContainerHigh => "#2B292B";
    public string SurfaceContainerHighest => "#363436";
}
