using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_MediumContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#D5BEE9";
    public string OnPrimary => "#402F51";
    public string PrimaryContainer => "#816D93";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#D0C1DA";
    public string OnSecondary => "#3C3245";
    public string SecondaryContainer => "#7C7086";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#FFCCE2";
    public string OnTertiary => "#60354B";
    public string TertiaryContainer => "#F7BBD7";
    public string OnTertiaryContainer => "#562C42";

    public string Error => "#FF9DA8";
    public string OnError => "#5F001C";
    public string ErrorContainer => "#C44B5F";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#100D11";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#BFB6C1";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#151218";
    public string SurfaceContainer => "#1C181F";
    public string SurfaceContainerHigh => "#221E25";
    public string SurfaceContainerHighest => "#29242D";
}
