using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_MediumContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#FFD2CD";
    public string OnPrimary => "#481310";
    public string PrimaryContainer => "#CC7B72";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#FED2CD";
    public string OnSecondary => "#381F1C";
    public string SecondaryContainer => "#AD8883";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#F7D9A0";
    public string OnTertiary => "#332300";
    public string TertiaryContainer => "#A78D5B";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#1A1110";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#EED7D4";

    public string SurfaceContainerLowest => "#0D0605";
    public string SurfaceContainerLow => "#251B1A";
    public string SurfaceContainer => "#302524";
    public string SurfaceContainerHigh => "#3B302F";
    public string SurfaceContainerHighest => "#463B3A";
}
