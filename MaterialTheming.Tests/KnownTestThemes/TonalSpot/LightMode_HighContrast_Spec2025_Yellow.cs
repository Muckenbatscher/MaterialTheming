namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_HighContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#2C2C00";
    public string OnPrimary => "#E9E698";
    public string PrimaryContainer => "#5B5A1B";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#2C2B12";
    public string OnSecondary => "#E7E4BF";
    public string SecondaryContainer => "#5A593C";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#3B2600";
    public string OnTertiary => "#FFDDAD";
    public string TertiaryContainer => "#70521F";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#570D00";
    public string OnError => "#FFDAD2";
    public string ErrorContainer => "#9C331A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FEFCF7";
    public string SurfaceVariant => "#ECE9D5";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#2B2B1E";
    public string SurfaceDim => "#E6E3D0";
    public string SurfaceBright => "#FEFCF7";
    public string SurfaceTint => "#2C2C00";
    // Background
    public string Background => "#FEFCF7";
    public string OnBackground => "#000000";
    // Outline
    public string Outline => "#4A483A";
    public string OutlineVariant => "#595849";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#0F0E08";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#F7F5A5";
    // Primary Fixed
    public string PrimaryFixed => "#5B5A1B";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#4F4E10";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#5A593C";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#4E4D31";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#70521F";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#634614";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FDF9EB";
    public string SurfaceContainer => "#F8F4E4";
    public string SurfaceContainerHigh => "#F2EEDD";
    public string SurfaceContainerHighest => "#ECE9D5";
}
