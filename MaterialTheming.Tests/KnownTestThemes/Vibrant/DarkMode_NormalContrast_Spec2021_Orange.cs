using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_NormalContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#FFB68B";
    public string OnPrimary => "#522300";
    public string PrimaryContainer => "#743400";
    public string OnPrimaryContainer => "#FFDBC8";

    public string Secondary => "#ECBE91";
    public string OnSecondary => "#462A09";
    public string SecondaryContainer => "#60401D";
    public string OnSecondaryContainer => "#FFDCBD";

    public string Tertiary => "#EBC078";
    public string OnTertiary => "#422C00";
    public string TertiaryContainer => "#5F4102";
    public string OnTertiaryContainer => "#FFDEAA";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#1D1009";
    public string OnSurface => "#F8DDD0";
    public string OnSurfaceVariant => "#DEC1B1";

    public string SurfaceContainerLowest => "#170B05";
    public string SurfaceContainerLow => "#261910";
    public string SurfaceContainer => "#2A1D14";
    public string SurfaceContainerHigh => "#36271E";
    public string SurfaceContainerHighest => "#413128";
}
