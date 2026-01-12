using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_MediumContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#8DBBFF";
    public string OnPrimary => "#002C58";
    public string PrimaryContainer => "#5BA2FF";
    public string OnPrimaryContainer => "#00142E";

    public string Secondary => "#9DB7FF";
    public string OnSecondary => "#002868";
    public string SecondaryContainer => "#4570D2";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#EAA5FF";
    public string OnTertiary => "#51066B";
    public string TertiaryContainer => "#E094F8";
    public string OnTertiaryContainer => "#420059";

    public string Error => "#FF9F99";
    public string OnError => "#60000A";
    public string ErrorContainer => "#D7383B";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#000C2B";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#A9B8E3";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#001136";
    public string SurfaceContainer => "#011742";
    public string SurfaceContainerHigh => "#041D4B";
    public string SurfaceContainerHighest => "#082355";
}
