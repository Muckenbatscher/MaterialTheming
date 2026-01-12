using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_NormalContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#FFB8AF";
    public string OnPrimary => "#6D2F29";
    public string PrimaryContainer => "#FDA49A";
    public string OnPrimaryContainer => "#612621";

    public string Secondary => "#B3CAD5";
    public string OnSecondary => "#2E434C";
    public string SecondaryContainer => "#132931";
    public string OnSecondaryContainer => "#91A7B2";

    public string Tertiary => "#7FE2FF";
    public string OnTertiary => "#005061";
    public string TertiaryContainer => "#58D6F7";
    public string OnTertiaryContainer => "#004756";

    public string Error => "#FD6F85";
    public string OnError => "#490013";
    public string ErrorContainer => "#8A1632";
    public string OnErrorContainer => "#FF97A3";

    public string Surface => "#1B0905";
    public string OnSurface => "#FFDED6";
    public string OnSurfaceVariant => "#D59E8F";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#230D07";
    public string SurfaceContainer => "#2C130B";
    public string SurfaceContainerHigh => "#35170F";
    public string SurfaceContainerHighest => "#3E1C12";
}
