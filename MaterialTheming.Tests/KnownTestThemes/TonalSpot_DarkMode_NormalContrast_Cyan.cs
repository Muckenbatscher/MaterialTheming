using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes;

internal class TonalSpot_DarkMode_NormalContrast_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1";
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;

    public string Primary => "#82D3E1";
    public string OnPrimary => "#00363D";
    public string PrimaryContainer => "#004F58";
    public string OnPrimaryContainer => "#9EEFFE";

    public string Secondary => "#B1CBD0";
    public string OnSecondary => "#1C3438";
    public string SecondaryContainer => "#334B4F";
    public string OnSecondaryContainer => "#CDE7EC";

    public string Tertiary => "#BBC6EA";
    public string OnTertiary => "#252F4D";
    public string TertiaryContainer => "#3B4665";
    public string OnTertiaryContainer => "#DAE2FF";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#0E1416";
    public string OnSurface => "#DEE3E5";
    public string OnSurfaceVariant => "#BFC8CA";

    public string SurfaceContainerLowest => "#090F10";
    public string SurfaceContainerLow => "#171D1E";
    public string SurfaceContainer => "#1B2122";
    public string SurfaceContainerHigh => "#252B2C";
    public string SurfaceContainerHighest => "#303637";
}
