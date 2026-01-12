using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_HighContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#F9ECFE";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#CABFD0";
    public string OnPrimaryContainer => "#0F0914";

    public string Secondary => "#F7EDF8";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#C8C0CB";
    public string OnSecondaryContainer => "#0D0A11";

    public string Tertiary => "#F9EBFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#CCBDD6";
    public string OnTertiaryContainer => "#100818";

    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";

    public string Surface => "#141314";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#211F21";
    public string SurfaceContainer => "#323031";
    public string SurfaceContainerHigh => "#3D3B3C";
    public string SurfaceContainerHighest => "#484648";
}
