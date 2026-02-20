namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class LightMode_MediumContrast_Spec2026_Magenta_Green : ITestThemeSecondSourceColor
{
    public string SourceColor => "#E85DAE"; //Magenta
    public string SecondSourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#83005B";
    public string OnPrimary => "#FFCCE2";
    public string PrimaryContainer => "#C54091";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#67304E";
    public string OnSecondary => "#FFCCE2";
    public string SecondaryContainer => "#A06181";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#004E1D";
    public string OnTertiary => "#97ED9F";
    public string TertiaryContainer => "#308443";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#880D14";
    public string OnError => "#FFCECA";
    public string ErrorContainer => "#CE4340";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F8";
    public string SurfaceVariant => "#FFD8E8";
    public string OnSurface => "#39192A";
    public string OnSurfaceVariant => "#5C384A";
    public string SurfaceDim => "#FFCCE3";
    public string SurfaceBright => "#FFF8F8";
    public string SurfaceTint => "#83005B";
    // Background
    public string Background => "#FFF8F8";
    public string OnBackground => "#39192A";
    // Outline
    public string Outline => "#7B5367";
    public string OutlineVariant => "#996E83";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#1F0414";
    public string InverseOnSurface => "#DBBDC9";
    public string InversePrimary => "#FC6DBF";
    // Primary Fixed
    public string PrimaryFixed => "#C54091";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#B53383";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#A06181";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#925574";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#308443";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#217737";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0F4";
    public string SurfaceContainer => "#FFE8F0";
    public string SurfaceContainerHigh => "#FFE0EC";
    public string SurfaceContainerHighest => "#FFD8E8";
}
