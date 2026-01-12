using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_HighContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#C2FFC4";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#00E060";
    public string OnPrimaryContainer => "#000F02";

    public string Secondary => "#CFFAE1";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#A2CCB4";
    public string OnSecondaryContainer => "#000E07";

    public string Tertiary => "#B8FEEB";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#8BD0BF";
    public string OnTertiaryContainer => "#000E0A";

    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";

    public string Surface => "#0D150D";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#192219";
    public string SurfaceContainer => "#2A3329";
    public string SurfaceContainerHigh => "#353E34";
    public string SurfaceContainerHighest => "#40493F";
}
