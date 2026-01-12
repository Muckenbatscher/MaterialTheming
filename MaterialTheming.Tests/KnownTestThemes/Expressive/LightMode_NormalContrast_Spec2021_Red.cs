using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_NormalContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#3D5E98";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#D7E2FF";
    public string OnPrimaryContainer => "#22467F";

    public string Secondary => "#5B6237";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#E0E7B1";
    public string OnSecondaryContainer => "#444A22";

    public string Tertiary => "#42673D";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#C3EEB8";
    public string OnTertiaryContainer => "#2A4F27";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#FFF8F6";
    public string OnSurface => "#251914";
    public string OnSurfaceVariant => "#58423A";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1EC";
    public string SurfaceContainer => "#FFE9E2";
    public string SurfaceContainerHigh => "#FBE3DC";
    public string SurfaceContainerHighest => "#F5DED6";
}
