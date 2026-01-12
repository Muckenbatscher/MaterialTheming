using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_HighContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#E2F3F7";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#B4C6C9";
    public string OnPrimaryContainer => "#010D10";

    public string Secondary => "#E8F2F4";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#BBC4C6";
    public string OnSecondaryContainer => "#050D0E";

    public string Tertiary => "#DAF5FA";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#ADC7CC";
    public string OnTertiaryContainer => "#000E10";

    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";

    public string Surface => "#121414";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1F2020";
    public string SurfaceContainer => "#2F3031";
    public string SurfaceContainerHigh => "#3B3B3C";
    public string SurfaceContainerHighest => "#464747";
}
