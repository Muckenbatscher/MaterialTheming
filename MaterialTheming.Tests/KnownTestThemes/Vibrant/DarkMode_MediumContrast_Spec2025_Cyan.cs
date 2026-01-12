using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_MediumContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#7FEDFF";
    public string OnPrimary => "#004C55";
    public string PrimaryContainer => "#00E3FC";
    public string OnPrimaryContainer => "#00434B";

    public string Secondary => "#00D5FF";
    public string OnSecondary => "#003A47";
    public string SecondaryContainer => "#007F99";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#8EBAFF";
    public string OnTertiary => "#002C59";
    public string TertiaryContainer => "#5EA2FF";
    public string OnTertiaryContainer => "#00142F";

    public string Error => "#FF9F99";
    public string OnError => "#60000A";
    public string ErrorContainer => "#D7383B";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#001016";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#8DC1D2";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#00161D";
    public string SurfaceContainer => "#001D25";
    public string SurfaceContainerHigh => "#00232C";
    public string SurfaceContainerHighest => "#002A34";
}
