using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Rainbow;

internal class DarkMode_MediumContrast_Spec2021 : ITestTheme
{
    public string SourceColor => "#185FAA"; //blue
    public bool IsDark => true;
    public Variant Variant => Variant.Rainbow;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#CBDDFF";
    public string OnPrimary => "#00264C";
    public string PrimaryContainer => "#5D92DD";
    public string OnPrimaryContainer => "#000000";

    public string Secondary => "#D2DDF2";
    public string OnSecondary => "#1C2636";
    public string SecondaryContainer => "#8791A5";
    public string OnSecondaryContainer => "#000000";

    public string Tertiary => "#F1D2F8";
    public string OnTertiary => "#321E3A";
    public string TertiaryContainer => "#A288AA";
    public string OnTertiaryContainer => "#000000";

    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";

    public string Surface => "#131313";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#DCDCDC";

    public string SurfaceContainerLowest => "#070707";
    public string SurfaceContainerLow => "#1D1D1D";
    public string SurfaceContainer => "#282828";
    public string SurfaceContainerHigh => "#323232";
    public string SurfaceContainerHighest => "#3E3E3E";
}
