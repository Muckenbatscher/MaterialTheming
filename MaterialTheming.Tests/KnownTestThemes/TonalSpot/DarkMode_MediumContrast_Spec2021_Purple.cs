using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_MediumContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#ECD3FF";
    public string OnPrimary => "#33184D";
    public string PrimaryContainer => "#A384C0";
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

    public string Surface => "#151218";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E3D9E4";

    public string SurfaceContainerLowest => "#09060B";
    public string SurfaceContainerLow => "#201C22";
    public string SurfaceContainer => "#2A272C";
    public string SurfaceContainerHigh => "#353137";
    public string SurfaceContainerHighest => "#403C42";
}
