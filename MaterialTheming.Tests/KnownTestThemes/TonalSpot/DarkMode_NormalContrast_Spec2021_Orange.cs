namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_NormalContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FFB68B";
    public string OnPrimary => "#522300";
    public string PrimaryContainer => "#6F3811";
    public string OnPrimaryContainer => "#FFDBC8";
    // Secondary
    public string Secondary => "#E5BFA9";
    public string OnSecondary => "#432B1C";
    public string SecondaryContainer => "#5C4131";
    public string OnSecondaryContainer => "#FFDBC8";
    // Tertiary
    public string Tertiary => "#CBC992";
    public string OnTertiary => "#333209";
    public string TertiaryContainer => "#49491E";
    public string OnTertiaryContainer => "#E8E5AC";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#1A120D";
    public string SurfaceVariant => "#52443C";
    public string OnSurface => "#F0DFD7";
    public string OnSurfaceVariant => "#D7C2B8";
    public string SurfaceDim => "#1A120D";
    public string SurfaceBright => "#413732";
    public string SurfaceTint => "#FFB68B";
    // Background
    public string Background => "#1A120D";
    public string OnBackground => "#F0DFD7";
    // Outline
    public string Outline => "#9F8D84";
    public string OutlineVariant => "#52443C";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F0DFD7";
    public string InverseOnSurface => "#382E29";
    public string InversePrimary => "#8C4F26";
    // Primary Fixed
    public string PrimaryFixed => "#FFDBC8";
    public string OnPrimaryFixed => "#321300";
    public string PrimaryFixedDim => "#FFB68B";
    public string OnPrimaryFixedVariant => "#6F3811";
    // Secondary Fixed
    public string SecondaryFixed => "#FFDBC8";
    public string OnSecondaryFixed => "#2B1609";
    public string SecondaryFixedDim => "#E5BFA9";
    public string OnSecondaryFixedVariant => "#5C4131";
    // Tertiary Fixed
    public string TertiaryFixed => "#E8E5AC";
    public string OnTertiaryFixed => "#1D1D00";
    public string TertiaryFixedDim => "#CBC992";
    public string OnTertiaryFixedVariant => "#49491E";
    // Surface Container
    public string SurfaceContainerLowest => "#140D08";
    public string SurfaceContainerLow => "#221A15";
    public string SurfaceContainer => "#261E19";
    public string SurfaceContainerHigh => "#312823";
    public string SurfaceContainerHighest => "#3D332D";
}
