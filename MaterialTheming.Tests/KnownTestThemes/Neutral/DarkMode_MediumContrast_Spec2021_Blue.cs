namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_MediumContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#D6DCEC";
    public string OnPrimary => "#1F2631";
    public string PrimaryContainer => "#8A919F";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#D9DCE5";
    public string OnSecondary => "#22262D";
    public string SecondaryContainer => "#8D9199";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#D2DDF2";
    public string OnTertiary => "#1C2636";
    public string TertiaryContainer => "#8791A5";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#131315";
    public string SurfaceVariant => "#474648";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#DEDCDD";
    public string SurfaceDim => "#131315";
    public string SurfaceBright => "#444446";
    public string SurfaceTint => "#C0C7D5";
    // Background
    public string Background => "#131315";
    public string OnBackground => "#E4E2E3";
    // Outline
    public string Outline => "#B3B1B3";
    public string OutlineVariant => "#919091";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E4E2E3";
    public string InverseOnSurface => "#2A2A2B";
    public string InversePrimary => "#424854";
    // Primary Fixed
    public string PrimaryFixed => "#DCE2F2";
    public string OnPrimaryFixed => "#0B111C";
    public string PrimaryFixedDim => "#C0C7D5";
    public string OnPrimaryFixedVariant => "#303642";
    // Secondary Fixed
    public string SecondaryFixed => "#E0E2EC";
    public string OnSecondaryFixed => "#0E1118";
    public string SecondaryFixedDim => "#C4C6CF";
    public string OnSecondaryFixedVariant => "#33363D";
    // Tertiary Fixed
    public string TertiaryFixed => "#D9E3F8";
    public string OnTertiaryFixed => "#071120";
    public string TertiaryFixedDim => "#BDC7DC";
    public string OnTertiaryFixedVariant => "#2D3747";
    // Surface Container
    public string SurfaceContainerLowest => "#070708";
    public string SurfaceContainerLow => "#1D1D1F";
    public string SurfaceContainer => "#282829";
    public string SurfaceContainerHigh => "#323234";
    public string SurfaceContainerHighest => "#3E3D3F";
}
