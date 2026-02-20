namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class LightMode_HighContrast_Spec2026_Orange_Red : ITestThemeSecondSourceColor
{
    public string SourceColor => "#D77837"; //Orange
    public string SecondSourceColor => "#D2463D"; //Red
    public bool IsDark => false;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#3F1900";
    public string OnPrimary => "#FFD1B7";
    public string PrimaryContainer => "#863D00";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#3C1B05";
    public string OnSecondary => "#FFD1B7";
    public string SecondaryContainer => "#72482E";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#510003";
    public string OnTertiary => "#FFCFC9";
    public string TertiaryContainer => "#9E201D";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#4F0407";
    public string OnError => "#FFCFCA";
    public string ErrorContainer => "#8E3430";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F5";
    public string SurfaceVariant => "#FFDBC8";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#361E0F";
    public string SurfaceDim => "#FCD1BA";
    public string SurfaceBright => "#FFF8F5";
    public string SurfaceTint => "#3F1900";
    // Background
    public string Background => "#FFF8F5";
    public string OnBackground => "#000000";
    // Outline
    public string Outline => "#583D2C";
    public string OutlineVariant => "#694C3A";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#1C0901";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#FFB486";
    // Primary Fixed
    public string PrimaryFixed => "#863D00";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#743400";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#72482E";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#653D23";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#9E201D";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#8D1213";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1EA";
    public string SurfaceContainer => "#FFEADF";
    public string SurfaceContainerHigh => "#FFE3D4";
    public string SurfaceContainerHighest => "#FFDBC8";
}
