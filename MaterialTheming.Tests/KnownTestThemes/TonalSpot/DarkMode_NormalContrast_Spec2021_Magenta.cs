using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_NormalContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#FCB0D5";
    public string OnPrimary => "#521D3B";
    public string PrimaryContainer => "#6C3353";
    public string OnPrimaryContainer => "#FFD8E8";

    public string Secondary => "#E0BDCC";
    public string OnSecondary => "#402A35";
    public string SecondaryContainer => "#58404B";
    public string OnSecondaryContainer => "#FDD9E8";

    public string Tertiary => "#F3BB9A";
    public string OnTertiary => "#4A2811";
    public string TertiaryContainer => "#643D25";
    public string OnTertiaryContainer => "#FFDBC8";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#181114";
    public string OnSurface => "#EEDFE3";
    public string OnSurfaceVariant => "#D4C2C8";

    public string SurfaceContainerLowest => "#130C0F";
    public string SurfaceContainerLow => "#21191D";
    public string SurfaceContainer => "#251D21";
    public string SurfaceContainerHigh => "#30282B";
    public string SurfaceContainerHighest => "#3B3236";
}
