using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_HighContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#DFF3FF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#7DCDF2";
    public string OnPrimaryContainer => "#000D14";

    public string Secondary => "#FFECE7";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#F1B5A3";
    public string OnSecondaryContainer => "#1D0400";

    public string Tertiary => "#F7F4A5";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#C8C67B";
    public string OnTertiaryContainer => "#0C0C00";

    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";

    public string Surface => "#1B1013";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#281C1F";
    public string SurfaceContainer => "#3A2D2F";
    public string SurfaceContainerHigh => "#46383A";
    public string SurfaceContainerHighest => "#524346";
}
