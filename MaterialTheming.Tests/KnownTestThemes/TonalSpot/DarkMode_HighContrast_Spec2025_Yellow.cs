using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_HighContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#EBE8AA";
    public string OnPrimary => "#2E2E02";
    public string PrimaryContainer => "#A8A66E";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#EAE7C2";
    public string OnSecondary => "#2E2D14";
    public string SecondaryContainer => "#A7A583";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#FFE4C0";
    public string OnTertiary => "#402900";
    public string TertiaryContainer => "#FED494";
    public string OnTertiaryContainer => "#332000";

    public string Error => "#FFDED7";
    public string OnError => "#5A0E00";
    public string ErrorContainer => "#FF7E5E";
    public string OnErrorContainer => "#000000";

    public string Surface => "#0F0E08";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E9E6D3";

    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#14140C";
    public string SurfaceContainer => "#1A1A11";
    public string SurfaceContainerHigh => "#212016";
    public string SurfaceContainerHighest => "#27261A";
}
