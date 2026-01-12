using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_NormalContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#BDCABA";
    public string OnPrimary => "#283328";
    public string PrimaryContainer => "#3E4A3D";
    public string OnPrimaryContainer => "#D9E6D5";

    public string Secondary => "#C1C9BE";
    public string OnSecondary => "#2B322B";
    public string SecondaryContainer => "#424940";
    public string OnSecondaryContainer => "#DDE5D9";

    public string Tertiary => "#B8CCB5";
    public string OnTertiary => "#243424";
    public string TertiaryContainer => "#3A4B3A";
    public string OnTertiaryContainer => "#D4E8D1";

    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";

    public string Surface => "#131412";
    public string OnSurface => "#E4E2DF";
    public string OnSurfaceVariant => "#C7C6C3";

    public string SurfaceContainerLowest => "#0D0E0D";
    public string SurfaceContainerLow => "#1B1C1A";
    public string SurfaceContainer => "#1F201E";
    public string SurfaceContainerHigh => "#292A28";
    public string SurfaceContainerHighest => "#343533";
}
