using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_NormalContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#F6BA96";
    public string OnPrimary => "#5E361C";
    public string PrimaryContainer => "#74482C";
    public string OnPrimaryContainer => "#FFDCCA";

    public string Secondary => "#E5BFA9";
    public string OnSecondary => "#543A2B";
    public string SecondaryContainer => "#4F3626";
    public string OnSecondaryContainer => "#DDB8A2";

    public string Tertiary => "#FFF6DE";
    public string OnTertiary => "#6A5D25";
    public string TertiaryContainer => "#FAE8A2";
    public string OnTertiaryContainer => "#61551E";

    public string Error => "#F97758";
    public string OnError => "#450900";
    public string ErrorContainer => "#85230A";
    public string OnErrorContainer => "#FF9B82";

    public string Surface => "#130D09";
    public string OnSurface => "#F8E1D5";
    public string OnSurfaceVariant => "#BBA79C";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1A120D";
    public string SurfaceContainer => "#211812";
    public string SurfaceContainerHigh => "#281D17";
    public string SurfaceContainerHighest => "#30231C";
}
