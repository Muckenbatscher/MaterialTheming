using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_NormalContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#1C6873";
    public string OnPrimary => "#ECFCFF";
    public string PrimaryContainer => "#A9EEFA";
    public string OnPrimaryContainer => "#015B65";

    public string Secondary => "#4B6368";
    public string OnSecondary => "#ECFCFF";
    public string SecondaryContainer => "#CDE7EC";
    public string OnSecondaryContainer => "#3E565A";

    public string Tertiary => "#436281";
    public string OnTertiary => "#F7F9FF";
    public string TertiaryContainer => "#BADAFF";
    public string OnTertiaryContainer => "#2E4D6C";

    public string Error => "#A83836";
    public string OnError => "#FFF7F6";
    public string ErrorContainer => "#FA746F";
    public string OnErrorContainer => "#6E0A12";

    public string Surface => "#F6FAFB";
    public string OnSurface => "#2A3436";
    public string OnSurfaceVariant => "#576163";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#EEF5F6";
    public string SurfaceContainer => "#E8EFF1";
    public string SurfaceContainerHigh => "#E1EAEB";
    public string SurfaceContainerHighest => "#DAE4E7";
}
