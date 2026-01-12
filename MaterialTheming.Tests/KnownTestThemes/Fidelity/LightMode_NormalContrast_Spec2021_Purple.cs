using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class LightMode_NormalContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#7A42B2";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#945CCD";
    public string OnPrimaryContainer => "#0B001B";

    public string Secondary => "#6C5582";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#E6CAFE";
    public string OnSecondaryContainer => "#69527E";

    public string Tertiary => "#6F5D00";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#C4AA3D";
    public string OnTertiaryContainer => "#4C3F00";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#FFF7FE";
    public string OnSurface => "#1E1A21";
    public string OnSurfaceVariant => "#4C4451";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FAF1FB";
    public string SurfaceContainer => "#F4EBF5";
    public string SurfaceContainerHigh => "#EEE5F0";
    public string SurfaceContainerHighest => "#E9E0EA";
}
