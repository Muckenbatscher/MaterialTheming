using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_MediumContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#ECD3FF";
    public string OnPrimary => "#3A0068";
    public string PrimaryContainer => "#B66DFF";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#F2D2F7";
    public string OnSecondary => "#331D39";
    public string SecondaryContainer => "#A487A9";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#FFCEF4";
    public string OnTertiary => "#3D173A";
    public string TertiaryContainer => "#B381AA";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#16111B";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E4D8EA";

    public string SurfaceContainerLowest => "#0A060E";
    public string SurfaceContainerLow => "#211B26";
    public string SurfaceContainer => "#2B2630";
    public string SurfaceContainerHigh => "#36303B";
    public string SurfaceContainerHighest => "#423B46";
}
