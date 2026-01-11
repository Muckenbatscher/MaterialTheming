using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_NormalContrast_Spec2021 : ITestTheme
{
    public string SourceColor => "#E85DAE"; //magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#006685";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#BFE9FF";
    public string OnPrimaryContainer => "#004D65";

    public string Secondary => "#815345";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#FFDBD1";
    public string OnSecondaryContainer => "#663C2F";

    public string Tertiary => "#626122";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#E9E698";
    public string OnTertiaryContainer => "#4A490A";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#FFF8F7";
    public string OnSurface => "#24191B";
    public string OnSurfaceVariant => "#564145";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0F1";
    public string SurfaceContainer => "#FFE9EB";
    public string SurfaceContainerHigh => "#F9E3E6";
    public string SurfaceContainerHighest => "#F3DDE0";
}
