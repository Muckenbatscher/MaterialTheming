using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_NormalContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#9D423A";
    public string OnPrimary => "#FFF7F6";
    public string PrimaryContainer => "#FFACA2";
    public string OnPrimaryContainer => "#70211C";

    public string Secondary => "#3D6473";
    public string OnSecondary => "#F2FAFF";
    public string SecondaryContainer => "#C0E9FA";
    public string OnSecondaryContainer => "#2F5766";

    public string Tertiary => "#00687D";
    public string OnTertiary => "#F0FBFF";
    public string TertiaryContainer => "#58D6F7";
    public string OnTertiaryContainer => "#004756";

    public string Error => "#AC3149";
    public string OnError => "#FFF7F7";
    public string ErrorContainer => "#F76A80";
    public string OnErrorContainer => "#68001F";

    public string Surface => "#FFF8F6";
    public string OnSurface => "#532518";
    public string OnSurfaceVariant => "#885140";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1ED";
    public string SurfaceContainer => "#FFE9E4";
    public string SurfaceContainerHigh => "#FFE2DA";
    public string SurfaceContainerHighest => "#FFDBD1";
}
