using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class DarkMode_HighContrast_Spec2021 : ITestTheme
{
    public string SourceColor => "#D2463D"; //red
    public bool IsDark => true;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#FFECE9";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#FFAEA5";
    public string OnPrimaryContainer => "#150000";

    public string Secondary => "#FFECE9";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#FFAEA5";
    public string OnSecondaryContainer => "#220001";

    public string Tertiary => "#C6F9FF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#70D1DC";
    public string OnTertiaryContainer => "#000708";

    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";

    public string Surface => "#1D100F";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#2A1C1B";
    public string SurfaceContainer => "#3C2D2B";
    public string SurfaceContainerHigh => "#483836";
    public string SurfaceContainerHighest => "#544341";
}
