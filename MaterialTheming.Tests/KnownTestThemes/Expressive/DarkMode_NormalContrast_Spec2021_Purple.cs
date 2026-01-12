using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_NormalContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#73D7CE";
    public string OnPrimary => "#003734";
    public string PrimaryContainer => "#00504B";
    public string OnPrimaryContainer => "#90F3EA";

    public string Secondary => "#EEB8CB";
    public string OnSecondary => "#492534";
    public string SecondaryContainer => "#623B4B";
    public string OnSecondaryContainer => "#FFD9E5";

    public string Tertiary => "#E9B6E6";
    public string OnTertiary => "#472348";
    public string TertiaryContainer => "#603960";
    public string OnTertiaryContainer => "#FFD6FA";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#181118";
    public string OnSurface => "#ECDFE9";
    public string OnSurfaceVariant => "#D3C1D1";

    public string SurfaceContainerLowest => "#120C13";
    public string SurfaceContainerLow => "#201920";
    public string SurfaceContainer => "#241D24";
    public string SurfaceContainerHigh => "#2F282F";
    public string SurfaceContainerHighest => "#3A323A";
}
