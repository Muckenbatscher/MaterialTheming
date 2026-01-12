using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class DarkMode_MediumContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#9DEFA4";
    public string OnPrimary => "#002D0D";
    public string PrimaryContainer => "#53A15F";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#CEE2CB";
    public string OnSecondary => "#19291A";
    public string SecondaryContainer => "#839681";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#B7E4ED";
    public string OnTertiary => "#002A30";
    public string TertiaryContainer => "#6C98A0";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#131313";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#DCDCDC";

    public string SurfaceContainerLowest => "#070707";
    public string SurfaceContainerLow => "#1D1D1D";
    public string SurfaceContainer => "#282828";
    public string SurfaceContainerHigh => "#323232";
    public string SurfaceContainerHighest => "#3E3E3E";
}
