using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class DarkMode_NormalContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#FFB68B";
    public string OnPrimary => "#522300";
    public string PrimaryContainer => "#D77837";
    public string OnPrimaryContainer => "#481E00";

    public string Secondary => "#F4BA98";
    public string OnSecondary => "#4B270F";
    public string SecondaryContainer => "#653D23";
    public string OnSecondaryContainer => "#E1A988";

    public string Tertiary => "#61D5F7";
    public string OnTertiary => "#003542";
    public string TertiaryContainer => "#009EBF";
    public string OnTertiaryContainer => "#002E3A";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#1A120D";
    public string OnSurface => "#F1DFD7";
    public string OnSurfaceVariant => "#DBC1B4";

    public string SurfaceContainerLowest => "#140C08";
    public string SurfaceContainerLow => "#221A15";
    public string SurfaceContainer => "#271E19";
    public string SurfaceContainerHigh => "#322823";
    public string SurfaceContainerHighest => "#3D332D";
}
