using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_MediumContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    public string Primary => "#CBDDFF";
    public string OnPrimary => "#00264C";
    public string PrimaryContainer => "#7092C6";
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

    public string Surface => "#111318";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#D9DCE5";

    public string SurfaceContainerLowest => "#05070C";
    public string SurfaceContainerLow => "#1B1E22";
    public string SurfaceContainer => "#26282D";
    public string SurfaceContainerHigh => "#303338";
    public string SurfaceContainerHighest => "#3B3E43";
}
