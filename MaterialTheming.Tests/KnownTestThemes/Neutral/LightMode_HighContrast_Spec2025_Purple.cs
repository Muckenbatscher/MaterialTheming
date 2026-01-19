namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_HighContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#27222A";
    public string OnPrimary => "#E0D7E2";
    public string PrimaryContainer => "#565059";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#262327";
    public string OnSecondary => "#DED8DD";
    public string SecondaryContainer => "#545155";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#252039";
    public string OnTertiary => "#DED5F7";
    public string TertiaryContainer => "#544E6A";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#4F0116";
    public string OnError => "#FFCED2";
    public string ErrorContainer => "#8E3242";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FDF8F9";
    public string SurfaceVariant => "#E7E1E4";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#252326";
    public string SurfaceDim => "#DED8DC";
    public string SurfaceBright => "#FDF8F9";
    public string SurfaceTint => "#27222A";
    // Background
    public string Background => "#FDF8F9";
    public string OnBackground => "#000000";
    // Outline
    public string Outline => "#454245";
    public string OutlineVariant => "#545154";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#0F0E0F";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#FDF3FF";
    // Primary Fixed
    public string PrimaryFixed => "#565059";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#4A444D";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#545155";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#494549";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#544E6A";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#48435E";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F7F2F4";
    public string SurfaceContainer => "#F2ECEF";
    public string SurfaceContainerHigh => "#ECE7E9";
    public string SurfaceContainerHighest => "#E7E1E4";
}
