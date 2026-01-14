using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_MediumContrast_Spec2021_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#00FD6E";
    public string OnPrimary => "#002D0D";
    public string PrimaryContainer => "#00A746";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#BCE6CD";
    public string OnSecondary => "#022C1C";
    public string SecondaryContainer => "#729984";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#A5EAD8";
    public string OnTertiary => "#002C24";
    public string TertiaryContainer => "#599D8D";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#0D150D";
    public string SurfaceVariant => "#3E4A3D";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#D3E0CF";
    public string SurfaceDim => "#0D150D";
    public string SurfaceBright => "#3E473D";
    public string SurfaceTint => "#00E563";
    // Background
    public string Background => "#0D150D";
    public string OnBackground => "#DBE5D7";
    // Outline
    public string Outline => "#A8B6A5";
    public string OutlineVariant => "#879485";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#DBE5D7";
    public string InverseOnSurface => "#232C23";
    public string InversePrimary => "#00541F";
    // Primary Fixed
    public string PrimaryFixed => "#69FF89";
    public string OnPrimaryFixed => "#001504";
    public string PrimaryFixedDim => "#00E563";
    public string OnPrimaryFixedVariant => "#004016";
    // Secondary Fixed
    public string SecondaryFixed => "#C2ECD3";
    public string OnSecondaryFixed => "#00150B";
    public string SecondaryFixedDim => "#A6D0B8";
    public string OnSecondaryFixedVariant => "#163D2C";
    // Tertiary Fixed
    public string TertiaryFixed => "#ABF0DE";
    public string OnTertiaryFixed => "#001510";
    public string TertiaryFixedDim => "#8FD4C2";
    public string OnTertiaryFixedVariant => "#003E34";
    // Surface Container
    public string SurfaceContainerLowest => "#030903";
    public string SurfaceContainerLow => "#172017";
    public string SurfaceContainer => "#212A21";
    public string SurfaceContainerHigh => "#2C352B";
    public string SurfaceContainerHighest => "#374036";
}
