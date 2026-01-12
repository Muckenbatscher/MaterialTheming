using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_MediumContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#3C434F";
    public string OnPrimary => "#D3DAE9";
    public string PrimaryContainer => "#6E7582";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#414348";
    public string OnSecondary => "#D8D9E0";
    public string SecondaryContainer => "#73747A";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#40415B";
    public string OnTertiary => "#D8D7F7";
    public string TertiaryContainer => "#72728F";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#7A2524";
    public string OnError => "#FFCECA";
    public string ErrorContainer => "#BB5551";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FCF8F9";
    public string OnSurface => "#232426";
    public string OnSurfaceVariant => "#424345";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F6F3F4";
    public string SurfaceContainer => "#F0EDEF";
    public string SurfaceContainerHigh => "#EAE7EA";
    public string SurfaceContainerHighest => "#E4E2E5";
}
