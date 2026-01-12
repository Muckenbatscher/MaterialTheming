using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_NormalContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#006A64";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#90F3EA";
    public string OnPrimaryContainer => "#00504B";

    public string Secondary => "#7C5263";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#FFD9E5";
    public string OnSecondaryContainer => "#623B4B";

    public string Tertiary => "#7A5079";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#FFD6FA";
    public string OnTertiaryContainer => "#603960";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#FFF7FA";
    public string OnSurface => "#201920";
    public string OnSurfaceVariant => "#4F4350";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FDF0FA";
    public string SurfaceContainer => "#F8EAF4";
    public string SurfaceContainerHigh => "#F2E4EE";
    public string SurfaceContainerHighest => "#ECDFE9";
}
