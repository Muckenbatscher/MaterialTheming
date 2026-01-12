using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_NormalContrast_Spec2025_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#1C6D31";
    public string OnPrimary => "#E9FFE5";
    public string PrimaryContainer => "#9EF0A5";
    public string OnPrimaryContainer => "#005B23";

    public string Secondary => "#80553B";
    public string OnSecondary => "#FFF7F5";
    public string SecondaryContainer => "#FFDBC8";
    public string OnSecondaryContainer => "#71482F";

    public string Tertiary => "#994818";
    public string OnTertiary => "#FFF7F5";
    public string TertiaryContainer => "#FFA273";
    public string OnTertiaryContainer => "#602400";

    public string Error => "#AA371C";
    public string OnError => "#FFF7F6";
    public string ErrorContainer => "#FA7150";
    public string OnErrorContainer => "#671200";

    public string Surface => "#E9FFED";
    public string OnSurface => "#083A23";
    public string OnSurfaceVariant => "#3A684D";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#DAFCE3";
    public string SurfaceContainer => "#D0F7DB";
    public string SurfaceContainerHigh => "#C6F3D3";
    public string SurfaceContainerHighest => "#BCEECB";
}
