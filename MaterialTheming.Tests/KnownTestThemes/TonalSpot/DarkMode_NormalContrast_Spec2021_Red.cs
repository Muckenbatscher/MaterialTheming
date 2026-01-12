using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_NormalContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#FFB4AB";
    public string OnPrimary => "#561E19";
    public string PrimaryContainer => "#73332D";
    public string OnPrimaryContainer => "#FFDAD6";

    public string Secondary => "#E7BDB8";
    public string OnSecondary => "#442926";
    public string SecondaryContainer => "#5D3F3C";
    public string OnSecondaryContainer => "#FFDAD6";

    public string Tertiary => "#E0C38C";
    public string OnTertiary => "#3F2E04";
    public string TertiaryContainer => "#584419";
    public string OnTertiaryContainer => "#FDDFA6";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#1A1110";
    public string OnSurface => "#F1DEDC";
    public string OnSurfaceVariant => "#D8C2BF";

    public string SurfaceContainerLowest => "#140C0B";
    public string SurfaceContainerLow => "#231918";
    public string SurfaceContainer => "#271D1C";
    public string SurfaceContainerHigh => "#322826";
    public string SurfaceContainerHighest => "#3D3231";
}
