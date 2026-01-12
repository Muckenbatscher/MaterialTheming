using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_HighContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#FFECE9";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#DBBBB7";
    public string OnPrimaryContainer => "#160706";

    public string Secondary => "#FFECE9";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#D4BEBB";
    public string OnSecondaryContainer => "#130908";

    public string Tertiary => "#FFECE9";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#E3B9B4";
    public string OnTertiaryContainer => "#190605";

    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";

    public string Surface => "#161312";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#221F1E";
    public string SurfaceContainer => "#332F2F";
    public string SurfaceContainerHigh => "#3F3A3A";
    public string SurfaceContainerHighest => "#4A4645";
}
