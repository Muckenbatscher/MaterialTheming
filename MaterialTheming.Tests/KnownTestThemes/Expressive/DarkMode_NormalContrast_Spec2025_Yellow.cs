using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_NormalContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#FFFCC6";
    public string OnPrimary => "#636218";
    public string PrimaryContainer => "#F2EF96";
    public string OnPrimaryContainer => "#5B590F";

    public string Secondary => "#BEC6DC";
    public string OnSecondary => "#384052";
    public string SecondaryContainer => "#1E2636";
    public string OnSecondaryContainer => "#9CA4B9";

    public string Tertiary => "#B2C5FF";
    public string OnTertiary => "#143C88";
    public string TertiaryContainer => "#9DB7FF";
    public string OnTertiaryContainer => "#01327E";

    public string Error => "#FE7453";
    public string OnError => "#450900";
    public string ErrorContainer => "#881F05";
    public string OnErrorContainer => "#FF9B82";

    public string Surface => "#0F0E07";
    public string OnSurface => "#EAE7BD";
    public string OnSurfaceVariant => "#AFAD86";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#14140A";
    public string SurfaceContainer => "#1B1A0D";
    public string SurfaceContainerHigh => "#212010";
    public string SurfaceContainerHighest => "#272712";
}
