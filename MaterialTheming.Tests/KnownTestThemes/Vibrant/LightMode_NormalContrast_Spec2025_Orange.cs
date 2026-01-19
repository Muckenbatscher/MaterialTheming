namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_NormalContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#944500";
    public string OnPrimary => "#FFF0E9";
    public string PrimaryContainer => "#FF7B00";
    public string OnPrimaryContainer => "#3D1800";
    // Secondary
    public string Secondary => "#8A4C00";
    public string OnSecondary => "#FFF0E6";
    public string SecondaryContainer => "#FFC697";
    public string OnSecondaryContainer => "#6D3B00";
    // Tertiary
    public string Tertiary => "#765600";
    public string OnTertiary => "#FFF1DC";
    public string TertiaryContainer => "#FFC32D";
    public string OnTertiaryContainer => "#584000";
    // Error
    public string Error => "#B02500";
    public string OnError => "#FFEFEC";
    public string ErrorContainer => "#F95630";
    public string OnErrorContainer => "#520C00";
    // Surface
    public string Surface => "#FFF4EF";
    public string SurfaceVariant => "#FFD5B4";
    public string OnSurface => "#482603";
    public string OnSurfaceVariant => "#7D522B";
    public string SurfaceDim => "#FFCA9F";
    public string SurfaceBright => "#FFF4EF";
    public string SurfaceTint => "#944500";
    // Background
    public string Background => "#FFF4EF";
    public string OnBackground => "#482603";
    // Outline
    public string Outline => "#9C6D43";
    public string OutlineVariant => "#D9A274";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#1B0A00";
    public string InverseOnSurface => "#C79265";
    public string InversePrimary => "#FF7B00";
    // Primary Fixed
    public string PrimaryFixed => "#FF7B00";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#EB7000";
    public string OnPrimaryFixedVariant => "#4B2000";
    // Secondary Fixed
    public string SecondaryFixed => "#FFC697";
    public string OnSecondaryFixed => "#522A00";
    public string SecondaryFixedDim => "#FFB471";
    public string OnSecondaryFixedVariant => "#7B4200";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFC32D";
    public string OnTertiaryFixed => "#402D00";
    public string TertiaryFixedDim => "#F0B51C";
    public string OnTertiaryFixedVariant => "#634800";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFEEE2";
    public string SurfaceContainer => "#FFE3CF";
    public string SurfaceContainerHigh => "#FFDCC1";
    public string SurfaceContainerHighest => "#FFD5B4";
}
