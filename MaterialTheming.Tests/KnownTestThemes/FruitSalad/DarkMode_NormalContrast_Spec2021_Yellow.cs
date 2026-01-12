using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_NormalContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#FFB779";
    public string OnPrimary => "#4C2700";
    public string PrimaryContainer => "#6C3A00";
    public string OnPrimaryContainer => "#FFDCC1";

    public string Secondary => "#FFB779";
    public string OnSecondary => "#4C2700";
    public string SecondaryContainer => "#6B3B04";
    public string OnSecondaryContainer => "#FFDCC1";

    public string Tertiary => "#CDCA75";
    public string OnTertiary => "#333200";
    public string TertiaryContainer => "#4A4900";
    public string OnTertiaryContainer => "#E9E78E";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#141407";
    public string OnSurface => "#E6E3CD";
    public string OnSurfaceVariant => "#CBC8A4";

    public string SurfaceContainerLowest => "#0F0F04";
    public string SurfaceContainerLow => "#1D1C0E";
    public string SurfaceContainer => "#212012";
    public string SurfaceContainerHigh => "#2B2B1C";
    public string SurfaceContainerHighest => "#363526";
}
