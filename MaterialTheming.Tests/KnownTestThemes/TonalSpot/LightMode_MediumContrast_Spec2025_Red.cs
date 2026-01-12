using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_MediumContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#6A322D";
    public string OnPrimary => "#FFCEC9";
    public string PrimaryContainer => "#A5625B";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#593B38";
    public string OnSecondary => "#FBD0CA";
    public string SecondaryContainer => "#8F6C68";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#5B3D0E";
    public string OnTertiary => "#FFD29B";
    public string TertiaryContainer => "#936E3B";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#821830";
    public string OnError => "#FFCDD1";
    public string ErrorContainer => "#C44B5F";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F7";
    public string OnSurface => "#2E211F";
    public string OnSurfaceVariant => "#4F3F3D";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0EE";
    public string SurfaceContainer => "#FEE9E6";
    public string SurfaceContainerHigh => "#FAE3E0";
    public string SurfaceContainerHighest => "#F6DDDA";
}
