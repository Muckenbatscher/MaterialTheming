using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_NormalContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#8900EA";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#F0DBFF";
    public string OnPrimaryContainer => "#6800B4";

    public string Secondary => "#6F5675";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#F9D8FE";
    public string OnSecondaryContainer => "#563E5C";

    public string Tertiary => "#7C4F76";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#FFD7F5";
    public string OnTertiaryContainer => "#62385D";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#FFF7FE";
    public string OnSurface => "#1F1923";
    public string OnSurfaceVariant => "#4C4452";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FBF0FF";
    public string SurfaceContainer => "#F5EAF9";
    public string SurfaceContainerHigh => "#F0E5F3";
    public string SurfaceContainerHighest => "#EADFED";
}
