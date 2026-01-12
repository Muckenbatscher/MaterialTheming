using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_NormalContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#FFFCC6";
    public string OnPrimary => "#636200";
    public string PrimaryContainer => "#F5F200";
    public string OnPrimaryContainer => "#5B5A00";

    public string Secondary => "#FCD83F";
    public string OnSecondary => "#5B4B00";
    public string SecondaryContainer => "#705D00";
    public string OnSecondaryContainer => "#FFF7E7";

    public string Tertiary => "#FFCE5D";
    public string OnTertiary => "#5E4500";
    public string TertiaryContainer => "#F7BE26";
    public string OnTertiaryContainer => "#533D00";

    public string Error => "#FF7351";
    public string OnError => "#450900";
    public string ErrorContainer => "#B92902";
    public string OnErrorContainer => "#FFD2C8";

    public string Surface => "#130E00";
    public string OnSurface => "#F9E59F";
    public string OnSurfaceVariant => "#BDAA6A";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#191300";
    public string SurfaceContainer => "#201900";
    public string SurfaceContainerHigh => "#271F00";
    public string SurfaceContainerHighest => "#2E2500";
}
