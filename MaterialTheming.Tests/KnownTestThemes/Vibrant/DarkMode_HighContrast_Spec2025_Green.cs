using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_HighContrast_Spec2025_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#83FF97";
    public string OnPrimary => "#003411";
    public string PrimaryContainer => "#02BF51";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#80FEB7";
    public string OnSecondary => "#00341D";
    public string SecondaryContainer => "#34B979";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#ABF1FF";
    public string OnTertiary => "#003138";
    public string TertiaryContainer => "#00E3FF";
    public string OnTertiaryContainer => "#001E23";

    public string Error => "#FFDED7";
    public string OnError => "#5A0E00";
    public string ErrorContainer => "#FF7E5E";
    public string OnErrorContainer => "#000000";

    public string Surface => "#001207";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#C0F1CF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#00180A";
    public string SurfaceContainer => "#001F0F";
    public string SurfaceContainerHigh => "#002613";
    public string SurfaceContainerHighest => "#002D18";
}
