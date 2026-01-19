namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_MediumContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#4B4A0C";
    public string OnPrimary => "#E8E698";
    public string PrimaryContainer => "#797736";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#4A492E";
    public string OnSecondary => "#E7E4BE";
    public string SecondaryContainer => "#777657";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#5F4311";
    public string OnTertiary => "#FFDDAC";
    public string TertiaryContainer => "#906F39";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#87240C";
    public string OnError => "#FFDAD1";
    public string ErrorContainer => "#C44F34";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFFBFF";
    public string SurfaceVariant => "#ECE9D5";
    public string OnSurface => "#2B2B1E";
    public string OnSurfaceVariant => "#4A483A";
    public string SurfaceDim => "#E6E3D0";
    public string SurfaceBright => "#FFFBFF";
    public string SurfaceTint => "#4B4A0C";
    // Background
    public string Background => "#FFFBFF";
    public string OnBackground => "#2B2B1E";
    // Outline
    public string Outline => "#666556";
    public string OutlineVariant => "#838171";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#0F0E08";
    public string InverseOnSurface => "#C8C5BA";
    public string InversePrimary => "#F7F5A5";
    // Primary Fixed
    public string PrimaryFixed => "#797736";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#6C6B2B";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#777657";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#6B6A4B";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#906F39";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#82632E";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FDF9EB";
    public string SurfaceContainer => "#F8F4E4";
    public string SurfaceContainerHigh => "#F2EEDD";
    public string SurfaceContainerHighest => "#ECE9D5";
}
