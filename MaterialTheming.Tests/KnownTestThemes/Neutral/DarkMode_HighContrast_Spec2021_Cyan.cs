namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_HighContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#E2F3F7";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#B4C6C9";
    public string OnPrimaryContainer => "#010D10";
    // Secondary
    public string Secondary => "#E8F2F4";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#BBC4C6";
    public string OnSecondaryContainer => "#050D0E";
    // Tertiary
    public string Tertiary => "#DAF5FA";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#ADC7CC";
    public string OnTertiaryContainer => "#000E10";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#121414";
    public string SurfaceVariant => "#464747";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#121414";
    public string SurfaceBright => "#4F5050";
    public string SurfaceTint => "#B8CACD";
    // Background
    public string Background => "#121414";
    public string OnBackground => "#E3E2E2";
    // Outline
    public string Outline => "#F1F0EF";
    public string OutlineVariant => "#C3C2C2";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E3E2E2";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#3B4B4E";
    // Primary Fixed
    public string PrimaryFixed => "#D4E6E9";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#B8CACD";
    public string OnPrimaryFixedVariant => "#041316";
    // Secondary Fixed
    public string SecondaryFixed => "#DBE4E6";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#BFC8CA";
    public string OnSecondaryFixedVariant => "#0A1314";
    // Tertiary Fixed
    public string TertiaryFixed => "#CDE7EC";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#B1CBD0";
    public string OnTertiaryFixedVariant => "#001417";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1F2020";
    public string SurfaceContainer => "#2F3031";
    public string SurfaceContainerHigh => "#3B3B3C";
    public string SurfaceContainerHighest => "#464747";
}
