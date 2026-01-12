using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_NormalContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#44608A";
    public string OnPrimary => "#F8F8FF";
    public string PrimaryContainer => "#A6C2F2";
    public string OnPrimaryContainer => "#1F3D65";

    public string Secondary => "#556071";
    public string OnSecondary => "#F8F8FF";
    public string SecondaryContainer => "#D9E3F8";
    public string OnSecondaryContainer => "#485264";

    public string Tertiary => "#655882";
    public string OnTertiary => "#FDF7FF";
    public string TertiaryContainer => "#DACAFB";
    public string OnTertiaryContainer => "#4D4169";

    public string Error => "#A83836";
    public string OnError => "#FFF7F6";
    public string ErrorContainer => "#FA746F";
    public string OnErrorContainer => "#6E0A12";

    public string Surface => "#F9F9FE";
    public string OnSurface => "#2F333A";
    public string OnSurfaceVariant => "#5B5F68";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F2F3FA";
    public string SurfaceContainer => "#ECEDF6";
    public string SurfaceContainerHigh => "#E6E8F1";
    public string SurfaceContainerHighest => "#DFE2EC";
}
