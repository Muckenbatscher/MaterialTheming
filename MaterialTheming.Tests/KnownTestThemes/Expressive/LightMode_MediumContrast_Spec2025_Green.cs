using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_MediumContrast_Spec2025_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#004E1D";
    public string OnPrimary => "#9BECA2";
    public string PrimaryContainer => "#358445";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#603A22";
    public string OnSecondary => "#FFD0B6";
    public string SecondaryContainer => "#986A4F";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#732D00";
    public string OnTertiary => "#FFD0BA";
    public string TertiaryContainer => "#B45C2B";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#821B02";
    public string OnError => "#FFCFC4";
    public string ErrorContainer => "#C74C2F";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#E9FFED";
    public string OnSurface => "#002A17";
    public string OnSurfaceVariant => "#1D4B32";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#DAFCE3";
    public string SurfaceContainer => "#D0F7DB";
    public string SurfaceContainerHigh => "#C6F3D3";
    public string SurfaceContainerHighest => "#BCEECB";
}
