using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_NormalContrast_Spec2025 : ITestTheme
{
    public string SourceColor => "#185FAA"; //blue
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#BED6FF";
    public string OnPrimary => "#264A79";
    public string PrimaryContainer => "#A6C8FF";
    public string OnPrimaryContainer => "#1B416F";

    public string Secondary => "#B4CCBC";
    public string OnSecondary => "#304539";
    public string SecondaryContainer => "#152A1F";
    public string OnSecondaryContainer => "#92A99A";

    public string Tertiary => "#DDFFE4";
    public string OnTertiary => "#006C3F";
    public string TertiaryContainer => "#9AFDBF";
    public string OnTertiaryContainer => "#006239";

    public string Error => "#FF716C";
    public string OnError => "#490006";
    public string ErrorContainer => "#8A1A1E";
    public string OnErrorContainer => "#FF9993";

    public string Surface => "#060E1B";
    public string OnSurface => "#D9E6FF";
    public string OnSurfaceVariant => "#9BACCA";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#091423";
    public string SurfaceContainer => "#0D1A2C";
    public string SurfaceContainerHigh => "#112035";
    public string SurfaceContainerHighest => "#15263E";
}
