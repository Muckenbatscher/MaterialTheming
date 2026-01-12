using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_MediumContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#0A356D";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#4C6DA8";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#333913";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#6A7145";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#1A3E18";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#50764A";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FFF8F6";
    public string OnSurface => "#190F0A";
    public string OnSurfaceVariant => "#46312A";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1EC";
    public string SurfaceContainer => "#FBE3DC";
    public string SurfaceContainerHigh => "#EFD8D0";
    public string SurfaceContainerHighest => "#E3CDC5";
}
