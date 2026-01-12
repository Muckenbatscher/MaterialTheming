using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_MediumContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#FFFCC6";
    public string OnPrimary => "#59580D";
    public string PrimaryContainer => "#F2EF96";
    public string OnPrimaryContainer => "#504F04";

    public string Secondary => "#BEC6DC";
    public string OnSecondary => "#2E3647";
    public string SecondaryContainer => "#6C7488";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#B2C5FF";
    public string OnTertiary => "#00317E";
    public string TertiaryContainer => "#9DB7FF";
    public string OnTertiaryContainer => "#002869";

    public string Error => "#FFA089";
    public string OnError => "#5A0E00";
    public string ErrorContainer => "#C74C2F";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#0F0E07";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#BDBB93";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#14140A";
    public string SurfaceContainer => "#1B1A0D";
    public string SurfaceContainerHigh => "#212010";
    public string SurfaceContainerHighest => "#272712";
}
