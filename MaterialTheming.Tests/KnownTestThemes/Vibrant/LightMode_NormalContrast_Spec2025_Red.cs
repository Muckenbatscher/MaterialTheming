using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_NormalContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#AE2622";
    public string OnPrimary => "#FFEFED";
    public string PrimaryContainer => "#FF766A";
    public string OnPrimaryContainer => "#4F0003";

    public string Secondary => "#9F364B";
    public string OnSecondary => "#FFEFEF";
    public string SecondaryContainer => "#FFC2C8";
    public string OnSecondaryContainer => "#852138";

    public string Tertiary => "#7841A5";
    public string OnTertiary => "#FCEEFF";
    public string TertiaryContainer => "#D199FF";
    public string OnTertiaryContainer => "#4A0C76";

    public string Error => "#B41340";
    public string OnError => "#FFEFEF";
    public string ErrorContainer => "#F74B6D";
    public string OnErrorContainer => "#510017";

    public string Surface => "#FFF4F4";
    public string OnSurface => "#4D2128";
    public string OnSurfaceVariant => "#824C53";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFECED";
    public string SurfaceContainer => "#FFE1E3";
    public string SurfaceContainerHigh => "#FFD9DC";
    public string SurfaceContainerHighest => "#FFD2D6";
}
