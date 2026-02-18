namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_MediumContrast_Spec2026_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#004E1D";
    public string OnPrimary => "#9BECA2";
    public string PrimaryContainer => "#358445";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#603A22";
    public string OnSecondary => "#FFD0B6";
    public string SecondaryContainer => "#986A4F";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#732D00";
    public string OnTertiary => "#FFD0BA";
    public string TertiaryContainer => "#B45C2B";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#821B02";
    public string OnError => "#FFCFC4";
    public string ErrorContainer => "#C74C2F";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#E9FFED";
    public string SurfaceVariant => "#BCEECB";
    public string OnSurface => "#002A17";
    public string OnSurfaceVariant => "#1D4B32";
    public string SurfaceDim => "#AEE7C1";
    public string SurfaceBright => "#E9FFED";
    public string SurfaceTint => "#004E1D";
    // Background
    public string Background => "#E9FFED";
    public string OnBackground => "#002A17";
    // Outline
    public string Outline => "#3A684D";
    public string OutlineVariant => "#568567";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#001207";
    public string InverseOnSurface => "#B0CBB7";
    public string InversePrimary => "#9EF0A5";
    // Primary Fixed
    public string PrimaryFixed => "#358445";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#27773A";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#986A4F";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#8A5E43";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#B45C2B";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#A55020";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#DAFCE3";
    public string SurfaceContainer => "#D0F7DB";
    public string SurfaceContainerHigh => "#C6F3D3";
    public string SurfaceContainerHighest => "#BCEECB";
}
