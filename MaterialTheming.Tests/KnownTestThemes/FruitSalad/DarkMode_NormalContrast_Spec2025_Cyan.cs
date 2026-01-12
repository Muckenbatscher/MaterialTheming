using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_NormalContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#76DAA2";
    public string OnPrimary => "#003920";
    public string PrimaryContainer => "#005231";
    public string OnPrimaryContainer => "#92F7BC";

    public string Secondary => "#92D5AB";
    public string OnSecondary => "#003920";
    public string SecondaryContainer => "#065232";
    public string OnSecondaryContainer => "#ADF2C6";

    public string Tertiary => "#82D3E1";
    public string OnTertiary => "#00363D";
    public string TertiaryContainer => "#004F58";
    public string OnTertiaryContainer => "#9EEFFE";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#091517";
    public string OnSurface => "#D7E5E8";
    public string OnSurfaceVariant => "#B1CBD0";

    public string SurfaceContainerLowest => "#051012";
    public string SurfaceContainerLow => "#111D20";
    public string SurfaceContainer => "#152224";
    public string SurfaceContainerHigh => "#202C2E";
    public string SurfaceContainerHighest => "#2B3739";
}
