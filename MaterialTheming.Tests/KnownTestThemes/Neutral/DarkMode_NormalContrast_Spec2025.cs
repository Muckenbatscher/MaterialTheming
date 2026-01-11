using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_NormalContrast_Spec2025 : ITestTheme
{
    public string SourceColor => "#338745"; //green
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#C1C9BE";
    public string OnPrimary => "#3B423A";
    public string PrimaryContainer => "#424940";
    public string OnPrimaryContainer => "#CBD2C7";

    public string Secondary => "#9D9E99";
    public string OnSecondary => "#1E211D";
    public string SecondaryContainer => "#3A3C38";
    public string OnSecondaryContainer => "#BEC0BA";

    public string Tertiary => "#E9FFED";
    public string OnTertiary => "#496553";
    public string TertiaryContainer => "#D3F3DB";
    public string OnTertiaryContainer => "#415D4B";

    public string Error => "#ED7F64";
    public string OnError => "#450900";
    public string ErrorContainer => "#7E2B17";
    public string OnErrorContainer => "#FF9B82";

    public string Surface => "#0E0E0D";
    public string OnSurface => "#E6E6E1";
    public string OnSurfaceVariant => "#ABABA7";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#131412";
    public string SurfaceContainer => "#191A18";
    public string SurfaceContainerHigh => "#1F201E";
    public string SurfaceContainerHighest => "#242624";
}
