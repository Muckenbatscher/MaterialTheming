namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_NormalContrast_Spec2026_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#ABD0AA";
    public string OnPrimary => "#27472B";
    public string PrimaryContainer => "#395A3C";
    public string OnPrimaryContainer => "#C7EDC6";
    // Secondary
    public string Secondary => "#B8CCB5";
    public string OnSecondary => "#334434";
    public string SecondaryContainer => "#2F402F";
    public string OnSecondaryContainer => "#B1C5AE";
    // Tertiary
    public string Tertiary => "#F8FFBC";
    public string OnTertiary => "#5C632F";
    public string TertiaryContainer => "#E9F0AF";
    public string OnTertiaryContainer => "#545B28";
    // Error
    public string Error => "#F97758";
    public string OnError => "#450900";
    public string ErrorContainer => "#85230A";
    public string OnErrorContainer => "#FF9B82";
    // Surface
    public string Surface => "#0C0F0B";
    public string SurfaceVariant => "#202820";
    public string OnSurface => "#E0E8DC";
    public string OnSurfaceVariant => "#A5ADA2";
    public string SurfaceDim => "#0C0F0B";
    public string SurfaceBright => "#272E26";
    public string SurfaceTint => "#ABD0AA";
    // Background
    public string Background => "#0C0F0B";
    public string OnBackground => "#E0E8DC";
    // Outline
    public string Outline => "#70786E";
    public string OutlineVariant => "#424A41";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F8FAF3";
    public string InverseOnSurface => "#525651";
    public string InversePrimary => "#466748";
    // Primary Fixed
    public string PrimaryFixed => "#C7ECC5";
    public string OnPrimaryFixed => "#27462A";
    public string PrimaryFixedDim => "#B9DEB8";
    public string OnPrimaryFixedVariant => "#426345";
    // Secondary Fixed
    public string SecondaryFixed => "#D4E8D1";
    public string OnSecondaryFixed => "#334433";
    public string SecondaryFixedDim => "#C6DAC3";
    public string OnSecondaryFixedVariant => "#4E604E";
    // Tertiary Fixed
    public string TertiaryFixed => "#F8FFBC";
    public string OnTertiaryFixed => "#4A511F";
    public string TertiaryFixedDim => "#E9F0AF";
    public string OnTertiaryFixedVariant => "#676E39";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#101510";
    public string SurfaceContainer => "#151B15";
    public string SurfaceContainerHigh => "#1B211B";
    public string SurfaceContainerHighest => "#202820";
}
