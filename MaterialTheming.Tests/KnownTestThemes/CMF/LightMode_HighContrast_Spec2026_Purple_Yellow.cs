namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class LightMode_HighContrast_Spec2026_Purple_Yellow : ITestThemeSecondSourceColor
{
    public string SourceColor => "#945CCD"; //Purple
    public string SecondSourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#370064";
    public string OnPrimary => "#EAD0FF";
    public string PrimaryContainer => "#6D34A5";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#2E1A43";
    public string OnSecondary => "#EAD0FF";
    public string SecondaryContainer => "#5F4974";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#262500";
    public string OnTertiary => "#E2DF62";
    public string TertiaryContainer => "#565500";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#510005";
    public string OnError => "#FFCFCA";
    public string ErrorContainer => "#972B29";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF7FE";
    public string SurfaceVariant => "#EFDBFD";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#2B1F37";
    public string SurfaceDim => "#E6D3F4";
    public string SurfaceBright => "#FFF7FE";
    public string SurfaceTint => "#370064";
    // Background
    public string Background => "#FFF7FE";
    public string OnBackground => "#000000";
    // Outline
    public string Outline => "#4B3D58";
    public string OutlineVariant => "#5B4C68";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#140920";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#DBB6FF";
    // Primary Fixed
    public string PrimaryFixed => "#6D34A5";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#602698";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#5F4974";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#533D68";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#565500";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#4A4900";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FBF0FF";
    public string SurfaceContainer => "#F7E9FF";
    public string SurfaceContainerHigh => "#F4E2FF";
    public string SurfaceContainerHighest => "#EFDBFD";
}
