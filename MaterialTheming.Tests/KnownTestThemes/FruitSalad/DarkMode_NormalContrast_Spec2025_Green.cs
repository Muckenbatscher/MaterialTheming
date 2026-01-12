using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_NormalContrast_Spec2025_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#DEC74C";
    public string OnPrimary => "#393000";
    public string PrimaryContainer => "#524600";
    public string OnPrimaryContainer => "#FCE365";

    public string Secondary => "#D9C76F";
    public string OnSecondary => "#393000";
    public string SecondaryContainer => "#524600";
    public string OnSecondaryContainer => "#F6E388";

    public string Tertiary => "#9CD49F";
    public string OnTertiary => "#013913";
    public string TertiaryContainer => "#1D5128";
    public string OnTertiaryContainer => "#B8F1B9";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#0D150D";
    public string OnSurface => "#DBE5D7";
    public string OnSurfaceVariant => "#B8CCB5";

    public string SurfaceContainerLowest => "#081008";
    public string SurfaceContainerLow => "#151E15";
    public string SurfaceContainer => "#192219";
    public string SurfaceContainerHigh => "#232C23";
    public string SurfaceContainerHighest => "#2E372D";
}
