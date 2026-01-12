using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class DarkMode_NormalContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#FFAFD6";
    public string OnPrimary => "#620043";
    public string PrimaryContainer => "#E85DAE";
    public string OnPrimaryContainer => "#55003A";

    public string Secondary => "#FFAFD6";
    public string OnSecondary => "#531C3C";
    public string SecondaryContainer => "#713456";
    public string OnSecondaryContainer => "#EFA1C8";

    public string Tertiary => "#86DC52";
    public string OnTertiary => "#153800";
    public string TertiaryContainer => "#52A31D";
    public string OnTertiaryContainer => "#113000";

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
