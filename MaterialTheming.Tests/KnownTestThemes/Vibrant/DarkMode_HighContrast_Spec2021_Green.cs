using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_HighContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#C2FFC4";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#00E060";
    public string OnPrimaryContainer => "#000F02";
    // Secondary
    public string Secondary => "#CFFAE1";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#A2CCB4";
    public string OnSecondaryContainer => "#000E07";
    // Tertiary
    public string Tertiary => "#B8FEEB";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#8BD0BF";
    public string OnTertiaryContainer => "#000E0A";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#0D150D";
    public string SurfaceVariant => "#3E4A3D";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#0D150D";
    public string SurfaceBright => "#495348";
    public string SurfaceTint => "#00E563";
    // Background
    public string Background => "#0D150D";
    public string OnBackground => "#DBE5D7";
    // Outline
    public string Outline => "#E6F4E2";
    public string OutlineVariant => "#B9C6B6";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#DBE5D7";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#00541F";
    // Primary Fixed
    public string PrimaryFixed => "#69FF89";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#00E563";
    public string OnPrimaryFixedVariant => "#001504";
    // Secondary Fixed
    public string SecondaryFixed => "#C2ECD3";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#A6D0B8";
    public string OnSecondaryFixedVariant => "#00150B";
    // Tertiary Fixed
    public string TertiaryFixed => "#ABF0DE";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#8FD4C2";
    public string OnTertiaryFixedVariant => "#001510";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#192219";
    public string SurfaceContainer => "#2A3329";
    public string SurfaceContainerHigh => "#353E34";
    public string SurfaceContainerHighest => "#40493F";
}
