using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class DarkMode_NormalContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#FFAFD6";
    public string OnPrimary => "#620043";
    public string PrimaryContainer => "#E85DAE";
    public string OnPrimaryContainer => "#55003A";

    public string Secondary => "#FFAFD6";
    public string OnSecondary => "#531C3C";
    public string SecondaryContainer => "#713456";
    public string OnSecondaryContainer => "#EFA1C8";

    public string Tertiary => "#FFB4A5";
    public string OnTertiary => "#650B00";
    public string TertiaryContainer => "#F36145";
    public string OnTertiaryContainer => "#580800";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#1B1015";
    public string OnSurface => "#F2DDE4";
    public string OnSurfaceVariant => "#DBBFCA";

    public string SurfaceContainerLowest => "#150B10";
    public string SurfaceContainerLow => "#23181D";
    public string SurfaceContainer => "#281C22";
    public string SurfaceContainerHigh => "#33272C";
    public string SurfaceContainerHighest => "#3E3137";
}
