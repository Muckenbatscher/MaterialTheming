using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_HighContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#F2EDFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#C2BBFF";
    public string OnPrimaryContainer => "#080038";

    public string Secondary => "#DAF9D1";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#ADCBA5";
    public string OnSecondaryContainer => "#000F01";

    public string Tertiary => "#BCFEE1";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#90D0B5";
    public string OnTertiaryContainer => "#000E08";

    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";

    public string Surface => "#1A1209";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#271E15";
    public string SurfaceContainer => "#392E25";
    public string SurfaceContainerHigh => "#45392F";
    public string SurfaceContainerHighest => "#50453A";
}
