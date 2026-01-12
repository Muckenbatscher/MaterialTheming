using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_HighContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#E9E6D4";
    public string OnPrimary => "#2D2C21";
    public string PrimaryContainer => "#A7A494";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#E9E5DC";
    public string OnSecondary => "#2D2C26";
    public string SecondaryContainer => "#A6A39C";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#F7FDD0";
    public string OnTertiary => "#353B1C";
    public string TertiaryContainer => "#E9EFC2";
    public string OnTertiaryContainer => "#2D3214";

    public string Error => "#FFDED7";
    public string OnError => "#591001";
    public string ErrorContainer => "#F48469";
    public string OnErrorContainer => "#000000";

    public string Surface => "#0F0E0D";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E9E5DE";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#141311";
    public string SurfaceContainer => "#1A1A17";
    public string SurfaceContainerHigh => "#20201C";
    public string SurfaceContainerHighest => "#272622";
}
