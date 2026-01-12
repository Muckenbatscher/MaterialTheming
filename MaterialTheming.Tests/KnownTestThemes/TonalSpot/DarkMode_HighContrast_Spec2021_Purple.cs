using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_HighContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#F9EBFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#D7B6F5";
    public string OnPrimaryContainer => "#15002C";

    public string Secondary => "#F9EBFF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#CCBDD6";
    public string OnSecondaryContainer => "#100818";

    public string Tertiary => "#FFEBEC";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#EFB3BA";
    public string OnTertiaryContainer => "#1E0307";

    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";

    public string Surface => "#151218";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#221E24";
    public string SurfaceContainer => "#332F35";
    public string SurfaceContainerHigh => "#3E3A40";
    public string SurfaceContainerHighest => "#4A454C";
}
