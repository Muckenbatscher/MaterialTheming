namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_NormalContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FFB1C8";
    public string OnPrimary => "#5E1132";
    public string PrimaryContainer => "#7B2949";
    public string OnPrimaryContainer => "#FFD9E2";
    // Secondary
    public string Secondary => "#FFB1C8";
    public string OnSecondary => "#541D32";
    public string SecondaryContainer => "#703348";
    public string OnSecondaryContainer => "#FFD9E2";
    // Tertiary
    public string Tertiary => "#FFB68B";
    public string OnTertiary => "#522300";
    public string TertiaryContainer => "#6F3811";
    public string OnTertiaryContainer => "#FFDBC8";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#1D1009";
    public string SurfaceVariant => "#5C4131";
    public string OnSurface => "#F8DDD0";
    public string OnSurfaceVariant => "#E5BFA9";
    public string SurfaceDim => "#1D1009";
    public string SurfaceBright => "#46362C";
    public string SurfaceTint => "#FFB1C8";
    // Background
    public string Background => "#1D1009";
    public string OnBackground => "#F8DDD0";
    // Outline
    public string Outline => "#AC8A76";
    public string OutlineVariant => "#5C4131";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F8DDD0";
    public string InverseOnSurface => "#3D2D24";
    public string InversePrimary => "#984061";
    // Primary Fixed
    public string PrimaryFixed => "#FFD9E2";
    public string OnPrimaryFixed => "#3E001D";
    public string PrimaryFixedDim => "#FFB1C8";
    public string OnPrimaryFixedVariant => "#7B2949";
    // Secondary Fixed
    public string SecondaryFixed => "#FFD9E2";
    public string OnSecondaryFixed => "#3A071D";
    public string SecondaryFixedDim => "#FFB1C8";
    public string OnSecondaryFixedVariant => "#703348";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFDBC8";
    public string OnTertiaryFixed => "#321300";
    public string TertiaryFixedDim => "#FFB68B";
    public string OnTertiaryFixedVariant => "#6F3811";
    // Surface Container
    public string SurfaceContainerLowest => "#170B05";
    public string SurfaceContainerLow => "#261910";
    public string SurfaceContainer => "#2A1D14";
    public string SurfaceContainerHigh => "#36271E";
    public string SurfaceContainerHighest => "#413128";
}
