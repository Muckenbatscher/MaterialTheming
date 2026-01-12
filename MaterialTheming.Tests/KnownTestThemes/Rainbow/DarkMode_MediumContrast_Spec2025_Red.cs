using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class DarkMode_MediumContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#FFD2CD";
    public string OnPrimary => "#500808";
    public string PrimaryContainer => "#DB7267";
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

    public string Surface => "#131313";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#DCDCDC";

    public string SurfaceContainerLowest => "#070707";
    public string SurfaceContainerLow => "#1D1D1D";
    public string SurfaceContainer => "#282828";
    public string SurfaceContainerHigh => "#323232";
    public string SurfaceContainerHighest => "#3E3E3E";
}
