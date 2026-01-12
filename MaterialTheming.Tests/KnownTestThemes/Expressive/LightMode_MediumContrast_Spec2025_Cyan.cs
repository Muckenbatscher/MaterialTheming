using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_MediumContrast_Spec2025_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#004A53";
    public string OnPrimary => "#6DEBFF";
    public string PrimaryContainer => "#00818F";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#4B3D5D";
    public string OnSecondary => "#E5D2FB";
    public string SecondaryContainer => "#7E6E92";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#582E7E";
    public string OnTertiary => "#EBD0FF";
    public string TertiaryContainer => "#8D61B4";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#84161B";
    public string OnError => "#FFCECA";
    public string ErrorContainer => "#C94947";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#F2FBFF";
    public string OnSurface => "#002832";
    public string OnSurfaceVariant => "#064959";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#E3F7FF";
    public string SurfaceContainer => "#D3F3FF";
    public string SurfaceContainerHigh => "#C3EFFF";
    public string SurfaceContainerHighest => "#B4EBFE";
}
