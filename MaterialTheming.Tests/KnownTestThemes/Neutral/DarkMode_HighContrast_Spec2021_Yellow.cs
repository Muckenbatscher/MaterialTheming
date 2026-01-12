using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_HighContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#F4F1D5";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#C6C4A9";
    public string OnPrimaryContainer => "#0C0C01";

    public string Secondary => "#F4F0DE";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#C6C3B2";
    public string OnSecondaryContainer => "#0C0C04";

    public string Tertiary => "#F5F2CC";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#C7C4A1";
    public string OnTertiaryContainer => "#0C0C00";

    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";

    public string Surface => "#141311";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#20201D";
    public string SurfaceContainer => "#31302D";
    public string SurfaceContainerHigh => "#3C3B38";
    public string SurfaceContainerHighest => "#484744";
}
