using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_MediumContrast_Spec2021 : ITestTheme
{
    public string SourceColor => "#185FAA"; //blue
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#D6DCEC";
    public string OnPrimary => "#1F2631";
    public string PrimaryContainer => "#8A919F";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#D9DCE5";
    public string OnSecondary => "#22262D";
    public string SecondaryContainer => "#8D9199";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#D2DDF2";
    public string OnTertiary => "#1C2636";
    public string TertiaryContainer => "#8791A5";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#131315";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#DEDCDD";

    public string SurfaceContainerLowest => "#070708";
    public string SurfaceContainerLow => "#1D1D1F";
    public string SurfaceContainer => "#282829";
    public string SurfaceContainerHigh => "#323234";
    public string SurfaceContainerHighest => "#3E3D3F";
}
