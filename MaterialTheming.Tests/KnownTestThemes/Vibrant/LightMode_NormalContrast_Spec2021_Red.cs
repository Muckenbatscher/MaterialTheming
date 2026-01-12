using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_NormalContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#C00012";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#FFDAD6";
    public string OnPrimaryContainer => "#93000B";

    public string Secondary => "#81533F";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#FFDBCD";
    public string OnSecondaryContainer => "#653C2A";

    public string Tertiary => "#845325";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#FFDCC2";
    public string OnTertiaryContainer => "#683C10";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#FFF8F7";
    public string OnSurface => "#271816";
    public string OnSurfaceVariant => "#58413F";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0EE";
    public string SurfaceContainer => "#FFE9E6";
    public string SurfaceContainerHigh => "#FFE2DE";
    public string SurfaceContainerHighest => "#F9DCD9";
}
