using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_HighContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#2B2B1F";
    public string OnPrimary => "#E6E3D1";
    public string PrimaryContainer => "#59584A";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#2B2A25";
    public string OnSecondary => "#E6E2D9";
    public string SecondaryContainer => "#595751";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#272C0F";
    public string OnTertiary => "#E0E6BA";
    public string TertiaryContainer => "#555A38";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#560E00";
    public string OnError => "#FFDAD2";
    public string ErrorContainer => "#943B25";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFFBFF";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#2B2A26";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FDF9F4";
    public string SurfaceContainer => "#F7F3EE";
    public string SurfaceContainerHigh => "#F1EDE7";
    public string SurfaceContainerHighest => "#EBE8E1";
}
