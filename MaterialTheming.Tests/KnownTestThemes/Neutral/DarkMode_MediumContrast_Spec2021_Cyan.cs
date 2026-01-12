using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_MediumContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#CEDFE3";
    public string OnPrimary => "#18282B";
    public string PrimaryContainer => "#839497";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#D4DEE0";
    public string OnSecondary => "#1E2729";
    public string SecondaryContainer => "#899294";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#C7E1E6";
    public string OnTertiary => "#10292D";
    public string TertiaryContainer => "#7C959A";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#121414";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#DDDCDC";

    public string SurfaceContainerLowest => "#060808";
    public string SurfaceContainerLow => "#1D1E1E";
    public string SurfaceContainer => "#272828";
    public string SurfaceContainerHigh => "#323333";
    public string SurfaceContainerHighest => "#3D3E3E";
}
