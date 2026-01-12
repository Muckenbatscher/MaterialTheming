using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_MediumContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#FF98CE";
    public string OnPrimary => "#5A003D";
    public string PrimaryContainer => "#FF6AC0";
    public string OnPrimaryContainer => "#30001F";

    public string Secondary => "#FD99EE";
    public string OnSecondary => "#580055";
    public string SecondaryContainer => "#AC53A2";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#A8B4FF";
    public string OnTertiary => "#001D82";
    public string TertiaryContainer => "#8397FF";
    public string OnTertiaryContainer => "#00093E";

    public string Error => "#FF9DA8";
    public string OnError => "#5F001C";
    public string ErrorContainer => "#D73357";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#1F031D";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#DAAACF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#270524";
    public string SurfaceContainer => "#2F0A2C";
    public string SurfaceContainerHigh => "#380E34";
    public string SurfaceContainerHighest => "#40143C";
}
