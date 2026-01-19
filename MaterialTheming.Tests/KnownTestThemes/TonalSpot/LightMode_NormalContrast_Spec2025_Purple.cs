namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_NormalContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#6D5585";
    public string OnPrimary => "#FFF6FF";
    public string PrimaryContainer => "#E4C6FE";
    public string OnPrimaryContainer => "#543D6C";
    // Secondary
    public string Secondary => "#665B70";
    public string OnSecondary => "#FFF6FF";
    public string SecondaryContainer => "#EDDDF6";
    public string OnSecondaryContainer => "#594D62";
    // Tertiary
    public string Tertiary => "#805168";
    public string OnTertiary => "#FFF7F8";
    public string TertiaryContainer => "#F7BBD7";
    public string OnTertiaryContainer => "#61364C";
    // Error
    public string Error => "#A8364B";
    public string OnError => "#FFF7F7";
    public string ErrorContainer => "#F97386";
    public string OnErrorContainer => "#6E0523";
    // Surface
    public string Surface => "#FFF7FE";
    public string SurfaceVariant => "#E9DFEB";
    public string OnSurface => "#363039";
    public string OnSurfaceVariant => "#635D67";
    public string SurfaceDim => "#E0D7E3";
    public string SurfaceBright => "#FFF7FE";
    public string SurfaceTint => "#6D5585";
    // Background
    public string Background => "#FFF7FE";
    public string OnBackground => "#363039";
    // Outline
    public string Outline => "#7F7883";
    public string OutlineVariant => "#B8AFBA";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#100D11";
    public string InverseOnSurface => "#A19BA1";
    public string InversePrimary => "#E4C6FE";
    // Primary Fixed
    public string PrimaryFixed => "#E4C6FE";
    public string OnPrimaryFixed => "#402A57";
    public string PrimaryFixedDim => "#D6B8F0";
    public string OnPrimaryFixedVariant => "#5E4676";
    // Secondary Fixed
    public string SecondaryFixed => "#EDDDF6";
    public string OnSecondaryFixed => "#463B4F";
    public string SecondaryFixedDim => "#DECFE8";
    public string OnSecondaryFixedVariant => "#63576C";
    // Tertiary Fixed
    public string TertiaryFixed => "#F7BBD7";
    public string OnTertiaryFixed => "#4B2338";
    public string TertiaryFixedDim => "#E8AEC9";
    public string OnTertiaryFixedVariant => "#6C3F56";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F9F1F9";
    public string SurfaceContainer => "#F4EBF5";
    public string SurfaceContainerHigh => "#EEE5F0";
    public string SurfaceContainerHighest => "#E9DFEB";
}
