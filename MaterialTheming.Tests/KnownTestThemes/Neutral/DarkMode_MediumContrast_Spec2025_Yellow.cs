using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_MediumContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#CAC7B6";
    public string OnPrimary => "#37372A";
    public string PrimaryContainer => "#777566";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#BCB8B0";
    public string OnSecondary => "#2D2C27";
    public string SecondaryContainer => "#76746D";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#F7FDD0";
    public string OnTertiary => "#525836";
    public string TertiaryContainer => "#E9EFC2";
    public string OnTertiaryContainer => "#4A502F";

    public string Error => "#FFA089";
    public string OnError => "#591001";
    public string ErrorContainer => "#BA573F";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#0F0E0D";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#BBB8B2";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#141311";
    public string SurfaceContainer => "#1A1A17";
    public string SurfaceContainerHigh => "#20201C";
    public string SurfaceContainerHighest => "#272622";
}
