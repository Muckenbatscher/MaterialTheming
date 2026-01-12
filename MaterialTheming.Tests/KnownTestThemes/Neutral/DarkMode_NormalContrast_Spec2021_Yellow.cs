using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_NormalContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#CAC7AD";
    public string OnPrimary => "#32311F";
    public string PrimaryContainer => "#494833";
    public string OnPrimaryContainer => "#E7E3C8";

    public string Secondary => "#CAC7B6";
    public string OnSecondary => "#323125";
    public string SecondaryContainer => "#48473A";
    public string OnSecondaryContainer => "#E6E3D1";

    public string Tertiary => "#CBC8A4";
    public string OnTertiary => "#323218";
    public string TertiaryContainer => "#49482D";
    public string OnTertiaryContainer => "#E7E4BF";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#141311";
    public string OnSurface => "#E6E2DD";
    public string OnSurfaceVariant => "#C9C6C2";

    public string SurfaceContainerLowest => "#0F0E0C";
    public string SurfaceContainerLow => "#1C1C19";
    public string SurfaceContainer => "#20201D";
    public string SurfaceContainerHigh => "#2B2A27";
    public string SurfaceContainerHighest => "#363532";
}
