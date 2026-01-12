using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_NormalContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#7FEDFF";
    public string OnPrimary => "#005761";
    public string PrimaryContainer => "#00E3FC";
    public string OnPrimaryContainer => "#004D57";

    public string Secondary => "#00D5FF";
    public string OnSecondary => "#004554";
    public string SecondaryContainer => "#00677D";
    public string OnSecondaryContainer => "#EDFAFF";

    public string Tertiary => "#7AAFFF";
    public string OnTertiary => "#002E5D";
    public string TertiaryContainer => "#5EA2FF";
    public string OnTertiaryContainer => "#002348";

    public string Error => "#FF716C";
    public string OnError => "#490006";
    public string ErrorContainer => "#9F0519";
    public string OnErrorContainer => "#FFA8A3";

    public string Surface => "#001016";
    public string OnSurface => "#BBEDFF";
    public string OnSurfaceVariant => "#7FB3C4";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#00161D";
    public string SurfaceContainer => "#001D25";
    public string SurfaceContainerHigh => "#00232C";
    public string SurfaceContainerHighest => "#002A34";
}
