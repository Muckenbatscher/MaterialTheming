using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_MediumContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#3B4446";
    public string OnPrimary => "#D2DBDD";
    public string PrimaryContainer => "#6D7678";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#404344";
    public string OnSecondary => "#D8DADA";
    public string SecondaryContainer => "#727576";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#2C4655";
    public string OnTertiary => "#C2DEF0";
    public string TertiaryContainer => "#5E7888";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#7A2524";
    public string OnError => "#FFCECA";
    public string ErrorContainer => "#BB5551";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FBF9F8";
    public string OnSurface => "#222425";
    public string OnSurfaceVariant => "#414344";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F5F3F3";
    public string SurfaceContainer => "#EEEEED";
    public string SurfaceContainerHigh => "#E8E8E8";
    public string SurfaceContainerHighest => "#E2E2E3";
}
