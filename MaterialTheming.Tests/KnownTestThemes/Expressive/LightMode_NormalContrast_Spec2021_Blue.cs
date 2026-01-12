using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_NormalContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#3E692E";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#BFF0A6";
    public string OnPrimaryContainer => "#275018";

    public string Secondary => "#7B5266";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#FFD8E8";
    public string OnSecondaryContainer => "#613B4E";

    public string Tertiary => "#505C8B";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#DCE1FF";
    public string OnTertiaryContainer => "#384472";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#FAF8FF";
    public string OnSurface => "#1A1B23";
    public string OnSurfaceVariant => "#444654";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F3F2FD";
    public string SurfaceContainer => "#EEEDF8";
    public string SurfaceContainerHigh => "#E8E7F2";
    public string SurfaceContainerHighest => "#E2E1EC";
}
