using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_NormalContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#D8C2BF";
    public string OnPrimary => "#4C3D3B";
    public string PrimaryContainer => "#534341";
    public string OnPrimaryContainer => "#E2CBC8";

    public string Secondary => "#A69B9A";
    public string OnSecondary => "#251F1E";
    public string SecondaryContainer => "#413A39";
    public string OnSecondaryContainer => "#C9BDBB";

    public string Tertiary => "#FFD8E6";
    public string OnTertiary => "#694856";
    public string TertiaryContainer => "#F5C8DA";
    public string OnTertiaryContainer => "#60404E";

    public string Error => "#EC7C8A";
    public string OnError => "#490013";
    public string ErrorContainer => "#7F2737";
    public string OnErrorContainer => "#FF97A3";

    public string Surface => "#100E0D";
    public string OnSurface => "#EEE3E1";
    public string OnSurfaceVariant => "#B2A9A8";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#161312";
    public string SurfaceContainer => "#1C1918";
    public string SurfaceContainerHigh => "#231F1E";
    public string SurfaceContainerHighest => "#2A2524";
}
