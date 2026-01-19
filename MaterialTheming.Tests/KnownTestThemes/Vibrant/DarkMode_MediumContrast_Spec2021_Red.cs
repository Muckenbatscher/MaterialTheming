namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_MediumContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FFD2CD";
    public string OnPrimary => "#540003";
    public string PrimaryContainer => "#FF544A";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFD3C1";
    public string OnSecondary => "#3E1C0C";
    public string SecondaryContainer => "#B9856E";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFD4B3";
    public string OnTertiary => "#3D1E00";
    public string TertiaryContainer => "#BE8452";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#1E100E";
    public string SurfaceVariant => "#58413F";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#F6D5D1";
    public string SurfaceDim => "#1E100E";
    public string SurfaceBright => "#53403E";
    public string SurfaceTint => "#FFB4AB";
    // Background
    public string Background => "#1E100E";
    public string OnBackground => "#F9DCD9";
    // Outline
    public string Outline => "#CAABA7";
    public string OutlineVariant => "#A68A86";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F9DCD9";
    public string InverseOnSurface => "#372624";
    public string InversePrimary => "#95000B";
    // Primary Fixed
    public string PrimaryFixed => "#FFDAD6";
    public string OnPrimaryFixed => "#2D0001";
    public string PrimaryFixedDim => "#FFB4AB";
    public string OnPrimaryFixedVariant => "#740006";
    // Secondary Fixed
    public string SecondaryFixed => "#FFDBCD";
    public string OnSecondaryFixed => "#240800";
    public string SecondaryFixedDim => "#F4B9A0";
    public string OnSecondaryFixedVariant => "#522C1B";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFDCC2";
    public string OnTertiaryFixed => "#1F0C00";
    public string TertiaryFixedDim => "#FAB982";
    public string OnTertiaryFixedVariant => "#542C01";
    // Surface Container
    public string SurfaceContainerLowest => "#100504";
    public string SurfaceContainerLow => "#291A18";
    public string SurfaceContainer => "#342422";
    public string SurfaceContainerHigh => "#402E2C";
    public string SurfaceContainerHighest => "#4C3937";
}
