using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_MediumContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    public string Primary => "#26446C";
    public string OnPrimary => "#C6DBFF";
    public string PrimaryContainer => "#5A76A1";
    public string OnPrimaryContainer => "#FFFFFF";

    public string Secondary => "#394354";
    public string OnSecondary => "#D0DAEF";
    public string SecondaryContainer => "#6B7588";
    public string OnSecondaryContainer => "#FFFFFF";

    public string Tertiary => "#483C64";
    public string OnTertiary => "#E1D3FF";
    public string TertiaryContainer => "#7B6E99";
    public string OnTertiaryContainer => "#FFFFFF";

    public string Error => "#811B1D";
    public string OnError => "#FFCECA";
    public string ErrorContainer => "#C54D4A";
    public string OnErrorContainer => "#FFFFFF";

    public string Surface => "#F9F9FE";
    public string OnSurface => "#20242B";
    public string OnSurfaceVariant => "#3F434B";

    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F2F3FA";
    public string SurfaceContainer => "#ECEDF6";
    public string SurfaceContainerHigh => "#E6E8F1";
    public string SurfaceContainerHighest => "#DFE2EC";
}
