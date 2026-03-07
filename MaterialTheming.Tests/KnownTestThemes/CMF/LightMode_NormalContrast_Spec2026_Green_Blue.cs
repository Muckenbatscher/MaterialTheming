namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class LightMode_NormalContrast_Spec2026_Green_Blue : ITestThemeSecondSourceColor
{
    public string SourceColor => "#338745"; //Green
    public string SecondSourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#136E2F";
    public string OnPrimary => "#E9FFE5";
    public string PrimaryContainer => "#308443";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#476749";
    public string OnSecondary => "#E9FFE5";
    public string SecondaryContainer => "#C8ECC6";
    public string OnSecondaryContainer => "#3A593C";
    // Tertiary
    public string Tertiary => "#00539B";
    public string OnTertiary => "#D6E4FF";
    public string TertiaryContainer => "#185FAA";
    public string OnTertiaryContainer => "#F6F7FF";
    // Error
    public string Error => "#9E422C";
    public string OnError => "#FFF7F6";
    public string ErrorContainer => "#FE8B70";
    public string OnErrorContainer => "#5A1001";
    // Surface
    public string Surface => "#F2FCEE";
    public string SurfaceVariant => "#D3E8CF";
    public string OnSurface => "#253726";
    public string OnSurfaceVariant => "#516450";
    public string SurfaceDim => "#CAE0C7";
    public string SurfaceBright => "#F2FCEE";
    public string SurfaceTint => "#136E2F";
    // Background
    public string Background => "#F2FCEE";
    public string OnBackground => "#253726";
    // Outline
    public string Outline => "#6C806B";
    public string OutlineVariant => "#A2B8A0";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#031205";
    public string InverseOnSurface => "#96A093";
    public string InversePrimary => "#9FF6A7";
    // Primary Fixed
    public string PrimaryFixed => "#308443";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#217737";
    public string OnPrimaryFixedVariant => "#F7FFF2";
    // Secondary Fixed
    public string SecondaryFixed => "#C8ECC6";
    public string OnSecondaryFixed => "#28462B";
    public string SecondaryFixedDim => "#BADEB9";
    public string OnSecondaryFixedVariant => "#446345";
    // Tertiary Fixed
    public string TertiaryFixed => "#185FAA";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#00539B";
    public string OnTertiaryFixedVariant => "#C5DAFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#E9F8E5";
    public string SurfaceContainer => "#E2F3DE";
    public string SurfaceContainerHigh => "#DBEDD7";
    public string SurfaceContainerHighest => "#D3E8CF";
}
