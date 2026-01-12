using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_HighContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#FFFCC6";
    public string OnPrimary => "#3B3A00";
    public string PrimaryContainer => "#F2EF96";
    public string OnPrimaryContainer => "#323100";

    public string Secondary => "#DDE5FC";
    public string OnSecondary => "#242C3D";
    public string SecondaryContainer => "#9CA4B9";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#DEE5FF";
    public string OnTertiary => "#002869";
    public string TertiaryContainer => "#9DB7FF";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFDED7";
    public string OnError => "#5A0E00";
    public string ErrorContainer => "#FF7E5E";
    public string OnErrorContainer => "#000000";

    public string Surface => "#0F0E07";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#EAE7BD";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#14140A";
    public string SurfaceContainer => "#1B1A0D";
    public string SurfaceContainerHigh => "#212010";
    public string SurfaceContainerHighest => "#272712";
}
