namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_MediumContrast_Spec2026_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#ABD0AA";
    public string OnPrimary => "#1D3D22";
    public string PrimaryContainer => "#5B7D5C";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#B8CCB5";
    public string OnSecondary => "#2A3A2A";
    public string SecondaryContainer => "#677966";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#F8FFBC";
    public string OnTertiary => "#525927";
    public string TertiaryContainer => "#E9F0AF";
    public string OnTertiaryContainer => "#4A511F";
    // Error
    public string Error => "#FFA089";
    public string OnError => "#5A0E00";
    public string ErrorContainer => "#C44F34";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#0C0F0B";
    public string SurfaceVariant => "#202820";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#B3BBB0";
    public string SurfaceDim => "#0C0F0B";
    public string SurfaceBright => "#272E26";
    public string SurfaceTint => "#ABD0AA";
    // Background
    public string Background => "#0C0F0B";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#8E968B";
    public string OutlineVariant => "#70786E";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F8FAF3";
    public string InverseOnSurface => "#363934";
    public string InversePrimary => "#3C5D3E";
    // Primary Fixed
    public string PrimaryFixed => "#C7ECC5";
    public string OnPrimaryFixed => "#05250D";
    public string PrimaryFixedDim => "#B9DEB8";
    public string OnPrimaryFixedVariant => "#27462A";
    // Secondary Fixed
    public string SecondaryFixed => "#D4E8D1";
    public string OnSecondaryFixed => "#132314";
    public string SecondaryFixedDim => "#C6DAC3";
    public string OnSecondaryFixedVariant => "#334433";
    // Tertiary Fixed
    public string TertiaryFixed => "#F8FFBC";
    public string OnTertiaryFixed => "#2D3304";
    public string TertiaryFixedDim => "#E9F0AF";
    public string OnTertiaryFixedVariant => "#4A511F";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#101510";
    public string SurfaceContainer => "#151B15";
    public string SurfaceContainerHigh => "#1B211B";
    public string SurfaceContainerHighest => "#202820";
}
