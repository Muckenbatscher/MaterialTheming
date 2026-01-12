using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class DarkMode_MediumContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#ECD3FF";
    public string OnPrimary => "#380B60";
    public string PrimaryContainer => "#A97ED4";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#E6D7F0";
    public string OnSecondary => "#2B2234";
    public string SecondaryContainer => "#998CA3";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#FFD1D6";
    public string OnTertiary => "#3F1A20";
    public string TertiaryContainer => "#B88389";
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
