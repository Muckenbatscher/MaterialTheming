namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_HighContrast_Spec2025_Watch_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFFFFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#80A7E4";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFFFFF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#88AF94";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFFFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#CEE171";
    public string OnTertiaryContainer => "#1E2400";
    // Error
    public string Error => "#FFBEB9";
    public string OnError => "#000000";
    public string ErrorContainer => "#F58680";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#19263A";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFEFF";
    public string SurfaceDim => "#080E19";
    public string SurfaceBright => "#1D2D43";
    public string SurfaceTint => "#FFFFFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#C8CEDD";
    public string OutlineVariant => "#9FA6B4";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F9F9FF";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#000000";
    // Primary Fixed
    public string PrimaryFixed => "#B4D0FF";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#98C0FE";
    public string OnPrimaryFixedVariant => "#00030C";
    // Secondary Fixed
    public string SecondaryFixed => "#C4ECCF";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#B6DEC2";
    public string OnSecondaryFixedVariant => "#002513";
    // Tertiary Fixed
    public string TertiaryFixed => "#EAFE8A";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#DCEF7D";
    public string OnTertiaryFixedVariant => "#282F00";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1F2631";
    public string SurfaceContainer => "#2A313C";
    public string SurfaceContainerHigh => "#353C47";
    public string SurfaceContainerHighest => "#19263A";
}
