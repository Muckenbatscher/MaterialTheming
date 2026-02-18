namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_HighContrast_Spec2026_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#002B0C";
    public string OnPrimary => "#9BEDA2";
    public string PrimaryContainer => "#055F26";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#3B1C06";
    public string OnSecondary => "#FFD1B7";
    public string SecondaryContainer => "#71492F";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#421700";
    public string OnTertiary => "#FFD0BB";
    public string TertiaryContainer => "#883B0B";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#4C0A00";
    public string OnError => "#FFCFC4";
    public string ErrorContainer => "#982B10";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#E9FFED";
    public string SurfaceVariant => "#BCEECB";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#002A17";
    public string SurfaceDim => "#AEE7C1";
    public string SurfaceBright => "#E9FFED";
    public string SurfaceTint => "#002B0C";
    // Background
    public string Background => "#E9FFED";
    public string OnBackground => "#000000";
    // Outline
    public string Outline => "#1D4B32";
    public string OutlineVariant => "#2D5B41";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#001207";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#9EF0A5";
    // Primary Fixed
    public string PrimaryFixed => "#055F26";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#00521F";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#71492F";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#643D25";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#883B0B";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#793000";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#DAFCE3";
    public string SurfaceContainer => "#D0F7DB";
    public string SurfaceContainerHigh => "#C6F3D3";
    public string SurfaceContainerHighest => "#BCEECB";
}
