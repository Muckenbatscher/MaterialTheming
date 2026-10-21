namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_NormalContrast_Spec2025_Watch_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFBFB8";
    public string OnPrimary => "#56221E";
    public string PrimaryContainer => "#6F3630";
    public string OnPrimaryContainer => "#FFD7D2";
    // Secondary
    public string Secondary => "#FFD3CD";
    public string OnSecondary => "#513431";
    public string SecondaryContainer => "#5D3F3C";
    public string OnSecondaryContainer => "#FFD7D2";
    // Tertiary
    public string Tertiary => "#FFBCD8";
    public string OnTertiary => "#51223A";
    public string TertiaryContainer => "#E3A0BD";
    public string OnTertiaryContainer => "#45172F";
    // Error
    public string Error => "#FFBDC3";
    public string OnError => "#3F000F";
    public string ErrorContainer => "#7D2938";
    public string OnErrorContainer => "#FFD6D9";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#391F1C";
    public string OnSurface => "#FEE2DE";
    public string OnSurfaceVariant => "#E3C8C4";
    public string SurfaceDim => "#180B09";
    public string SurfaceBright => "#402522";
    public string SurfaceTint => "#FFBFB8";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#B9A09D";
    public string OutlineVariant => "#98807D";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F7";
    public string InverseOnSurface => "#65504E";
    public string InversePrimary => "#80443E";
    // Primary Fixed
    public string PrimaryFixed => "#FFBFB8";
    public string OnPrimaryFixed => "#56221E";
    public string PrimaryFixedDim => "#FDACA3";
    public string OnPrimaryFixedVariant => "#6F3630";
    // Secondary Fixed
    public string SecondaryFixed => "#FFD3CD";
    public string OnSecondaryFixed => "#513431";
    public string SecondaryFixedDim => "#F0C5C0";
    public string OnSecondaryFixedVariant => "#5D3F3C";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFBCD8";
    public string OnTertiaryFixed => "#51223A";
    public string TertiaryFixedDim => "#F2ADCB";
    public string OnTertiaryFixedVariant => "#6A364F";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#322220";
    public string SurfaceContainer => "#3D2C2A";
    public string SurfaceContainerHigh => "#493735";
    public string SurfaceContainerHighest => "#391F1C";
}
