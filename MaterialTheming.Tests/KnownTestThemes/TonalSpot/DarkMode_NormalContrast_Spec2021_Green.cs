using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_NormalContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#9CD49F";
    public string OnPrimary => "#013913";
    public string PrimaryContainer => "#1D5128";
    public string OnPrimaryContainer => "#B8F1B9";

    public string Secondary => "#B8CCB5";
    public string OnSecondary => "#243424";
    public string SecondaryContainer => "#3A4B3A";
    public string OnSecondaryContainer => "#D4E8D1";

    public string Tertiary => "#A1CED6";
    public string OnTertiary => "#00363D";
    public string TertiaryContainer => "#1F4D54";
    public string OnTertiaryContainer => "#BDEAF3";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#101510";
    public string OnSurface => "#E0E4DB";
    public string OnSurfaceVariant => "#C1C9BE";

    public string SurfaceContainerLowest => "#0B0F0B";
    public string SurfaceContainerLow => "#181D18";
    public string SurfaceContainer => "#1C211C";
    public string SurfaceContainerHigh => "#272B26";
    public string SurfaceContainerHighest => "#313630";
}
