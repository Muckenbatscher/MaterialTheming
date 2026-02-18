namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_MediumContrast_Spec2026_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#46414A";
    public string OnPrimary => "#E0D7E2";
    public string PrimaryContainer => "#79727C";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#454246";
    public string OnSecondary => "#DED8DD";
    public string SecondaryContainer => "#777377";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#453F5A";
    public string OnTertiary => "#DED5F6";
    public string TertiaryContainer => "#77718E";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#7A2333";
    public string OnError => "#FFCDD1";
    public string ErrorContainer => "#B95463";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FDF8F9";
    public string SurfaceVariant => "#E7E1E4";
    public string OnSurface => "#252326";
    public string OnSurfaceVariant => "#454245";
    public string SurfaceDim => "#DED8DC";
    public string SurfaceBright => "#FDF8F9";
    public string SurfaceTint => "#46414A";
    // Background
    public string Background => "#FDF8F9";
    public string OnBackground => "#252326";
    // Outline
    public string Outline => "#615E61";
    public string OutlineVariant => "#7D797D";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#0F0E0F";
    public string InverseOnSurface => "#C8C4C5";
    public string InversePrimary => "#FDF3FF";
    // Primary Fixed
    public string PrimaryFixed => "#79727C";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#6C666F";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#777377";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#6B676B";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#77718E";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#6A6481";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F7F2F4";
    public string SurfaceContainer => "#F2ECEF";
    public string SurfaceContainerHigh => "#ECE7E9";
    public string SurfaceContainerHighest => "#E7E1E4";
}
