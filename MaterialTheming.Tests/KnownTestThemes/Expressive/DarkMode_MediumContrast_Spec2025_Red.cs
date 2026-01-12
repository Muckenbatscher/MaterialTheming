using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_MediumContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#FFB8AF";
    public string OnPrimary => "#602520";
    public string PrimaryContainer => "#FDA49A";
    public string OnPrimaryContainer => "#541C17";

    public string Secondary => "#B3CAD5";
    public string OnSecondary => "#243942";
    public string SecondaryContainer => "#627881";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#7FE2FF";
    public string OnTertiary => "#004655";
    public string TertiaryContainer => "#58D6F7";
    public string OnTertiaryContainer => "#003C49";

    public string Error => "#FF9DA8";
    public string OnError => "#5F001C";
    public string ErrorContainer => "#C8475D";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#1B0905";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E4AC9C";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#230D07";
    public string SurfaceContainer => "#2C130B";
    public string SurfaceContainerHigh => "#35170F";
    public string SurfaceContainerHighest => "#3E1C12";
}
