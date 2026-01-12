using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_HighContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#2C2126";
    public string OnPrimary => "#E8D5DC";
    public string PrimaryContainer => "#5C4F54";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#282224";
    public string OnSecondary => "#E2D7DA";
    public string SecondaryContainer => "#575053";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#2D1E35";
    public string OnTertiary => "#EAD2F1";
    public string TertiaryContainer => "#5E4C65";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#4F0116";
    public string OnError => "#FFCED2";
    public string ErrorContainer => "#8E3242";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FEF8F8";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#272324";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F9F2F2";
    public string SurfaceContainer => "#F4ECED";
    public string SurfaceContainerHigh => "#EFE6E7";
    public string SurfaceContainerHighest => "#E9E0E2";
}
