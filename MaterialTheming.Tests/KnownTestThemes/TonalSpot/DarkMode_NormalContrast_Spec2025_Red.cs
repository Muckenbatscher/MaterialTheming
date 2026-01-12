using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_NormalContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#F9B6AE";
    public string OnPrimary => "#61332F";
    public string PrimaryContainer => "#764540";
    public string OnPrimaryContainer => "#FFDBD7";

    public string Secondary => "#E7BDB8";
    public string OnSecondary => "#563935";
    public string SecondaryContainer => "#513431";
    public string OnSecondaryContainer => "#DFB6B1";

    public string Tertiary => "#FFE0BD";
    public string OnTertiary => "#6E4D1D";
    public string TertiaryContainer => "#FFCF93";
    public string OnTertiaryContainer => "#654415";

    public string Error => "#F97386";
    public string OnError => "#490013";
    public string ErrorContainer => "#871C34";
    public string OnErrorContainer => "#FF97A3";

    public string Surface => "#130C0C";
    public string OnSurface => "#F9E0DD";
    public string OnSurfaceVariant => "#BCA6A3";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1A1110";
    public string SurfaceContainer => "#221716";
    public string SurfaceContainerHigh => "#291D1B";
    public string SurfaceContainerHighest => "#302221";
}
