namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_MediumContrast_Spec2026_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#64324D";
    public string OnPrimary => "#FFCCE2";
    public string PrimaryContainer => "#9C6380";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#543C47";
    public string OnSecondary => "#F4D0DF";
    public string SecondaryContainer => "#896D79";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#52395E";
    public string OnTertiary => "#F0CEFC";
    public string TertiaryContainer => "#876A93";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#821830";
    public string OnError => "#FFCDD1";
    public string ErrorContainer => "#C44B5F";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F8";
    public string SurfaceVariant => "#F1DDE4";
    public string OnSurface => "#2C2126";
    public string OnSurfaceVariant => "#4C3F45";
    public string SurfaceDim => "#E9D5DC";
    public string SurfaceBright => "#FFF8F8";
    public string SurfaceTint => "#64324D";
    // Background
    public string Background => "#FFF8F8";
    public string OnBackground => "#2C2126";
    // Outline
    public string Outline => "#6A5B61";
    public string OutlineVariant => "#86777D";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#120D0F";
    public string InverseOnSurface => "#CEC2C5";
    public string InversePrimary => "#FDB8D9";
    // Primary Fixed
    public string PrimaryFixed => "#9C6380";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#8F5773";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#896D79";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#7C606D";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#876A93";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#7A5E86";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0F4";
    public string SurfaceContainer => "#FBEAEF";
    public string SurfaceContainerHigh => "#F6E4E9";
    public string SurfaceContainerHighest => "#F1DDE4";
}
