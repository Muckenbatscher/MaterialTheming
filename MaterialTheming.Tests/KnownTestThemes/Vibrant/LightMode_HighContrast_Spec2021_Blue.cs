using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_HighContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#002C58";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#00498B";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#232B48";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#404867";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#2A2654";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#474373";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#F9F9FF";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#ECF1FD";
    public string SurfaceContainer => "#DEE2EF";
    public string SurfaceContainerHigh => "#D0D4E0";
    public string SurfaceContainerHighest => "#C2C6D2";
}
