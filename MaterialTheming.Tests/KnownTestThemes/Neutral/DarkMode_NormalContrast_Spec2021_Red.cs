using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_NormalContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#DFBFBB";
    public string OnPrimary => "#402B29";
    public string PrimaryContainer => "#58413F";
    public string OnPrimaryContainer => "#FDDBD7";

    public string Secondary => "#D8C2BF";
    public string OnSecondary => "#3B2D2B";
    public string SecondaryContainer => "#534341";
    public string OnSecondaryContainer => "#F5DDDA";

    public string Tertiary => "#E7BDB8";
    public string OnTertiary => "#442926";
    public string TertiaryContainer => "#5D3F3C";
    public string OnTertiaryContainer => "#FFDAD6";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#161312";
    public string OnSurface => "#E9E1DF";
    public string OnSurfaceVariant => "#CCC5C4";

    public string SurfaceContainerLowest => "#100D0D";
    public string SurfaceContainerLow => "#1E1B1A";
    public string SurfaceContainer => "#221F1E";
    public string SurfaceContainerHigh => "#2D2929";
    public string SurfaceContainerHighest => "#383433";
}
