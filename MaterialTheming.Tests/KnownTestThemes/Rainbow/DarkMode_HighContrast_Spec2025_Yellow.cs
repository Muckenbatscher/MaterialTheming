using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class DarkMode_HighContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#F8F67A";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#CAC852";
    public string OnPrimaryContainer => "#0C0C00";

    public string Secondary => "#F5F2CC";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#C7C4A1";
    public string OnSecondaryContainer => "#0C0C00";

    public string Tertiary => "#CDFAE5";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#A1CCB8";
    public string OnTertiaryContainer => "#000E08";

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
