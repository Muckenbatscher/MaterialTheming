namespace MaterialTheming.Tests.KnownTestThemes.Content;

internal class LightMode_MediumContrast_Spec2025_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Content;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#004016";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#277C3C";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#1F3D22";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#557556";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#003861";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#1970B7";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F6FBF2";
    public string SurfaceVariant => "#DBE6D7";
    public string OnSurface => "#0E120D";
    public string OnSurfaceVariant => "#2F392E";
    public string SurfaceDim => "#C3C8BF";
    public string SurfaceBright => "#F6FBF2";
    public string SurfaceTint => "#126D2E";
    // Background
    public string Background => "#F6FBF2";
    public string OnBackground => "#181D18";
    // Outline
    public string Outline => "#4B554A";
    public string OutlineVariant => "#667064";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2D322C";
    public string InverseOnSurface => "#EEF2E9";
    public string InversePrimary => "#84D98E";
    // Primary Fixed
    public string PrimaryFixed => "#277C3C";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#006326";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#557556";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#3D5C3F";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#1970B7";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#005794";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F1F5EC";
    public string SurfaceContainer => "#E5EAE1";
    public string SurfaceContainerHigh => "#DADED5";
    public string SurfaceContainerHighest => "#CED3CA";
}
