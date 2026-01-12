using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class DarkMode_MediumContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#FFD2CD";
    public string OnPrimary => "#540003";
    public string PrimaryContainer => "#F55F53";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#FFD2CD";
    public string OnSecondary => "#4A110E";
    public string SecondaryContainer => "#CF7970";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#FFD69E";
    public string OnTertiary => "#362100";
    public string TertiaryContainer => "#BF8622";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#1D100F";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#F8D4D0";

    public string SurfaceContainerLowest => "#0F0504";
    public string SurfaceContainerLow => "#281A19";
    public string SurfaceContainer => "#332423";
    public string SurfaceContainerHigh => "#3E2F2D";
    public string SurfaceContainerHighest => "#4A3A38";
}
