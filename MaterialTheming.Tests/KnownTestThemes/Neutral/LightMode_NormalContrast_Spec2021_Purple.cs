using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_NormalContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#645B6A";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#EBDEF0";
    public string OnPrimaryContainer => "#4C4452";

    public string Secondary => "#625C65";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#E9DFEB";
    public string OnSecondaryContainer => "#4A454E";

    public string Tertiary => "#665A6F";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#EDDDF6";
    public string OnTertiaryContainer => "#4D4357";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#FDF8FA";
    public string OnSurface => "#1C1B1D";
    public string OnSurfaceVariant => "#484648";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F8F2F4";
    public string SurfaceContainer => "#F2ECEE";
    public string SurfaceContainerHigh => "#ECE7E9";
    public string SurfaceContainerHighest => "#E6E1E3";
}
