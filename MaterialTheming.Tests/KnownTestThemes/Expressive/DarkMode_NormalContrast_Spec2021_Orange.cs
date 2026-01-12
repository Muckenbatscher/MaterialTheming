using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_NormalContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#C6BFFF";
    public string OnPrimary => "#2E2767";
    public string PrimaryContainer => "#443E7F";
    public string OnPrimaryContainer => "#E4DFFF";

    public string Secondary => "#B1CFA9";
    public string OnSecondary => "#1D361B";
    public string SecondaryContainer => "#334D30";
    public string OnSecondaryContainer => "#CCEBC4";

    public string Tertiary => "#94D4B9";
    public string OnTertiary => "#003828";
    public string TertiaryContainer => "#08513C";
    public string OnTertiaryContainer => "#AFF0D4";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#1A1209";
    public string OnSurface => "#F2DFD1";
    public string OnSurfaceVariant => "#DBC2AC";

    public string SurfaceContainerLowest => "#150D05";
    public string SurfaceContainerLow => "#231A11";
    public string SurfaceContainer => "#271E15";
    public string SurfaceContainerHigh => "#32281E";
    public string SurfaceContainerHighest => "#3E3329";
}
