using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_NormalContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#FFB1C8";
    public string OnPrimary => "#5E1132";
    public string PrimaryContainer => "#7B2949";
    public string OnPrimaryContainer => "#FFD9E2";

    public string Secondary => "#FFB1C8";
    public string OnSecondary => "#541D32";
    public string SecondaryContainer => "#703348";
    public string OnSecondaryContainer => "#FFD9E2";

    public string Tertiary => "#FFB68B";
    public string OnTertiary => "#522300";
    public string TertiaryContainer => "#6F3811";
    public string OnTertiaryContainer => "#FFDBC8";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#1D1009";
    public string OnSurface => "#F8DDD0";
    public string OnSurfaceVariant => "#E5BFA9";

    public string SurfaceContainerLowest => "#170B05";
    public string SurfaceContainerLow => "#261910";
    public string SurfaceContainer => "#2A1D14";
    public string SurfaceContainerHigh => "#36271E";
    public string SurfaceContainerHighest => "#413128";
}
