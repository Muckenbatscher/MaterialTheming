namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_MediumContrast_Spec2026_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#214B28";
    public string OnPrimary => "#B5E6B5";
    public string PrimaryContainer => "#537F56";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#364736";
    public string OnSecondary => "#CBDFC8";
    public string SecondaryContainer => "#677966";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#404616";
    public string OnTertiary => "#D8DF9F";
    public string TertiaryContainer => "#727943";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#801F07";
    public string OnError => "#FFCFC4";
    public string ErrorContainer => "#C44F34";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F8FAF3";
    public string SurfaceVariant => "#DDE5D9";
    public string OnSurface => "#1F261E";
    public string OnSurfaceVariant => "#3D453C";
    public string SurfaceDim => "#D4DCD0";
    public string SurfaceBright => "#F8FAF3";
    public string SurfaceTint => "#214B28";
    // Background
    public string Background => "#F8FAF3";
    public string OnBackground => "#1F261E";
    // Outline
    public string Outline => "#596158";
    public string OutlineVariant => "#757D73";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#0C0F0B";
    public string InverseOnSurface => "#C3C6BF";
    public string InversePrimary => "#C6F8C6";
    // Primary Fixed
    public string PrimaryFixed => "#537F56";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#46724A";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#677966";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#5B6D5A";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#727943";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#666C38";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F1F5EC";
    public string SurfaceContainer => "#EAF0E6";
    public string SurfaceContainerHigh => "#E4EADF";
    public string SurfaceContainerHighest => "#DDE5D9";
}
