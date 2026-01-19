namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_MediumContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FFD3BB";
    public string OnPrimary => "#411A00";
    public string PrimaryContainer => "#E76E00";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFD5AD";
    public string OnSecondary => "#3A2002";
    public string SecondaryContainer => "#B28960";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFD695";
    public string OnTertiary => "#342200";
    public string TertiaryContainer => "#B18B48";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#1D1009";
    public string SurfaceVariant => "#574236";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#F5D6C6";
    public string SurfaceDim => "#1D1009";
    public string SurfaceBright => "#524137";
    public string SurfaceTint => "#FFB68B";
    // Background
    public string Background => "#1D1009";
    public string OnBackground => "#F8DDD0";
    // Outline
    public string Outline => "#C9AC9D";
    public string OutlineVariant => "#A58B7D";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F8DDD0";
    public string InverseOnSurface => "#36271E";
    public string InversePrimary => "#763500";
    // Primary Fixed
    public string PrimaryFixed => "#FFDBC8";
    public string OnPrimaryFixed => "#220A00";
    public string PrimaryFixedDim => "#FFB68B";
    public string OnPrimaryFixedVariant => "#5B2700";
    // Secondary Fixed
    public string SecondaryFixed => "#FFDCBD";
    public string OnSecondaryFixed => "#1E0D00";
    public string SecondaryFixedDim => "#ECBE91";
    public string OnSecondaryFixedVariant => "#4D300E";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFDEAA";
    public string OnTertiaryFixed => "#1A0F00";
    public string TertiaryFixedDim => "#EBC078";
    public string OnTertiaryFixedVariant => "#4A3200";
    // Surface Container
    public string SurfaceContainerLowest => "#0F0502";
    public string SurfaceContainerLow => "#281B12";
    public string SurfaceContainer => "#33251C";
    public string SurfaceContainerHigh => "#3F2F26";
    public string SurfaceContainerHighest => "#4B3A31";
}
