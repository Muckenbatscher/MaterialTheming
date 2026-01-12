using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class DarkMode_NormalContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#45D8EE";
    public string OnPrimary => "#00363D";
    public string PrimaryContainer => "#00BCD1";
    public string OnPrimaryContainer => "#00464F";

    public string Secondary => "#9FCED7";
    public string OnSecondary => "#00363D";
    public string SecondaryContainer => "#1C4D55";
    public string OnSecondaryContainer => "#8EBDC6";

    public string Tertiary => "#E6B4FF";
    public string OnTertiary => "#4A1568";
    public string TertiaryContainer => "#CE94ED";
    public string OnTertiaryContainer => "#5A2678";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#0E1416";
    public string OnSurface => "#DDE4E5";
    public string OnSurfaceVariant => "#BBC9CC";

    public string SurfaceContainerLowest => "#090F10";
    public string SurfaceContainerLow => "#161D1E";
    public string SurfaceContainer => "#1A2122";
    public string SurfaceContainerHigh => "#252B2C";
    public string SurfaceContainerHighest => "#2F3637";
}
