using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_NormalContrast_Spec2025_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#6B5A58";
    public string OnPrimary => "#FFF6F4";
    public string PrimaryContainer => "#F5DDDA";
    public string OnPrimaryContainer => "#5E4E4C";

    public string Secondary => "#665D5C";
    public string OnSecondary => "#FFF7F6";
    public string SecondaryContainer => "#EDE0DE";
    public string OnSecondaryContainer => "#58504F";

    public string Tertiary => "#785564";
    public string OnTertiary => "#FFF7F8";
    public string TertiaryContainer => "#F5C8DA";
    public string OnTertiaryContainer => "#60404E";

    public string Error => "#9E3F4E";
    public string OnError => "#FFF7F7";
    public string ErrorContainer => "#FF8B9A";
    public string OnErrorContainer => "#782232";

    public string Surface => "#FFF8F7";
    public string OnSurface => "#373130";
    public string OnSurfaceVariant => "#655D5C";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FAF2F1";
    public string SurfaceContainer => "#F5ECEB";
    public string SurfaceContainerHigh => "#F0E6E5";
    public string SurfaceContainerHighest => "#EBE0DF";
}
