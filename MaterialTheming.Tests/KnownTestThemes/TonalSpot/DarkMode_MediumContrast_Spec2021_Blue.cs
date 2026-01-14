using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_MediumContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#CBDDFF";
    public string OnPrimary => "#00264C";
    public string PrimaryContainer => "#7092C6";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#D2DDF2";
    public string OnSecondary => "#1C2636";
    public string SecondaryContainer => "#8791A5";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#F1D2F8";
    public string OnTertiary => "#321E3A";
    public string TertiaryContainer => "#A288AA";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#111318";
    public string SurfaceVariant => "#43474E";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#D9DCE5";
    public string SurfaceDim => "#111318";
    public string SurfaceBright => "#42444A";
    public string SurfaceTint => "#A6C8FF";
    // Background
    public string Background => "#111318";
    public string OnBackground => "#E1E2E9";
    // Outline
    public string Outline => "#AFB2BB";
    public string OutlineVariant => "#8D9099";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E1E2E9";
    public string InverseOnSurface => "#282A2F";
    public string InversePrimary => "#244978";
    // Primary Fixed
    public string PrimaryFixed => "#D5E3FF";
    public string OnPrimaryFixed => "#001128";
    public string PrimaryFixedDim => "#A6C8FF";
    public string OnPrimaryFixedVariant => "#0C3765";
    // Secondary Fixed
    public string SecondaryFixed => "#D9E3F8";
    public string OnSecondaryFixed => "#071120";
    public string SecondaryFixedDim => "#BDC7DC";
    public string OnSecondaryFixedVariant => "#2D3747";
    // Tertiary Fixed
    public string TertiaryFixed => "#F7D8FF";
    public string OnTertiaryFixed => "#1C0924";
    public string TertiaryFixedDim => "#DABDE2";
    public string OnTertiaryFixedVariant => "#442E4C";
    // Surface Container
    public string SurfaceContainerLowest => "#05070C";
    public string SurfaceContainerLow => "#1B1E22";
    public string SurfaceContainer => "#26282D";
    public string SurfaceContainerHigh => "#303338";
    public string SurfaceContainerHighest => "#3B3E43";
}
