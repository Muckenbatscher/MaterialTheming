using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_HighContrast_Spec2025 : ITestTheme
{
    public string SourceColor => "#E85DAE"; //magenta
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#3F142D";
    public string OnPrimary => "#FFCCE3";
    public string PrimaryContainer => "#76415D";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#331D28";
    public string OnSecondary => "#F4D1DF";
    public string SecondaryContainer => "#654B57";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#311A3D";
    public string OnTertiary => "#F0CEFD";
    public string TertiaryContainer => "#63486F";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#500016";
    public string OnError => "#FFCED2";
    public string ErrorContainer => "#97283E";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F8";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#2C2126";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0F4";
    public string SurfaceContainer => "#FBEAEF";
    public string SurfaceContainerHigh => "#F6E4E9";
    public string SurfaceContainerHighest => "#F1DDE4";
}
