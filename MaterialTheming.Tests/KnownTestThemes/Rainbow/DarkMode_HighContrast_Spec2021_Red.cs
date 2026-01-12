using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class DarkMode_HighContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#FFECE9";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#FFAEA5";
    public string OnPrimaryContainer => "#220001";

    public string Secondary => "#FFECE9";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#E3B9B4";
    public string OnSecondaryContainer => "#190605";

    public string Tertiary => "#FFEED2";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#DCBF89";
    public string OnTertiaryContainer => "#120A00";

    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";

    public string Surface => "#131313";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1F1F1F";
    public string SurfaceContainer => "#303030";
    public string SurfaceContainerHigh => "#3B3B3B";
    public string SurfaceContainerHighest => "#474747";
}
