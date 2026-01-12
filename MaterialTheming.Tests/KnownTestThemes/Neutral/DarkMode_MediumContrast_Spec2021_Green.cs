using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_MediumContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#D3E0CF";
    public string OnPrimary => "#1D281D";
    public string PrimaryContainer => "#879485";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#D7DED3";
    public string OnSecondary => "#212720";
    public string SecondaryContainer => "#8B9389";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#CEE2CB";
    public string OnTertiary => "#19291A";
    public string TertiaryContainer => "#839681";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#131412";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#DEDCD9";

    public string SurfaceContainerLowest => "#070806";
    public string SurfaceContainerLow => "#1D1E1C";
    public string SurfaceContainer => "#272826";
    public string SurfaceContainerHigh => "#323331";
    public string SurfaceContainerHighest => "#3D3E3C";
}
