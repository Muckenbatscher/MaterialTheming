using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class DarkMode_NormalContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#CECC50";
    public string OnPrimary => "#333200";
    public string PrimaryContainer => "#B2B037";
    public string OnPrimaryContainer => "#434200";

    public string Secondary => "#CCC990";
    public string OnSecondary => "#333207";
    public string SecondaryContainer => "#49491C";
    public string OnSecondaryContainer => "#BAB880";

    public string Tertiary => "#91D882";
    public string OnTertiary => "#003A02";
    public string TertiaryContainer => "#77BC69";
    public string OnTertiaryContainer => "#014B04";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#14140C";
    public string OnSurface => "#E6E3D5";
    public string OnSurfaceVariant => "#CAC7B1";

    public string SurfaceContainerLowest => "#0F0F07";
    public string SurfaceContainerLow => "#1C1C14";
    public string SurfaceContainer => "#202017";
    public string SurfaceContainerHigh => "#2B2A21";
    public string SurfaceContainerHighest => "#36352C";
}
