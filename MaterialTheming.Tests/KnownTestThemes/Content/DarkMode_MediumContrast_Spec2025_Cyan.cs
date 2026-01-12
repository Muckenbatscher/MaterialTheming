using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class DarkMode_MediumContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#7CECFF";
    public string OnPrimary => "#002A30";
    public string PrimaryContainer => "#00BCD1";
    public string OnPrimaryContainer => "#00242A";

    public string Secondary => "#B5E4EE";
    public string OnSecondary => "#002A30";
    public string SecondaryContainer => "#6A98A1";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#F2D1FF";
    public string OnTertiary => "#3E045C";
    public string TertiaryContainer => "#CE94ED";
    public string OnTertiaryContainer => "#370053";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#0E1416";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#D1DFE2";

    public string SurfaceContainerLowest => "#040809";
    public string SurfaceContainerLow => "#181F20";
    public string SurfaceContainer => "#23292A";
    public string SurfaceContainerHigh => "#2D3435";
    public string SurfaceContainerHighest => "#383F40";
}
