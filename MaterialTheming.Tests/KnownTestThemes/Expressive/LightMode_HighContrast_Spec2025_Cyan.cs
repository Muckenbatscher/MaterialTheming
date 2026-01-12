using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_HighContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#00282E";
    public string OnPrimary => "#70EBFF";
    public string PrimaryContainer => "#005B66";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#2B1E3C";
    public string OnSecondary => "#E6D2FB";
    public string SecondaryContainer => "#5A4C6D";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#37075D";
    public string OnTertiary => "#EBD0FF";
    public string TertiaryContainer => "#683E8F";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#510007";
    public string OnError => "#FFCFCB";
    public string ErrorContainer => "#9A2728";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#F2FBFF";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#002832";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#E3F7FF";
    public string SurfaceContainer => "#D3F3FF";
    public string SurfaceContainerHigh => "#C3EFFF";
    public string SurfaceContainerHighest => "#B4EBFE";
}
