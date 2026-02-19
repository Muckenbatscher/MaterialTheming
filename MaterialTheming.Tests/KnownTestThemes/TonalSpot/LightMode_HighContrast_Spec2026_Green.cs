namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_HighContrast_Spec2026_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#002B0C";
    public string OnPrimary => "#B6E6B6";
    public string PrimaryContainer => "#305B36";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#172819";
    public string OnSecondary => "#CCE0C8";
    public string SecondaryContainer => "#455745";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#222600";
    public string OnTertiary => "#D8DF9F";
    public string TertiaryContainer => "#4F5624";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#4C0A00";
    public string OnError => "#FFCFC4";
    public string ErrorContainer => "#952E15";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F8FAF3";
    public string SurfaceVariant => "#DDE5D9";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#1F261E";
    public string SurfaceDim => "#D4DCD0";
    public string SurfaceBright => "#F8FAF3";
    public string SurfaceTint => "#002B0C";
    // Background
    public string Background => "#F8FAF3";
    public string OnBackground => "#000000";
    // Outline
    public string Outline => "#3D453C";
    public string OutlineVariant => "#4C544B";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#0C0F0B";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#C6F8C6";
    // Primary Fixed
    public string PrimaryFixed => "#305B36";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#254F2B";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#455745";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#3A4B3A";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#4F5624";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#444A19";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F1F5EC";
    public string SurfaceContainer => "#EAF0E6";
    public string SurfaceContainerHigh => "#E4EADF";
    public string SurfaceContainerHighest => "#DDE5D9";
}
