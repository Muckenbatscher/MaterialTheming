using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class DarkMode_MediumContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#7CECFF";
    public string OnPrimary => "#002A30";
    public string PrimaryContainer => "#009FB1";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#C7E1E6";
    public string OnSecondary => "#10292D";
    public string SecondaryContainer => "#7C959A";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#D1DBFF";
    public string OnTertiary => "#192541";
    public string TertiaryContainer => "#8590B2";
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
