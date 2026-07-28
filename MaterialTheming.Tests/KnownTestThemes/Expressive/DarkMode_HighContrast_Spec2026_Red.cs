namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_HighContrast_Spec2026_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#FFDEDA";
    public string OnPrimary => "#511915";
    public string PrimaryContainer => "#E28D84";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#D2E9F4";
    public string OnSecondary => "#192F37";
    public string SecondaryContainer => "#91A7B1";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#BAEEFF";
    public string OnTertiary => "#00313C";
    public string TertiaryContainer => "#58D6F7";
    public string OnTertiaryContainer => "#00141A";
    // Error
    public string Error => "#FFDDDF";
    public string OnError => "#5F001C";
    public string ErrorContainer => "#FF798C";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#1B0905";
    public string SurfaceVariant => "#3E1C12";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFDED6";
    public string SurfaceDim => "#1B0905";
    public string SurfaceBright => "#472116";
    public string SurfaceTint => "#FFDEDA";
    // Background
    public string Background => "#1B0905";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#E4AC9C";
    public string OutlineVariant => "#CD9788";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F6";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#602520";
    // Primary Fixed
    public string PrimaryFixed => "#FFACA2";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#F49C93";
    public string OnPrimaryFixedVariant => "#000000";
    // Secondary Fixed
    public string SecondaryFixed => "#DAF2FD";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#CCE3EE";
    public string OnSecondaryFixedVariant => "#152B33";
    // Tertiary Fixed
    public string TertiaryFixed => "#58D6F7";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#46C8E9";
    public string OnTertiaryFixedVariant => "#000000";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#230D07";
    public string SurfaceContainer => "#2C130B";
    public string SurfaceContainerHigh => "#35170F";
    public string SurfaceContainerHighest => "#3E1C12";
}
