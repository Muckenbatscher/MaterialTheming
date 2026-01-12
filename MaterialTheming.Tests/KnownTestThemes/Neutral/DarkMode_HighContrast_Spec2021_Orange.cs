using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_HighContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#FFECE3";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#DABDAD";
    public string OnPrimaryContainer => "#150802";

    public string Secondary => "#FFECE3";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#D3BFB4";
    public string OnSecondaryContainer => "#120905";

    public string Tertiary => "#FFECE3";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#E1BBA6";
    public string OnTertiaryContainer => "#180701";

    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";

    public string Surface => "#161311";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#221F1D";
    public string SurfaceContainer => "#33302E";
    public string SurfaceContainerHigh => "#3F3B39";
    public string SurfaceContainerHighest => "#4A4644";
}
