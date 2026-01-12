using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_HighContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#FFDCEA";
    public string OnPrimary => "#5A003D";
    public string PrimaryContainer => "#FF71C2";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#FFDBF4";
    public string OnSecondary => "#540052";
    public string SecondaryContainer => "#E282D5";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#E2E4FF";
    public string OnTertiary => "#001D82";
    public string TertiaryContainer => "#8B9DFF";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFDDDF";
    public string OnError => "#5F001C";
    public string ErrorContainer => "#FF798C";
    public string OnErrorContainer => "#000000";

    public string Surface => "#1F031D";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFDBF4";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#270524";
    public string SurfaceContainer => "#2F0A2C";
    public string SurfaceContainerHigh => "#380E34";
    public string SurfaceContainerHighest => "#40143C";
}
