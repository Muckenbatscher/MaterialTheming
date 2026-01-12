using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_MediumContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#163F08";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#4D783B";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#4E2B3D";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#8B6175";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#273460";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#5F6B9B";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FAF8FF";
    public string OnSurface => "#0F1118";
    public string OnSurfaceVariant => "#333643";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F3F2FD";
    public string SurfaceContainer => "#E8E7F2";
    public string SurfaceContainerHigh => "#DCDCE6";
    public string SurfaceContainerHighest => "#D1D1DB";
}
