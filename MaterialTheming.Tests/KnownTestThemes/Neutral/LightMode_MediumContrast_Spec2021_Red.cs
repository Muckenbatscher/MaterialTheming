using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_MediumContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#46312E";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#816764";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#413331";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#7B6967";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#4B2F2C";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#876561";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F7";
    public string OnSurface => "#131010";
    public string OnSurfaceVariant => "#393535";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FAF2F0";
    public string SurfaceContainer => "#EFE6E5";
    public string SurfaceContainerHigh => "#E3DBDA";
    public string SurfaceContainerHighest => "#D8D0CF";
}
