using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_HighContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#002041";
    public string OnPrimary => "#BED6FF";
    public string PrimaryContainer => "#004F94";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#001C4F";
    public string OnSecondary => "#C6D4FF";
    public string SecondaryContainer => "#1049A9";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#39004D";
    public string OnTertiary => "#F4C4FF";
    public string TertiaryContainer => "#74308D";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#480005";
    public string OnError => "#FFC7C3";
    public string ErrorContainer => "#A0071A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#F6F6FF";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#0E1E41";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#EEF0FF";
    public string SurfaceContainer => "#E2E7FF";
    public string SurfaceContainerHigh => "#DAE2FF";
    public string SurfaceContainerHighest => "#D2DCFF";
}
