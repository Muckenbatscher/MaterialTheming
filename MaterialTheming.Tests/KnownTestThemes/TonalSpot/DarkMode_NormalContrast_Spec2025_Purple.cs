using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_NormalContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#D5BEE9";
    public string OnPrimary => "#4A395C";
    public string PrimaryContainer => "#5D4B6F";
    public string OnPrimaryContainer => "#F0DCFF";

    public string Secondary => "#D0C1DA";
    public string OnSecondary => "#473C50";
    public string SecondaryContainer => "#42374B";
    public string OnSecondaryContainer => "#C9BAD2";

    public string Tertiary => "#FFCCE2";
    public string OnTertiary => "#6B3F55";
    public string TertiaryContainer => "#F7BBD7";
    public string OnTertiaryContainer => "#61364C";

    public string Error => "#F97386";
    public string OnError => "#490013";
    public string ErrorContainer => "#871C34";
    public string OnErrorContainer => "#FF97A3";

    public string Surface => "#100D11";
    public string OnSurface => "#ECE2EE";
    public string OnSurfaceVariant => "#B1A8B3";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#151218";
    public string SurfaceContainer => "#1C181F";
    public string SurfaceContainerHigh => "#221E25";
    public string SurfaceContainerHighest => "#29242D";
}
