using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_HighContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#2F1946";
    public string OnPrimary => "#EAD0FF";
    public string PrimaryContainer => "#604877";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#292032";
    public string OnSecondary => "#E4D5EE";
    public string SecondaryContainer => "#594E62";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#3C172C";
    public string OnTertiary => "#FFCCE2";
    public string TertiaryContainer => "#72445B";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#500016";
    public string OnError => "#FFCED2";
    public string ErrorContainer => "#97283E";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF7FE";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#27222B";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F9F1F9";
    public string SurfaceContainer => "#F4EBF5";
    public string SurfaceContainerHigh => "#EEE5F0";
    public string SurfaceContainerHighest => "#E9DFEB";
}
