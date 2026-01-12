using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_MediumContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#D4C2C8";
    public string OnPrimary => "#3F3338";
    public string PrimaryContainer => "#7F7176";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#C0B6B9";
    public string OnSecondary => "#302B2D";
    public string SecondaryContainer => "#7A7275";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#FEEFFF";
    public string OnTertiary => "#5D4B65";
    public string TertiaryContainer => "#F6DDFD";
    public string OnTertiaryContainer => "#55435C";

    public string Error => "#FF9DA8";
    public string OnError => "#5B0A1E";
    public string ErrorContainer => "#B95463";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#0F0E0E";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#BFB7B8";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#151313";
    public string SurfaceContainer => "#1C191A";
    public string SurfaceContainerHigh => "#221F20";
    public string SurfaceContainerHighest => "#292526";
}
