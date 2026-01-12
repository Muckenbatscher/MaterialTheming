using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_NormalContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#684FA4";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#E9DDFF";
    public string OnPrimaryContainer => "#50378A";

    public string Secondary => "#66558E";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#E9DDFF";
    public string OnSecondaryContainer => "#4D3D75";

    public string Tertiary => "#884B6B";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#FFD8E8";
    public string OnTertiaryContainer => "#6C3353";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#FFF8F8";
    public string OnSurface => "#24181E";
    public string OnSurfaceVariant => "#58404B";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0F4";
    public string SurfaceContainer => "#FFE8F0";
    public string SurfaceContainerHigh => "#FAE2EB";
    public string SurfaceContainerHighest => "#F4DDE5";
}
