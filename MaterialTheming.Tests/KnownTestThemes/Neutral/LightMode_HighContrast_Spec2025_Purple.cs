using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_HighContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#27222A";
    public string OnPrimary => "#E0D7E2";
    public string PrimaryContainer => "#565059";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#262327";
    public string OnSecondary => "#DED8DD";
    public string SecondaryContainer => "#545155";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#252039";
    public string OnTertiary => "#DED5F7";
    public string TertiaryContainer => "#544E6A";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#4F0116";
    public string OnError => "#FFCED2";
    public string ErrorContainer => "#8E3242";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FDF8F9";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#252326";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F7F2F4";
    public string SurfaceContainer => "#F2ECEF";
    public string SurfaceContainerHigh => "#ECE7E9";
    public string SurfaceContainerHighest => "#E7E1E4";
}
