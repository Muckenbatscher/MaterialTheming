using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_HighContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#431411";
    public string OnPrimary => "#FFCFC9";
    public string PrimaryContainer => "#7D413B";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#361D1A";
    public string OnSecondary => "#FCD0CB";
    public string SecondaryContainer => "#6A4A47";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#351F00";
    public string OnTertiary => "#FFD39C";
    public string TertiaryContainer => "#6D4C1C";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#500016";
    public string OnError => "#FFCED2";
    public string ErrorContainer => "#97283E";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F7";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#2E211F";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0EE";
    public string SurfaceContainer => "#FEE9E6";
    public string SurfaceContainerHigh => "#FAE3E0";
    public string SurfaceContainerHighest => "#F6DDDA";
}
