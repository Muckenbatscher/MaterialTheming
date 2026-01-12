using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_NormalContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#FF85C7";
    public string OnPrimary => "#5E0040";
    public string PrimaryContainer => "#FF6AC0";
    public string OnPrimaryContainer => "#490031";

    public string Secondary => "#FD99EE";
    public string OnSecondary => "#651061";
    public string SecondaryContainer => "#762370";
    public string OnSecondaryContainer => "#FFBBF1";

    public string Tertiary => "#8EA0FF";
    public string OnTertiary => "#001A77";
    public string TertiaryContainer => "#7D91FA";
    public string OnTertiaryContainer => "#001056";

    public string Error => "#FF6E84";
    public string OnError => "#490013";
    public string ErrorContainer => "#A70138";
    public string OnErrorContainer => "#FFB2B9";

    public string Surface => "#1F031D";
    public string OnSurface => "#FFDBF4";
    public string OnSurfaceVariant => "#CC9DC1";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#270524";
    public string SurfaceContainer => "#2F0A2C";
    public string SurfaceContainerHigh => "#380E34";
    public string SurfaceContainerHighest => "#40143C";
}
