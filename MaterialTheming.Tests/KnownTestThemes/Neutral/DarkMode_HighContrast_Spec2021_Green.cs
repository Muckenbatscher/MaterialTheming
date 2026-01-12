using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_HighContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#E6F4E2";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#B9C6B6";
    public string OnPrimaryContainer => "#040E05";

    public string Secondary => "#EBF2E7";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#BDC5BA";
    public string OnSecondaryContainer => "#070D07";

    public string Tertiary => "#E1F6DE";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#B4C8B2";
    public string OnTertiaryContainer => "#020E03";

    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";

    public string Surface => "#131412";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1F201E";
    public string SurfaceContainer => "#30312F";
    public string SurfaceContainerHigh => "#3B3C3A";
    public string SurfaceContainerHighest => "#464745";
}
