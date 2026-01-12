using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_HighContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#FFEBF2";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#D6BCC6";
    public string OnPrimaryContainer => "#14070E";

    public string Secondary => "#FEEBF1";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#D0BEC4";
    public string OnSecondaryContainer => "#11090D";

    public string Tertiary => "#FFEBF2";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#DBBAC8";
    public string OnTertiaryContainer => "#17060F";

    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";

    public string Surface => "#151314";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#221F20";
    public string SurfaceContainer => "#333030";
    public string SurfaceContainerHigh => "#3E3A3B";
    public string SurfaceContainerHighest => "#4A4647";
}
