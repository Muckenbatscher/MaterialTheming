using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_NormalContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#A6C8FF";
    public string OnPrimary => "#003060";
    public string PrimaryContainer => "#004787";
    public string OnPrimaryContainer => "#D5E3FF";

    public string Secondary => "#A6C8FF";
    public string OnSecondary => "#03305F";
    public string SecondaryContainer => "#234776";
    public string OnSecondaryContainer => "#D5E3FF";

    public string Tertiary => "#DBB9F9";
    public string OnTertiary => "#3E2459";
    public string TertiaryContainer => "#563B71";
    public string OnTertiaryContainer => "#F0DBFF";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#16111B";
    public string OnSurface => "#EADFED";
    public string OnSurfaceVariant => "#D0C1DA";

    public string SurfaceContainerLowest => "#110C16";
    public string SurfaceContainerLow => "#1F1923";
    public string SurfaceContainer => "#231D28";
    public string SurfaceContainerHigh => "#2E2832";
    public string SurfaceContainerHighest => "#39323D";
}
