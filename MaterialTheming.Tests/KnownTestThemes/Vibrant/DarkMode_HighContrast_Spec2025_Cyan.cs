using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_HighContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#A7F1FF";
    public string OnPrimary => "#003138";
    public string PrimaryContainer => "#00E3FC";
    public string OnPrimaryContainer => "#001E23";

    public string Secondary => "#BBEDFF";
    public string OnSecondary => "#00313C";
    public string SecondaryContainer => "#00B2D6";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#DAE6FF";
    public string OnTertiary => "#002C58";
    public string TertiaryContainer => "#65A5FF";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFDEDB";
    public string OnError => "#60000A";
    public string ErrorContainer => "#FF7C76";
    public string OnErrorContainer => "#000000";

    public string Surface => "#001016";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#BBEDFF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#00161D";
    public string SurfaceContainer => "#001D25";
    public string SurfaceContainerHigh => "#00232C";
    public string SurfaceContainerHighest => "#002A34";
}
