namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class LightMode_HighContrast_Spec2026_Green_Red : ITestThemeSecondSourceColor
{
    public string SourceColor => "#338745"; //Green
    public string SecondSourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#002B0C";
    public string OnPrimary => "#97EEA0";
    public string PrimaryContainer => "#006025";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#0B2A11";
    public string OnSecondary => "#C0E3BE";
    public string SecondaryContainer => "#3A593D";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#510003";
    public string OnTertiary => "#FFCFC9";
    public string TertiaryContainer => "#9E201D";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#4F030B";
    public string OnError => "#FFCFCC";
    public string ErrorContainer => "#8E3335";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F2FCEE";
    public string SurfaceVariant => "#D3E8CF";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#162818";
    public string SurfaceDim => "#CAE0C7";
    public string SurfaceBright => "#F2FCEE";
    public string SurfaceTint => "#002B0C";
    // Background
    public string Background => "#F2FCEE";
    public string OnBackground => "#000000";
    // Outline
    public string Outline => "#354735";
    public string OutlineVariant => "#445744";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#031205";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#9FF6A7";
    // Primary Fixed
    public string PrimaryFixed => "#006025";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#00521F";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#3A593D";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#2F4D32";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#9E201D";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#8D1213";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#E9F8E5";
    public string SurfaceContainer => "#E2F3DE";
    public string SurfaceContainerHigh => "#DBEDD7";
    public string SurfaceContainerHighest => "#D3E8CF";
}
