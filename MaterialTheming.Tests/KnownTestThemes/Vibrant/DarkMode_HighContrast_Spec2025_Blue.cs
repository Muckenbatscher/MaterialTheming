using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_HighContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#D9E6FF";
    public string OnPrimary => "#002C58";
    public string PrimaryContainer => "#63A5FF";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#DEE5FF";
    public string OnSecondary => "#002868";
    public string SecondaryContainer => "#7BA1FF";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#FBDCFF";
    public string OnTertiary => "#4C0066";
    public string TertiaryContainer => "#E094F8";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFDEDB";
    public string OnError => "#60000A";
    public string ErrorContainer => "#FF7C76";
    public string OnErrorContainer => "#000000";

    public string Surface => "#000C2B";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#DEE5FF";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#001136";
    public string SurfaceContainer => "#011742";
    public string SurfaceContainerHigh => "#041D4B";
    public string SurfaceContainerHighest => "#082355";
}
