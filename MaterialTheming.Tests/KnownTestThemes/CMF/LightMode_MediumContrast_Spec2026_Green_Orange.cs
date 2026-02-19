namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class LightMode_MediumContrast_Spec2026_Green_Orange : ITestThemeSecondSourceColor
{
    public string SourceColor => "#338745"; //Green
    public string SecondSourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#004E1D";
    public string OnPrimary => "#97ED9F";
    public string PrimaryContainer => "#308443";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#2B4A2E";
    public string OnSecondary => "#BFE3BE";
    public string SecondaryContainer => "#5C7C5D";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#6E3100";
    public string OnTertiary => "#FFD0B6";
    public string TertiaryContainer => "#B45D1D";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#7A2522";
    public string OnError => "#FFCECA";
    public string ErrorContainer => "#BB554F";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F2FCEE";
    public string SurfaceVariant => "#D3E8CF";
    public string OnSurface => "#162818";
    public string OnSurfaceVariant => "#354735";
    public string SurfaceDim => "#CAE0C7";
    public string SurfaceBright => "#F2FCEE";
    public string SurfaceTint => "#004E1D";
    // Background
    public string Background => "#F2FCEE";
    public string OnBackground => "#162818";
    // Outline
    public string Outline => "#516450";
    public string OutlineVariant => "#6C806B";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#031205";
    public string InverseOnSurface => "#BDC8BA";
    public string InversePrimary => "#9FF6A7";
    // Primary Fixed
    public string PrimaryFixed => "#308443";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#217737";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#5C7C5D";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#507051";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#B45D1D";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#A45110";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#E9F8E5";
    public string SurfaceContainer => "#E2F3DE";
    public string SurfaceContainerHigh => "#DBEDD7";
    public string SurfaceContainerHighest => "#D3E8CF";
}
