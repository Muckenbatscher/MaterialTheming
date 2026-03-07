namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class LightMode_MediumContrast_Spec2026_Orange_Yellow : ITestThemeSecondSourceColor
{
    public string SourceColor => "#D77837"; //Orange
    public string SecondSourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#6E3100";
    public string OnPrimary => "#FFD0B6";
    public string PrimaryContainer => "#B45D1D";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#613920";
    public string OnSecondary => "#FFD0B6";
    public string SecondaryContainer => "#996A4D";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#464500";
    public string OnTertiary => "#E1DF61";
    public string TertiaryContainer => "#7A7800";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#792713";
    public string OnError => "#FFCFC4";
    public string ErrorContainer => "#BA573F";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F5";
    public string SurfaceVariant => "#FFDBC8";
    public string OnSurface => "#361E0F";
    public string OnSurfaceVariant => "#583D2C";
    public string SurfaceDim => "#FCD1BA";
    public string SurfaceBright => "#FFF8F5";
    public string SurfaceTint => "#6E3100";
    // Background
    public string Background => "#FFF8F5";
    public string OnBackground => "#361E0F";
    // Outline
    public string Outline => "#785846";
    public string OutlineVariant => "#967360";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#1C0901";
    public string InverseOnSurface => "#D9C0B3";
    public string InversePrimary => "#FE9753";
    // Primary Fixed
    public string PrimaryFixed => "#B45D1D";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#A45110";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#996A4D";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#8B5E41";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#7A7800";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#6D6B00";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1EA";
    public string SurfaceContainer => "#FFEADF";
    public string SurfaceContainerHigh => "#FFE3D4";
    public string SurfaceContainerHighest => "#FFDBC8";
}
