using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_HighContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#FFEBF2";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#FFA9D4";
    public string OnPrimaryContainer => "#1F0013";

    public string Secondary => "#FFEBEE";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#ECB4C1";
    public string OnSecondaryContainer => "#1D020B";

    public string Tertiary => "#FFECEB";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#FDAEB1";
    public string OnTertiaryContainer => "#210004";

    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";

    public string Surface => "#1C1016";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#291C22";
    public string SurfaceContainer => "#3B2C33";
    public string SurfaceContainerHigh => "#46373E";
    public string SurfaceContainerHighest => "#524249";
}
