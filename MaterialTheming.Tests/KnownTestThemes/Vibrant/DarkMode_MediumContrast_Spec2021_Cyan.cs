namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_MediumContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#7CECFF";
    public string OnPrimary => "#002A30";
    public string PrimaryContainer => "#009FB1";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#BBE2F6";
    public string OnSecondary => "#002937";
    public string SecondaryContainer => "#7196A8";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#C0E0FF";
    public string OnTertiary => "#002840";
    public string TertiaryContainer => "#6A95BA";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#091517";
    public string SurfaceVariant => "#39494D";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#CEDFE3";
    public string SurfaceDim => "#091517";
    public string SurfaceBright => "#3A4749";
    public string SurfaceTint => "#00DAF2";
    // Background
    public string Background => "#091517";
    public string OnBackground => "#D7E5E8";
    // Outline
    public string Outline => "#A4B5B8";
    public string OutlineVariant => "#829397";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#D7E5E8";
    public string InverseOnSurface => "#202C2E";
    public string InversePrimary => "#00505A";
    // Primary Fixed
    public string PrimaryFixed => "#9AF0FF";
    public string OnPrimaryFixed => "#001417";
    public string PrimaryFixedDim => "#00DAF2";
    public string OnPrimaryFixedVariant => "#003C44";
    // Secondary Fixed
    public string SecondaryFixed => "#C2E8FC";
    public string OnSecondaryFixed => "#00131C";
    public string SecondaryFixedDim => "#A6CCDF";
    public string OnSecondaryFixedVariant => "#113B4A";
    // Tertiary Fixed
    public string TertiaryFixed => "#CCE5FF";
    public string OnTertiaryFixed => "#001321";
    public string TertiaryFixedDim => "#A0CBF3";
    public string OnTertiaryFixedVariant => "#00395A";
    // Surface Container
    public string SurfaceContainerLowest => "#01090B";
    public string SurfaceContainerLow => "#131F22";
    public string SurfaceContainer => "#1E2A2C";
    public string SurfaceContainerHigh => "#283537";
    public string SurfaceContainerHighest => "#334042";
}
