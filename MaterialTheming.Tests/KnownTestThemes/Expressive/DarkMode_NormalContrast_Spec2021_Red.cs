using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_NormalContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#ACC7FF";
    public string OnPrimary => "#002F67";
    public string PrimaryContainer => "#22467F";
    public string OnPrimaryContainer => "#D7E2FF";

    public string Secondary => "#C4CB97";
    public string OnSecondary => "#2D330D";
    public string SecondaryContainer => "#444A22";
    public string OnSecondaryContainer => "#E0E7B1";

    public string Tertiary => "#A7D29E";
    public string OnTertiary => "#133813";
    public string TertiaryContainer => "#2A4F27";
    public string OnTertiaryContainer => "#C3EEB8";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#1C110D";
    public string OnSurface => "#F5DED6";
    public string OnSurfaceVariant => "#DFC0B5";

    public string SurfaceContainerLowest => "#160C08";
    public string SurfaceContainerLow => "#251914";
    public string SurfaceContainer => "#291D18";
    public string SurfaceContainerHigh => "#342722";
    public string SurfaceContainerHighest => "#40322D";
}
