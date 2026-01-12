using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class DarkMode_NormalContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#FFB4AB";
    public string OnPrimary => "#690005";
    public string PrimaryContainer => "#F55F53";
    public string OnPrimaryContainer => "#150000";

    public string Secondary => "#FFB4AB";
    public string OnSecondary => "#581C18";
    public string SecondaryContainer => "#78342E";
    public string OnSecondaryContainer => "#FDA095";

    public string Tertiary => "#FCBB54";
    public string OnTertiary => "#442B00";
    public string TertiaryContainer => "#A16C00";
    public string OnTertiaryContainer => "#FFFFFF";

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
