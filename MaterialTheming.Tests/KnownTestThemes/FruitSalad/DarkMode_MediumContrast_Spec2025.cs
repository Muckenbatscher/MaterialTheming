using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_MediumContrast_Spec2025 : ITestTheme
{
    public string SourceColor => "#945CCD"; //purple
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#CBDDFF";
    public string OnPrimary => "#00264D";
    public string PrimaryContainer => "#5D92DD";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#CBDDFF";
    public string OnSecondary => "#00264D";
    public string SecondaryContainer => "#7192C6";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#ECD3FF";
    public string OnTertiary => "#33184D";
    public string TertiaryContainer => "#A384C0";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#16111B";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E6D7F0";

    public string SurfaceContainerLowest => "#0A060E";
    public string SurfaceContainerLow => "#211B26";
    public string SurfaceContainer => "#2B2630";
    public string SurfaceContainerHigh => "#36303B";
    public string SurfaceContainerHighest => "#423B46";
}
