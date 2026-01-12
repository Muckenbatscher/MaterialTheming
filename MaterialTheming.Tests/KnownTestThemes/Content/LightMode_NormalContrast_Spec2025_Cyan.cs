using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class LightMode_NormalContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#006875";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#00BCD1";
    public string OnPrimaryContainer => "#00464F";

    public string Secondary => "#37656D";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#BBEBF4";
    public string OnSecondaryContainer => "#3D6B73";

    public string Tertiary => "#7C489A";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#CE94ED";
    public string OnTertiaryContainer => "#5A2678";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#F4FAFC";
    public string OnSurface => "#161D1E";
    public string OnSurfaceVariant => "#3C494B";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#EFF5F6";
    public string SurfaceContainer => "#E9EFF0";
    public string SurfaceContainerHigh => "#E3E9EB";
    public string SurfaceContainerHighest => "#DDE4E5";
}
