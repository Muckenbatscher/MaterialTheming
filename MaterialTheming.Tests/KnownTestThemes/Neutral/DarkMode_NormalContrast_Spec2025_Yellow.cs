using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_NormalContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#CAC7B6";
    public string OnPrimary => "#424134";
    public string PrimaryContainer => "#48473A";
    public string OnPrimaryContainer => "#D4D1BF";

    public string Secondary => "#A09E96";
    public string OnSecondary => "#21201B";
    public string SecondaryContainer => "#3D3B35";
    public string OnSecondaryContainer => "#C2BFB7";

    public string Tertiary => "#F7FDD0";
    public string OnTertiary => "#5C623F";
    public string TertiaryContainer => "#E9EFC2";
    public string OnTertiaryContainer => "#545A38";

    public string Error => "#ED7F64";
    public string OnError => "#450900";
    public string ErrorContainer => "#7E2B17";
    public string OnErrorContainer => "#FF9B82";

    public string Surface => "#0F0E0D";
    public string OnSurface => "#E9E5DE";
    public string OnSurfaceVariant => "#AEABA5";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#141311";
    public string SurfaceContainer => "#1A1A17";
    public string SurfaceContainerHigh => "#20201C";
    public string SurfaceContainerHighest => "#272622";
}
