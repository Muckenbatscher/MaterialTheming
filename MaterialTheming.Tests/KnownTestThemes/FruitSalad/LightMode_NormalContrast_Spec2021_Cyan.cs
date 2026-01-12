using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_NormalContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#006D43";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#92F7BC";
    public string OnPrimaryContainer => "#005231";

    public string Secondary => "#286A48";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#ADF2C6";
    public string OnSecondaryContainer => "#065232";

    public string Tertiary => "#006875";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#9EEFFE";
    public string OnTertiaryContainer => "#004F58";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#EEFCFF";
    public string OnSurface => "#111D20";
    public string OnSurfaceVariant => "#334B4F";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#E9F6F9";
    public string SurfaceContainer => "#E3F0F3";
    public string SurfaceContainerHigh => "#DDEBED";
    public string SurfaceContainerHighest => "#D7E5E8";
}
