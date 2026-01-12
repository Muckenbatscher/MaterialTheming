using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class DarkMode_MediumContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#FFD3BB";
    public string OnPrimary => "#411A00";
    public string PrimaryContainer => "#D77837";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#FFD3BB";
    public string OnSecondary => "#3E1D06";
    public string SecondaryContainer => "#B98566";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#DDE468";
    public string OnTertiary => "#252800";
    public string TertiaryContainer => "#919722";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#1A120D";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#F2D7C9";

    public string SurfaceContainerLowest => "#0D0603";
    public string SurfaceContainerLow => "#251C17";
    public string SurfaceContainer => "#2F2621";
    public string SurfaceContainerHigh => "#3B302B";
    public string SurfaceContainerHighest => "#463B36";
}
