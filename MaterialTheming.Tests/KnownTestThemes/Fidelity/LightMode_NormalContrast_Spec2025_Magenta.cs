using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class LightMode_NormalContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#A62477";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#C54091";
    public string OnPrimaryContainer => "#FFFBFF";

    public string Secondary => "#8A496C";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#FFAFD6";
    public string OnSecondaryContainer => "#7C3E5F";

    public string Tertiary => "#2D6900";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#3A8500";
    public string OnTertiaryContainer => "#F9FFED";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#FFF8F8";
    public string OnSurface => "#23181D";
    public string OnSurfaceVariant => "#55414A";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0F4";
    public string SurfaceContainer => "#FDE9F0";
    public string SurfaceContainerHigh => "#F8E3EA";
    public string SurfaceContainerHighest => "#F2DDE4";
}
