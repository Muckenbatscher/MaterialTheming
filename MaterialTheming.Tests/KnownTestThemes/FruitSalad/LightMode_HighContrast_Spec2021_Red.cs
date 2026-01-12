using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_HighContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#4F0D4E";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#722E6E";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#471B44";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#683863";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#511A15";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#763630";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F7";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFEDEA";
    public string SurfaceContainer => "#F9DCD9";
    public string SurfaceContainerHigh => "#EACECB";
    public string SurfaceContainerHighest => "#DCC0BD";
}
