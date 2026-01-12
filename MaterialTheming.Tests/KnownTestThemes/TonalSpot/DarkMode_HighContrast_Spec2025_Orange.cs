using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_HighContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#FFDFCE";
    public string OnPrimary => "#46230A";
    public string PrimaryContainer => "#CF9776";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#FFDFCE";
    public string OnSecondary => "#3E2718";
    public string SecondaryContainer => "#C09C88";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#FFF6DE";
    public string OnTertiary => "#403601";
    public string TertiaryContainer => "#FAE8A2";
    public string OnTertiaryContainer => "#372D00";

    public string Error => "#FFDED7";
    public string OnError => "#5A0E00";
    public string ErrorContainer => "#FF7E5E";
    public string OnErrorContainer => "#000000";

    public string Surface => "#130D09";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#F8E1D5";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1A120D";
    public string SurfaceContainer => "#211812";
    public string SurfaceContainerHigh => "#281D17";
    public string SurfaceContainerHighest => "#30231C";
}
