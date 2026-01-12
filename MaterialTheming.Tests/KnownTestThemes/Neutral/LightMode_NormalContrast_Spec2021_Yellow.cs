using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_NormalContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#615F4A";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#E7E3C8";
    public string OnPrimaryContainer => "#494833";

    public string Secondary => "#605F51";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#E6E3D1";
    public string OnSecondaryContainer => "#48473A";

    public string Tertiary => "#616042";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#E7E4BF";
    public string OnTertiaryContainer => "#49482D";

    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";

    public string Surface => "#FDF9F4";
    public string OnSurface => "#1C1C19";
    public string OnSurfaceVariant => "#484744";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F7F3EE";
    public string SurfaceContainer => "#F1EDE9";
    public string SurfaceContainerHigh => "#EBE7E3";
    public string SurfaceContainerHighest => "#E6E2DD";
}
