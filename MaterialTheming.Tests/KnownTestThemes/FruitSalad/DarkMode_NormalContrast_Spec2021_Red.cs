using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_NormalContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#FFABF3";
    public string OnPrimary => "#551353";
    public string PrimaryContainer => "#6F2C6B";
    public string OnPrimaryContainer => "#FFD7F5";

    public string Secondary => "#F1B3E6";
    public string OnSecondary => "#4C1F49";
    public string SecondaryContainer => "#653660";
    public string OnSecondaryContainer => "#FFD7F5";

    public string Tertiary => "#FFB4AB";
    public string OnTertiary => "#561E19";
    public string TertiaryContainer => "#73332D";
    public string OnTertiaryContainer => "#FFDAD6";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#1E100E";
    public string OnSurface => "#F9DCD9";
    public string OnSurfaceVariant => "#E7BDB8";

    public string SurfaceContainerLowest => "#180B09";
    public string SurfaceContainerLow => "#271816";
    public string SurfaceContainer => "#2B1C1A";
    public string SurfaceContainerHigh => "#372624";
    public string SurfaceContainerHighest => "#42302E";
}
