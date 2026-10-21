namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_MediumContrast_Spec2025_Watch_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public Platform Platform => Platform.Watch;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFFEFF";
    public string OnPrimary => "#00030C";
    public string PrimaryContainer => "#5F87C1";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FEFFFB";
    public string OnSecondary => "#002513";
    public string SecondaryContainer => "#698E75";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFFEFF";
    public string OnTertiary => "#282F00";
    public string TertiaryContainer => "#CEE171";
    public string OnTertiaryContainer => "#3B4600";
    // Error
    public string Error => "#FFBEB9";
    public string OnError => "#3D0004";
    public string ErrorContainer => "#CE6762";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#000000";
    public string SurfaceVariant => "#19263A";
    public string OnSurface => "#FFFEFF";
    public string OnSurfaceVariant => "#C8CEDD";
    public string SurfaceDim => "#080E19";
    public string SurfaceBright => "#1D2D43";
    public string SurfaceTint => "#FFFEFF";
    // Background
    public string Background => "#000000";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#9FA6B4";
    public string OutlineVariant => "#7F8693";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F9F9FF";
    public string InverseOnSurface => "#323844";
    public string InversePrimary => "#00386D";
    // Primary Fixed
    public string PrimaryFixed => "#B4D0FF";
    public string OnPrimaryFixed => "#00030C";
    public string PrimaryFixedDim => "#98C0FE";
    public string OnPrimaryFixedVariant => "#00305F";
    // Secondary Fixed
    public string SecondaryFixed => "#C4ECCF";
    public string OnSecondaryFixed => "#002513";
    public string SecondaryFixedDim => "#B6DEC2";
    public string OnSecondaryFixedVariant => "#234632";
    // Tertiary Fixed
    public string TertiaryFixed => "#EAFE8A";
    public string OnTertiaryFixed => "#282F00";
    public string TertiaryFixedDim => "#DCEF7D";
    public string OnTertiaryFixedVariant => "#414C00";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#1F2631";
    public string SurfaceContainer => "#2A313C";
    public string SurfaceContainerHigh => "#353C47";
    public string SurfaceContainerHighest => "#19263A";
}
