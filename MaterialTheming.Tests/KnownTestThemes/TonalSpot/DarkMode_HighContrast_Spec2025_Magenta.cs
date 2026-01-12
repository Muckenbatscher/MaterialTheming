using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_HighContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#FFDCEA";
    public string OnPrimary => "#442034";
    public string PrimaryContainer => "#C995AD";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#FFDCEA";
    public string OnSecondary => "#3C2530";
    public string SecondaryContainer => "#BB9BA9";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#F9E0FF";
    public string OnTertiary => "#3C2448";
    public string TertiaryContainer => "#F0CEFD";
    public string OnTertiaryContainer => "#311A3D";

    public string Error => "#FFDDDF";
    public string OnError => "#5F001C";
    public string ErrorContainer => "#FF798C";
    public string OnErrorContainer => "#000000";

    public string Surface => "#120D0F";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#F4E0E7";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#191115";
    public string SurfaceContainer => "#20171B";
    public string SurfaceContainerHigh => "#271D21";
    public string SurfaceContainerHighest => "#2E2328";
}
