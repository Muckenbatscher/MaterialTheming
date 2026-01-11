using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_MediumContrast_Spec2025 : ITestTheme
{
    public string SourceColor => "#E85DAE"; //magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#4C3F45";
    public string OnPrimary => "#E8D5DB";
    public string PrimaryContainer => "#7F7176";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#484143";
    public string OnSecondary => "#E2D7D9";
    public string SecondaryContainer => "#7A7275";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#4E3D55";
    public string OnTertiary => "#EAD2F1";
    public string TertiaryContainer => "#826E89";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#7A2333";
    public string OnError => "#FFCDD1";
    public string ErrorContainer => "#B95463";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#FEF8F8";
    public string OnSurface => "#272324";
    public string OnSurfaceVariant => "#474143";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F9F2F2";
    public string SurfaceContainer => "#F4ECED";
    public string SurfaceContainerHigh => "#EFE6E7";
    public string SurfaceContainerHighest => "#E9E0E2";
}
