using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_HighContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#EBF0FF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#A5C3FF";
    public string OnPrimaryContainer => "#000B21";

    public string Secondary => "#EDF5BE";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#C0C794";
    public string OnSecondaryContainer => "#090D00";

    public string Tertiary => "#D0FCC5";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#A3CE9A";
    public string OnTertiaryContainer => "#000F01";

    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";

    public string Surface => "#1C110D";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#291D18";
    public string SurfaceContainer => "#3B2D28";
    public string SurfaceContainerHigh => "#473833";
    public string SurfaceContainerHighest => "#53433E";
}
