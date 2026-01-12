using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_HighContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#F4E1E7";
    public string OnPrimary => "#34292E";
    public string PrimaryContainer => "#B09FA5";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#EEE3E5";
    public string OnSecondary => "#302A2D";
    public string SecondaryContainer => "#ABA1A4";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#FEEFFF";
    public string OnTertiary => "#3F2F47";
    public string TertiaryContainer => "#F6DDFD";
    public string OnTertiaryContainer => "#36263D";

    public string Error => "#FFDDDF";
    public string OnError => "#5B0A1E";
    public string ErrorContainer => "#F38190";
    public string OnErrorContainer => "#000000";

    public string Surface => "#0F0E0E";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#ECE3E5";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#151313";
    public string SurfaceContainer => "#1C191A";
    public string SurfaceContainerHigh => "#221F20";
    public string SurfaceContainerHighest => "#292526";
}
