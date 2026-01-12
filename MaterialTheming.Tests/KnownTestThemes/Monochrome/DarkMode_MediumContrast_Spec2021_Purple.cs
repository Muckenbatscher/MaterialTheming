using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Monochrome;

internal class DarkMode_MediumContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Monochrome;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#FFFFFF";
    public string OnPrimary => "#1B1B1B";
    public string PrimaryContainer => "#D4D4D4";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#DCDCDC";
    public string OnSecondary => "#1B1B1B";
    public string SecondaryContainer => "#919191";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#E2E2E2";
    public string OnTertiary => "#1B1B1B";
    public string TertiaryContainer => "#919191";
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
