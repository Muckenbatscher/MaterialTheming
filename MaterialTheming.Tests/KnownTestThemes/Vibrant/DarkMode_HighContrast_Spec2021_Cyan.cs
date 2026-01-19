namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_HighContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#CEF7FF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#00D6EE";
    public string OnPrimaryContainer => "#000E10";
    // Secondary
    public string Secondary => "#DEF3FF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#A2C8DC";
    public string OnSecondaryContainer => "#000D14";
    // Tertiary
    public string Tertiary => "#E6F1FF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#9CC7EF";
    public string OnTertiaryContainer => "#000C18";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#091517";
    public string SurfaceVariant => "#39494D";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#091517";
    public string SurfaceBright => "#465255";
    public string SurfaceTint => "#00DAF2";
    // Background
    public string Background => "#091517";
    public string OnBackground => "#D7E5E8";
    // Outline
    public string Outline => "#E2F3F7";
    public string OutlineVariant => "#B4C6C9";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#D7E5E8";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#00505A";
    // Primary Fixed
    public string PrimaryFixed => "#9AF0FF";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#00DAF2";
    public string OnPrimaryFixedVariant => "#001417";
    // Secondary Fixed
    public string SecondaryFixed => "#C2E8FC";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#A6CCDF";
    public string OnSecondaryFixedVariant => "#00131C";
    // Tertiary Fixed
    public string TertiaryFixed => "#CCE5FF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#A0CBF3";
    public string OnTertiaryFixedVariant => "#001321";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#152224";
    public string SurfaceContainer => "#263235";
    public string SurfaceContainerHigh => "#313D40";
    public string SurfaceContainerHighest => "#3C494B";
}
