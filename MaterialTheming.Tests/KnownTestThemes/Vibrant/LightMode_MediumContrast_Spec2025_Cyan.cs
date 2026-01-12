using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_MediumContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#00464F";
    public string OnPrimary => "#41E8FF";
    public string PrimaryContainer => "#00818F";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#004655";
    public string OnSecondary => "#81E1FF";
    public string SecondaryContainer => "#007F99";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#003F7B";
    public string OnTertiary => "#BED5FF";
    public string TertiaryContainer => "#2675CF";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#850012";
    public string OnError => "#FFC7C2";
    public string ErrorContainer => "#D7383B";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#EAF9FF";
    public string OnSurface => "#00232C";
    public string OnSurfaceVariant => "#054654";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#DBF5FF";
    public string SurfaceContainer => "#C3EFFF";
    public string SurfaceContainerHigh => "#B2EBFF";
    public string SurfaceContainerHighest => "#A0E7FF";
}
