namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class DarkMode_MediumContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFD3BB";
    public string OnPrimary => "#411A00";
    public string PrimaryContainer => "#D77837";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFD3BB";
    public string OnSecondary => "#3E1D06";
    public string SecondaryContainer => "#B98566";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#DDE468";
    public string OnTertiary => "#252800";
    public string TertiaryContainer => "#919722";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#1A120D";
    public string SurfaceVariant => "#554339";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#F2D7C9";
    public string SurfaceDim => "#1A120D";
    public string SurfaceBright => "#4D423C";
    public string SurfaceTint => "#FFB68B";
    // Background
    public string Background => "#1A120D";
    public string OnBackground => "#F1DFD7";
    // Outline
    public string Outline => "#C6ADA0";
    public string OutlineVariant => "#A28C80";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F1DFD7";
    public string InverseOnSurface => "#322823";
    public string InversePrimary => "#763500";
    // Primary Fixed
    public string PrimaryFixed => "#FFDBC8";
    public string OnPrimaryFixed => "#220A00";
    public string PrimaryFixedDim => "#FFB68B";
    public string OnPrimaryFixedVariant => "#5B2700";
    // Secondary Fixed
    public string SecondaryFixed => "#FFDBC8";
    public string OnSecondaryFixed => "#220A00";
    public string SecondaryFixedDim => "#F4BA98";
    public string OnSecondaryFixedVariant => "#522D15";
    // Tertiary Fixed
    public string TertiaryFixed => "#E3EA6D";
    public string OnTertiaryFixed => "#111200";
    public string TertiaryFixedDim => "#C7CD55";
    public string OnTertiaryFixedVariant => "#363900";
    // Surface Container
    public string SurfaceContainerLowest => "#0D0603";
    public string SurfaceContainerLow => "#251C17";
    public string SurfaceContainer => "#2F2621";
    public string SurfaceContainerHigh => "#3B302B";
    public string SurfaceContainerHighest => "#463B36";
}
