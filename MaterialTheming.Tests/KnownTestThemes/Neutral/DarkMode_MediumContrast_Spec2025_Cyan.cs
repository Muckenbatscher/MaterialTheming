using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_MediumContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#BFC8CA";
    public string OnPrimary => "#2F3839";
    public string PrimaryContainer => "#6D7678";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#B6B9BA";
    public string OnSecondary => "#292D2D";
    public string SecondaryContainer => "#727576";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#EFF8FF";
    public string OnTertiary => "#3D5766";
    public string TertiaryContainer => "#D0ECFF";
    public string OnTertiaryContainer => "#354E5E";

    public string Error => "#FF9F99";
    public string OnError => "#5B0D10";
    public string ErrorContainer => "#BB5551";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#0E0E0E";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#B8B9B9";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#121414";
    public string SurfaceContainer => "#181A1A";
    public string SurfaceContainerHigh => "#1E2020";
    public string SurfaceContainerHighest => "#242627";
}
