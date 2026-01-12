using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_MediumContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#FFD2C9";
    public string OnPrimary => "#4B1107";
    public string PrimaryContainer => "#D17967";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#BAE6D1";
    public string OnSecondary => "#002C1F";
    public string SecondaryContainer => "#709A87";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#A2E9E7";
    public string OnTertiary => "#002B2A";
    public string TertiaryContainer => "#559C9A";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#0D1511";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#D0E0D5";

    public string SurfaceContainerLowest => "#030905";
    public string SurfaceContainerLow => "#171F1B";
    public string SurfaceContainer => "#212A25";
    public string SurfaceContainerHigh => "#2C352F";
    public string SurfaceContainerHighest => "#37403A";
}
