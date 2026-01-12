using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_HighContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#00282E";
    public string OnPrimary => "#A1E5F2";
    public string PrimaryContainer => "#025B66";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#0E272B";
    public string OnSecondary => "#C5DFE4";
    public string SecondaryContainer => "#3E565B";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#002641";
    public string OnTertiary => "#C0DDFF";
    public string TertiaryContainer => "#355573";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#510007";
    public string OnError => "#FFCFCB";
    public string ErrorContainer => "#972B2B";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#F6FAFB";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#1C2627";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#EEF5F6";
    public string SurfaceContainer => "#E8EFF1";
    public string SurfaceContainerHigh => "#E1EAEB";
    public string SurfaceContainerHighest => "#DAE4E7";
}
