using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_NormalContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#FFB4AB";
    public string OnPrimary => "#690005";
    public string PrimaryContainer => "#93000B";
    public string OnPrimaryContainer => "#FFDAD6";

    public string Secondary => "#F4B9A0";
    public string OnSecondary => "#4B2715";
    public string SecondaryContainer => "#653C2A";
    public string OnSecondaryContainer => "#FFDBCD";

    public string Tertiary => "#FAB982";
    public string OnTertiary => "#4C2700";
    public string TertiaryContainer => "#683C10";
    public string OnTertiaryContainer => "#FFDCC2";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#1E100E";
    public string OnSurface => "#F9DCD9";
    public string OnSurfaceVariant => "#DFBFBB";

    public string SurfaceContainerLowest => "#180B09";
    public string SurfaceContainerLow => "#271816";
    public string SurfaceContainer => "#2B1C1A";
    public string SurfaceContainerHigh => "#372624";
    public string SurfaceContainerHighest => "#42302E";
}
