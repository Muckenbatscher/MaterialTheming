using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_HighContrast_Spec2025_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#FFF0B3";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#DAC349";
    public string OnPrimaryContainer => "#0F0B00";

    public string Secondary => "#FFF0B3";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#D5C36C";
    public string OnSecondaryContainer => "#0F0B00";

    public string Tertiary => "#C5FEC6";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#99D09B";
    public string OnTertiaryContainer => "#000F02";

    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";

    public string Surface => "#0D150D";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#192219";
    public string SurfaceContainer => "#2A3329";
    public string SurfaceContainerHigh => "#353E34";
    public string SurfaceContainerHighest => "#40493F";
}
