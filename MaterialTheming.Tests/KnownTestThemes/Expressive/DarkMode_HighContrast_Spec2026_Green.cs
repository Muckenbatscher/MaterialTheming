namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_HighContrast_Spec2026_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#BBF4BC";
    public string OnPrimary => "#003411";
    public string PrimaryContainer => "#7BB07E";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFDFCE";
    public string OnSecondary => "#3E2718";
    public string SecondaryContainer => "#C09C88";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFDFD1";
    public string OnTertiary => "#4F1D00";
    public string TertiaryContainer => "#FFA273";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFDED7";
    public string OnError => "#5A0E00";
    public string ErrorContainer => "#FF7E5E";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#031108";
    public string SurfaceVariant => "#0B2C1A";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#CAEED4";
    public string SurfaceDim => "#031108";
    public string SurfaceBright => "#0D331F";
    public string SurfaceTint => "#BBF4BC";
    // Background
    public string Background => "#031108";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#9EC1A8";
    public string OutlineVariant => "#89AC94";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#EBFEEE";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#0B411A";
    // Primary Fixed
    public string PrimaryFixed => "#B8F1B9";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#AAE2AC";
    public string OnPrimaryFixedVariant => "#00260A";
    // Secondary Fixed
    public string SecondaryFixed => "#FFDBC8";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#F4CCB7";
    public string OnSecondaryFixedVariant => "#301A0D";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFA273";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#F7915B";
    public string OnTertiaryFixedVariant => "#000000";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#04170C";
    public string SurfaceContainer => "#061E11";
    public string SurfaceContainerHigh => "#082516";
    public string SurfaceContainerHighest => "#0B2C1A";
}
