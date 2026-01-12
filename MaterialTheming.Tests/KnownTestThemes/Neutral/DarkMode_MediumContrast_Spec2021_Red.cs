using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_MediumContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#F6D5D1";
    public string OnPrimary => "#34211F";
    public string PrimaryContainer => "#A78A87";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#EED7D4";
    public string OnSecondary => "#302221";
    public string SecondaryContainer => "#A08C8A";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#FED2CD";
    public string OnTertiary => "#381F1C";
    public string TertiaryContainer => "#AD8883";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#161312";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E3DBD9";

    public string SurfaceContainerLowest => "#090707";
    public string SurfaceContainerLow => "#201D1C";
    public string SurfaceContainer => "#2B2726";
    public string SurfaceContainerHigh => "#363231";
    public string SurfaceContainerHighest => "#413D3C";
}
