using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class LightMode_NormalContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#AC2B25";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#CF443B";
    public string OnPrimaryContainer => "#FFFBFF";

    public string Secondary => "#924941";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#FEA096";
    public string OnSecondaryContainer => "#78342E";

    public string Tertiary => "#00666E";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#00818B";
    public string OnTertiaryContainer => "#F5FEFF";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#FFF8F7";
    public string OnSurface => "#261817";
    public string OnSurfaceVariant => "#59413E";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0EE";
    public string SurfaceContainer => "#FFE9E6";
    public string SurfaceContainerHigh => "#FCE2DF";
    public string SurfaceContainerHighest => "#F6DDDA";
}
