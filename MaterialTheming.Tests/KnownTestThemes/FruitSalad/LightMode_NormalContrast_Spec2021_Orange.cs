namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_NormalContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#984061";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#FFD9E2";
    public string OnPrimaryContainer => "#7B2949";
    // Secondary
    public string Secondary => "#8C4A60";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#FFD9E2";
    public string OnSecondaryContainer => "#703348";
    // Tertiary
    public string Tertiary => "#8C4F26";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#FFDBC8";
    public string OnTertiaryContainer => "#6F3811";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#FFF8F5";
    public string SurfaceVariant => "#FFDBC8";
    public string OnSurface => "#261910";
    public string OnSurfaceVariant => "#5C4131";
    public string SurfaceDim => "#EFD5C7";
    public string SurfaceBright => "#FFF8F5";
    public string SurfaceTint => "#984061";
    // Background
    public string Background => "#FFF8F5";
    public string OnBackground => "#261910";
    // Outline
    public string Outline => "#90705E";
    public string OutlineVariant => "#E5BFA9";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#3D2D24";
    public string InverseOnSurface => "#FFEDE5";
    public string InversePrimary => "#FFB1C8";
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
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1EA";
    public string SurfaceContainer => "#FFEADF";
    public string SurfaceContainerHigh => "#FEE3D5";
    public string SurfaceContainerHighest => "#F8DDD0";
}
