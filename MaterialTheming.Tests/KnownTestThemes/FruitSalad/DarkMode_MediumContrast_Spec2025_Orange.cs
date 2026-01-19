namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_MediumContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFD0DC";
    public string OnPrimary => "#4F0328";
    public string PrimaryContainer => "#D57193";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFD0DC";
    public string OnSecondary => "#471227";
    public string SecondaryContainer => "#C67B92";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFD3BB";
    public string OnTertiary => "#411A00";
    public string TertiaryContainer => "#C78053";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#1D1009";
    public string SurfaceVariant => "#5C4131";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FCD4BE";
    public string SurfaceDim => "#1D1009";
    public string SurfaceBright => "#524137";
    public string SurfaceTint => "#FFB1C8";
    // Background
    public string Background => "#1D1009";
    public string OnBackground => "#F8DDD0";
    // Outline
    public string Outline => "#CFAA96";
    public string OutlineVariant => "#AB8976";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F8DDD0";
    public string InverseOnSurface => "#36271E";
    public string InversePrimary => "#7C2A4A";
    // Primary Fixed
    public string PrimaryFixed => "#FFD9E2";
    public string OnPrimaryFixed => "#2B0012";
    public string PrimaryFixedDim => "#FFB1C8";
    public string OnPrimaryFixedVariant => "#651738";
    // Secondary Fixed
    public string SecondaryFixed => "#FFD9E2";
    public string OnSecondaryFixed => "#2B0012";
    public string SecondaryFixedDim => "#FFB1C8";
    public string OnSecondaryFixedVariant => "#5B2238";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFDBC8";
    public string OnTertiaryFixed => "#220A00";
    public string TertiaryFixedDim => "#FFB68B";
    public string OnTertiaryFixedVariant => "#5A2802";
    // Surface Container
    public string SurfaceContainerLowest => "#0F0502";
    public string SurfaceContainerLow => "#281B12";
    public string SurfaceContainer => "#33251C";
    public string SurfaceContainerHigh => "#3F2F26";
    public string SurfaceContainerHighest => "#4B3A31";
}
