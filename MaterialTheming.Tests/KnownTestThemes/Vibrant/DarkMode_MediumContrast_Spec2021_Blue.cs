using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_MediumContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#CBDDFF";
    public string OnPrimary => "#00264C";
    public string PrimaryContainer => "#2B91FF";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#D4DBFF";
    public string OnSecondary => "#1C2442";
    public string SecondaryContainer => "#888FB3";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#DDD8FF";
    public string OnTertiary => "#231F4D";
    public string TertiaryContainer => "#908BC0";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#0E141C";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#D6DCEC";

    public string SurfaceContainerLowest => "#04080F";
    public string SurfaceContainerLow => "#191E26";
    public string SurfaceContainer => "#232831";
    public string SurfaceContainerHigh => "#2E333C";
    public string SurfaceContainerHighest => "#393E47";
}
