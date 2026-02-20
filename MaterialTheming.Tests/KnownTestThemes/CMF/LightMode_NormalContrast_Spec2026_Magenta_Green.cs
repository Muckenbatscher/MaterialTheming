namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class LightMode_NormalContrast_Spec2026_Magenta_Green : ITestThemeSecondSourceColor
{
    public string SourceColor => "#E85DAE"; //Magenta
    public string SecondSourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#AA287A";
    public string OnPrimary => "#FFF7F8";
    public string PrimaryContainer => "#F86ABC";
    public string OnPrimaryContainer => "#45002E";
    // Secondary
    public string Secondary => "#874C6B";
    public string OnSecondary => "#FFF7F8";
    public string SecondaryContainer => "#FBB1D5";
    public string OnSecondaryContainer => "#642E4B";
    // Tertiary
    public string Tertiary => "#136E2F";
    public string OnTertiary => "#E9FFE5";
    public string TertiaryContainer => "#308443";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#B12E2D";
    public string OnError => "#FFF7F6";
    public string ErrorContainer => "#FF7169";
    public string OnErrorContainer => "#490004";
    // Surface
    public string Surface => "#FFF8F8";
    public string SurfaceVariant => "#FFD8E8";
    public string OnSurface => "#4A2839";
    public string OnSurfaceVariant => "#7B5367";
    public string SurfaceDim => "#FFCCE3";
    public string SurfaceBright => "#FFF8F8";
    public string SurfaceTint => "#AA287A";
    // Background
    public string Background => "#FFF8F8";
    public string OnBackground => "#4A2839";
    // Outline
    public string Outline => "#996E83";
    public string OutlineVariant => "#D5A4BA";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#1F0414";
    public string InverseOnSurface => "#B196A1";
    public string InversePrimary => "#FC6DBF";
    // Primary Fixed
    public string PrimaryFixed => "#F86ABC";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#E85DAE";
    public string OnPrimaryFixedVariant => "#56003A";
    // Secondary Fixed
    public string SecondaryFixed => "#FBB1D5";
    public string OnSecondaryFixed => "#4C1A37";
    public string SecondaryFixedDim => "#ECA3C7";
    public string OnSecondaryFixedVariant => "#6E3755";
    // Tertiary Fixed
    public string TertiaryFixed => "#308443";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#217737";
    public string OnTertiaryFixedVariant => "#A5FCAD";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0F4";
    public string SurfaceContainer => "#FFE8F0";
    public string SurfaceContainerHigh => "#FFE0EC";
    public string SurfaceContainerHighest => "#FFD8E8";
}
