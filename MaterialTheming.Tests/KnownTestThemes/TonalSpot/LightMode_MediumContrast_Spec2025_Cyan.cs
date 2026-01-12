using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_MediumContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#004A53";
    public string OnPrimary => "#A1E5F1";
    public string PrimaryContainer => "#387E89";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#2F474B";
    public string OnSecondary => "#C4DEE4";
    public string SecondaryContainer => "#60797D";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#254563";
    public string OnTertiary => "#BFDCFF";
    public string TertiaryContainer => "#587798";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#811B1D";
    public string OnError => "#FFCECA";
    public string ErrorContainer => "#C54D4A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#F6FAFB";
    public string OnSurface => "#1C2627";
    public string OnSurfaceVariant => "#3B4546";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#EEF5F6";
    public string SurfaceContainer => "#E8EFF1";
    public string SurfaceContainerHigh => "#E1EAEB";
    public string SurfaceContainerHighest => "#DAE4E7";
}
