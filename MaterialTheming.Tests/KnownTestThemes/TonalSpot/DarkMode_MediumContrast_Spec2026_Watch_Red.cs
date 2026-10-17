namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_MediumContrast_Spec2026_Watch_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFFEFF";
    public string OnPrimary => "#1C0000";
    public string PrimaryContainer => "#B9736B";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFEFF";
    public string OnSecondary => "#2B1412";
    public string SecondaryContainer => "#A27D79";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFEFF";
    public string OnTertiary => "#1A000D";
    public string TertiaryContainer => "#E3A0BD";
    public string OnTertiaryContainer => "#45172F";
    // Error
    public string Error => "#FFBDC3";
    public string OnError => "#3D000F";
    public string ErrorContainer => "#CC6674";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#391F1C";
    public string OnSurface => "#FFFEFF";
    public string OnSurfaceVariant => "#E3C8C4";
    public string SurfaceDim => "#180B09";
    public string SurfaceBright => "#402522";
    public string SurfaceTint => "#FFFEFF";
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
    public string InverseOnSurface => "#463432";
    public string InversePrimary => "#5D2823";
    // Primary Fixed
    public string PrimaryFixed => "#FFBFB8";
    public string OnPrimaryFixed => "#1C0000";
    public string PrimaryFixedDim => "#FDACA3";
    public string OnPrimaryFixedVariant => "#56221E";
    // Secondary Fixed
    public string SecondaryFixed => "#FFD3CD";
    public string OnSecondaryFixed => "#2B1412";
    public string SecondaryFixedDim => "#F0C5C0";
    public string OnSecondaryFixedVariant => "#513431";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFBCD8";
    public string OnTertiaryFixed => "#1A000D";
    public string TertiaryFixedDim => "#F2ADCB";
    public string OnTertiaryFixedVariant => "#51223A";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#322220";
    public string SurfaceContainer => "#3D2C2A";
    public string SurfaceContainerHigh => "#493735";
    public string SurfaceContainerHighest => "#391F1C";
}
