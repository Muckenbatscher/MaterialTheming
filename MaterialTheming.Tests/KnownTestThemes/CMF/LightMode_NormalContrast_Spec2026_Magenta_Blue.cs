namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class LightMode_NormalContrast_Spec2026_Magenta_Blue : ITestThemeSecondSourceColor
{
    public string SourceColor => "#E85DAE"; //Magenta
    public string SecondSourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#AA287A";
    public string OnPrimary => "#FFF7F8";
    public string PrimaryContainer => "#EB60B1";
    public string OnPrimaryContainer => "#2E001D";
    // Secondary
    public string Secondary => "#874C6B";
    public string OnSecondary => "#FFF7F8";
    public string SecondaryContainer => "#FBB1D5";
    public string OnSecondaryContainer => "#642E4B";
    // Tertiary
    public string Tertiary => "#00539B";
    public string OnTertiary => "#D6E4FF";
    public string TertiaryContainer => "#185FAA";
    public string OnTertiaryContainer => "#F6F7FF";
    // Error
    public string Error => "#B12B3E";
    public string OnError => "#FFF7F6";
    public string ErrorContainer => "#FB6270";
    public string OnErrorContainer => "#380009";
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
    public string PrimaryFixed => "#EB60B1";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#DB53A3";
    public string OnPrimaryFixedVariant => "#43002C";
    // Secondary Fixed
    public string SecondaryFixed => "#FBB1D5";
    public string OnSecondaryFixed => "#4C1A37";
    public string SecondaryFixedDim => "#ECA3C7";
    public string OnSecondaryFixedVariant => "#6E3755";
    // Tertiary Fixed
    public string TertiaryFixed => "#185FAA";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#00539B";
    public string OnTertiaryFixedVariant => "#C5DAFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0F4";
    public string SurfaceContainer => "#FFE8F0";
    public string SurfaceContainerHigh => "#FFE0EC";
    public string SurfaceContainerHighest => "#FFD8E8";
}
