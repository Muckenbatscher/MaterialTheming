namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_HighContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FFECE3";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#FFB181";
    public string OnPrimaryContainer => "#190600";
    // Secondary
    public string Secondary => "#FFECE3";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#E1BBA6";
    public string OnSecondaryContainer => "#180701";
    // Tertiary
    public string Tertiary => "#F6F3B8";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#C8C58E";
    public string OnTertiaryContainer => "#0C0C00";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#1A120D";
    public string SurfaceVariant => "#52443C";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#1A120D";
    public string SurfaceBright => "#594E48";
    public string SurfaceTint => "#FFB68B";
    // Background
    public string Background => "#1A120D";
    public string OnBackground => "#F0DFD7";
    // Outline
    public string Outline => "#FFECE3";
    public string OutlineVariant => "#D3BFB4";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F0DFD7";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#703912";
    // Primary Fixed
    public string PrimaryFixed => "#FFDBC8";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#FFB68B";
    public string OnPrimaryFixedVariant => "#220A00";
    // Secondary Fixed
    public string SecondaryFixed => "#FFDBC8";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#E5BFA9";
    public string OnSecondaryFixedVariant => "#1F0C03";
    // Tertiary Fixed
    public string TertiaryFixed => "#E8E5AC";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#CBC992";
    public string OnTertiaryFixedVariant => "#121200";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#261E19";
    public string SurfaceContainer => "#382E29";
    public string SurfaceContainerHigh => "#443934";
    public string SurfaceContainerHighest => "#4F453F";
}
