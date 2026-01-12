using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_HighContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#CDF7FF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#4AD4E7";
    public string OnPrimaryContainer => "#000E10";

    public string Secondary => "#CDF7FF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#7ECFDC";
    public string OnSecondaryContainer => "#000E10";

    public string Tertiary => "#EAF0FF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#A2C4FB";
    public string OnTertiaryContainer => "#000B1E";

    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";

    public string Surface => "#0E141C";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1B2029";
    public string SurfaceContainer => "#2B313A";
    public string SurfaceContainerHigh => "#363C45";
    public string SurfaceContainerHighest => "#424751";
}
