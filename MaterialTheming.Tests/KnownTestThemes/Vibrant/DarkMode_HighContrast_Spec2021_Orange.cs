namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_HighContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FFECE3";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#FFB181";
    public string OnPrimaryContainer => "#190600";
    // Secondary
    public string Secondary => "#FFEDDE";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#E8BA8D";
    public string OnSecondaryContainer => "#150800";
    // Tertiary
    public string Tertiary => "#FFEED6";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#E7BC74";
    public string OnTertiaryContainer => "#120A00";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#1D1009";
    public string SurfaceVariant => "#574236";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#1D1009";
    public string SurfaceBright => "#5E4C42";
    public string SurfaceTint => "#FFB68B";
    // Background
    public string Background => "#1D1009";
    public string OnBackground => "#F8DDD0";
    // Outline
    public string Outline => "#FFECE3";
    public string OutlineVariant => "#DABDAD";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F8DDD0";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#763500";
    // Primary Fixed
    public string PrimaryFixed => "#FFDBC8";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#FFB68B";
    public string OnPrimaryFixedVariant => "#220A00";
    // Secondary Fixed
    public string SecondaryFixed => "#FFDCBD";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#ECBE91";
    public string OnSecondaryFixedVariant => "#1E0D00";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFDEAA";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#EBC078";
    public string OnTertiaryFixedVariant => "#1A0F00";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#2A1D14";
    public string SurfaceContainer => "#3D2D24";
    public string SurfaceContainerHigh => "#48382E";
    public string SurfaceContainerHighest => "#554339";
}
