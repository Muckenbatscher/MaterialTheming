namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_MediumContrast_Spec2026_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#6E3100";
    public string OnPrimary => "#FFD0B6";
    public string PrimaryContainer => "#B25E22";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#2C455E";
    public string OnSecondary => "#C2DCFB";
    public string SecondaryContainer => "#5E7792";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#00476C";
    public string OnTertiary => "#BADEFF";
    public string TertiaryContainer => "#0E7BB6";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#821B02";
    public string OnError => "#FFCFC4";
    public string ErrorContainer => "#C74C2F";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F5";
    public string SurfaceVariant => "#FFDCC1";
    public string OnSurface => "#3A1C00";
    public string OnSurfaceVariant => "#613A13";
    public string SurfaceDim => "#FFD1AD";
    public string SurfaceBright => "#FFF8F5";
    public string SurfaceTint => "#6E3100";
    // Background
    public string Background => "#FFF8F5";
    public string OnBackground => "#3A1C00";
    // Outline
    public string Outline => "#82552C";
    public string OutlineVariant => "#A17045";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#1B0A00";
    public string InverseOnSurface => "#E4BD9F";
    public string InversePrimary => "#F89555";
    // Primary Fixed
    public string PrimaryFixed => "#B25E22";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#A25216";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#5E7792";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#526A85";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#0E7BB6";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#006EA5";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1E8";
    public string SurfaceContainer => "#FFEADC";
    public string SurfaceContainerHigh => "#FFE3CF";
    public string SurfaceContainerHighest => "#FFDCC1";
}
