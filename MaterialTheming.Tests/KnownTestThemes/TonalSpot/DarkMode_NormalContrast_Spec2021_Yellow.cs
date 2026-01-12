using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_NormalContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#CDCA75";
    public string OnPrimary => "#333200";
    public string PrimaryContainer => "#4A4900";
    public string OnPrimaryContainer => "#E9E78E";

    public string Secondary => "#CBC8A4";
    public string OnSecondary => "#323218";
    public string SecondaryContainer => "#49482D";
    public string OnSecondaryContainer => "#E7E4BF";

    public string Tertiary => "#A4D0BC";
    public string OnTertiary => "#0C3729";
    public string TertiaryContainer => "#264E3F";
    public string OnTertiaryContainer => "#C0ECD7";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#14140C";
    public string OnSurface => "#E6E2D5";
    public string OnSurfaceVariant => "#CAC7B6";

    public string SurfaceContainerLowest => "#0F0E07";
    public string SurfaceContainerLow => "#1C1C14";
    public string SurfaceContainer => "#202018";
    public string SurfaceContainerHigh => "#2B2A22";
    public string SurfaceContainerHighest => "#36352C";
}
