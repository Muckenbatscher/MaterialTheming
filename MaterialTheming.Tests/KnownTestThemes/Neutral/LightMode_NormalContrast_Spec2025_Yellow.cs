using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_NormalContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#605F51";
    public string OnPrimary => "#FCF8E6";
    public string PrimaryContainer => "#E6E3D1";
    public string OnPrimaryContainer => "#535245";

    public string Secondary => "#66645D";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#E6E2D9";
    public string OnSecondaryContainer => "#53524B";

    public string Tertiary => "#626844";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#F2F8CA";
    public string OnTertiaryContainer => "#595F3C";

    public string Error => "#A54731";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FE8B70";
    public string OnErrorContainer => "#742410";

    public string Surface => "#FFFBFF";
    public string OnSurface => "#393833";
    public string OnSurfaceVariant => "#66645F";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FDF9F4";
    public string SurfaceContainer => "#F7F3EE";
    public string SurfaceContainerHigh => "#F1EDE7";
    public string SurfaceContainerHighest => "#EBE8E1";
}
