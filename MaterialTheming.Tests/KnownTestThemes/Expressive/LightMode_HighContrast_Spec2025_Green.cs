using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_HighContrast_Spec2025_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#002B0C";
    public string OnPrimary => "#9BEDA2";
    public string PrimaryContainer => "#055F26";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#3B1C06";
    public string OnSecondary => "#FFD1B7";
    public string SecondaryContainer => "#71492F";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#421700";
    public string OnTertiary => "#FFD0BB";
    public string TertiaryContainer => "#883B0B";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#4C0A00";
    public string OnError => "#FFCFC4";
    public string ErrorContainer => "#982B10";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#E9FFED";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#002A17";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#DAFCE3";
    public string SurfaceContainer => "#D0F7DB";
    public string SurfaceContainerHigh => "#C6F3D3";
    public string SurfaceContainerHighest => "#BCEECB";
}
