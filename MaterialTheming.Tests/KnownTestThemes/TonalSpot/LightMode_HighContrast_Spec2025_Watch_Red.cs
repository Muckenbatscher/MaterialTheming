namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_HighContrast_Spec2025_Watch_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFFFFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#DE9289";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFFFF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#C49C98";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFFFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#E3A0BD";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFBDC3";
    public string OnError => "#000000";
    public string ErrorContainer => "#F38593";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#391F1C";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFEFF";
    public string SurfaceDim => "#180B09";
    public string SurfaceBright => "#402522";
    public string SurfaceTint => "#FFFFFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#E3C8C4";
    public string OutlineVariant => "#B9A09D";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F7";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#000000";
    // Primary Fixed
    public string PrimaryFixed => "#FFBFB8";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#FDACA3";
    public string OnPrimaryFixedVariant => "#1C0000";
    // Secondary Fixed
    public string SecondaryFixed => "#FFD3CD";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#F0C5C0";
    public string OnSecondaryFixedVariant => "#2B1412";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFBCD8";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#F2ADCB";
    public string OnTertiaryFixedVariant => "#1A000D";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#322220";
    public string SurfaceContainer => "#3D2C2A";
    public string SurfaceContainerHigh => "#493735";
    public string SurfaceContainerHighest => "#391F1C";
}
