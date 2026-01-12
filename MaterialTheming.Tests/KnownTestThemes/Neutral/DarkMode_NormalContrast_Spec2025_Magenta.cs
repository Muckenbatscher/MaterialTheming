using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_NormalContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#D4C2C8";
    public string OnPrimary => "#493D42";
    public string PrimaryContainer => "#504348";
    public string OnPrimaryContainer => "#DECCD2";

    public string Secondary => "#A59C9E";
    public string OnSecondary => "#241F21";
    public string SecondaryContainer => "#403A3C";
    public string OnSecondaryContainer => "#C7BDBF";

    public string Tertiary => "#FEEFFF";
    public string OnTertiary => "#68556F";
    public string TertiaryContainer => "#F6DDFD";
    public string OnTertiaryContainer => "#5F4D67";

    public string Error => "#EC7C8A";
    public string OnError => "#490013";
    public string ErrorContainer => "#7F2737";
    public string OnErrorContainer => "#FF97A3";

    public string Surface => "#0F0E0E";
    public string OnSurface => "#ECE3E5";
    public string OnSurfaceVariant => "#B1A9AB";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#151313";
    public string SurfaceContainer => "#1C191A";
    public string SurfaceContainerHigh => "#221F20";
    public string SurfaceContainerHighest => "#292526";
}
