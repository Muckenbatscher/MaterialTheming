using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class DarkMode_NormalContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#FFB4AB";
    public string OnPrimary => "#690005";
    public string PrimaryContainer => "#F55F53";
    public string OnPrimaryContainer => "#150000";

    public string Secondary => "#FFB4AB";
    public string OnSecondary => "#581C18";
    public string SecondaryContainer => "#78342E";
    public string OnSecondaryContainer => "#FDA095";

    public string Tertiary => "#74D5E0";
    public string OnTertiary => "#00363B";
    public string TertiaryContainer => "#369EA8";
    public string OnTertiaryContainer => "#000708";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#1D100F";
    public string OnSurface => "#F6DDDA";
    public string OnSurfaceVariant => "#E1BFBB";

    public string SurfaceContainerLowest => "#170B0A";
    public string SurfaceContainerLow => "#261817";
    public string SurfaceContainer => "#2A1C1B";
    public string SurfaceContainerHigh => "#352625";
    public string SurfaceContainerHighest => "#41312F";
}
