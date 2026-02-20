namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class LightMode_NormalContrast_Spec2026_Purple_Purple : ITestThemeSecondSourceColor
{
    public string SourceColor => "#945CCD"; //Purple
    public string SecondSourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#7B43B3";
    public string OnPrimary => "#FFF6FF";
    public string PrimaryContainer => "#925ACA";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#6C5682";
    public string OnSecondary => "#FFF6FF";
    public string SecondaryContainer => "#E3C7FB";
    public string OnSecondaryContainer => "#543E69";
    // Tertiary
    public string Tertiary => "#734E99";
    public string OnTertiary => "#FFF6FF";
    public string TertiaryContainer => "#8A64B0";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#A83834";
    public string OnError => "#FFF7F6";
    public string ErrorContainer => "#FE776F";
    public string OnErrorContainer => "#4F0005";
    // Surface
    public string Surface => "#FFF7FE";
    public string SurfaceVariant => "#EFDBFD";
    public string OnSurface => "#3A2D46";
    public string OnSurfaceVariant => "#685975";
    public string SurfaceDim => "#E6D3F4";
    public string SurfaceBright => "#FFF7FE";
    public string SurfaceTint => "#7B43B3";
    // Background
    public string Background => "#FFF7FE";
    public string OnBackground => "#3A2D46";
    // Outline
    public string Outline => "#857592";
    public string OutlineVariant => "#BDABCB";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#140920";
    public string InverseOnSurface => "#A499AA";
    public string InversePrimary => "#C389FE";
    // Primary Fixed
    public string PrimaryFixed => "#925ACA";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#844DBD";
    public string OnPrimaryFixedVariant => "#F4E2FF";
    // Secondary Fixed
    public string SecondaryFixed => "#E3C7FB";
    public string OnSecondaryFixed => "#402B54";
    public string SecondaryFixedDim => "#D4B9EC";
    public string OnSecondaryFixedVariant => "#5D4773";
    // Tertiary Fixed
    public string TertiaryFixed => "#8A64B0";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#7D57A3";
    public string OnTertiaryFixedVariant => "#F4E2FF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FBF0FF";
    public string SurfaceContainer => "#F7E9FF";
    public string SurfaceContainerHigh => "#F4E2FF";
    public string SurfaceContainerHighest => "#EFDBFD";
}
