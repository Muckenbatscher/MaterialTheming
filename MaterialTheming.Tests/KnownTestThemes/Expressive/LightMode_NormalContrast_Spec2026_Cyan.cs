namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_NormalContrast_Spec2026_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#006975";
    public string OnPrimary => "#ECFCFF";
    public string PrimaryContainer => "#61E6FB";
    public string OnPrimaryContainer => "#00515B";
    // Secondary
    public string Secondary => "#68597B";
    public string OnSecondary => "#FEF6FF";
    public string SecondaryContainer => "#EDDCFF";
    public string OnSecondaryContainer => "#5A4B6D";
    // Tertiary
    public string Tertiary => "#764C9D";
    public string OnTertiary => "#FFF6FF";
    public string TertiaryContainer => "#D5A5FE";
    public string OnTertiaryContainer => "#4B2171";
    // Error
    public string Error => "#AC3434";
    public string OnError => "#FFF7F6";
    public string ErrorContainer => "#F56965";
    public string OnErrorContainer => "#65000B";
    // Surface
    public string Surface => "#F2FBFF";
    public string SurfaceVariant => "#B4EBFE";
    public string OnSurface => "#003844";
    public string OnSurfaceVariant => "#2F6676";
    public string SurfaceDim => "#A6E3F8";
    public string SurfaceBright => "#F2FBFF";
    public string SurfaceTint => "#006975";
    // Background
    public string Background => "#F2FBFF";
    public string OnBackground => "#003844";
    // Outline
    public string Outline => "#4D8293";
    public string OutlineVariant => "#84BACC";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#001016";
    public string InverseOnSurface => "#86A1AB";
    public string InversePrimary => "#61E6FB";
    // Primary Fixed
    public string PrimaryFixed => "#61E6FB";
    public string OnPrimaryFixed => "#003C44";
    public string PrimaryFixedDim => "#50D8EC";
    public string OnPrimaryFixedVariant => "#005B66";
    // Secondary Fixed
    public string SecondaryFixed => "#EDDCFF";
    public string OnSecondaryFixed => "#473959";
    public string SecondaryFixedDim => "#E0CDF5";
    public string OnSecondaryFixedVariant => "#645577";
    // Tertiary Fixed
    public string TertiaryFixed => "#D5A5FE";
    public string OnTertiaryFixed => "#330259";
    public string TertiaryFixedDim => "#C698F0";
    public string OnTertiaryFixedVariant => "#542B7A";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#E3F7FF";
    public string SurfaceContainer => "#D3F3FF";
    public string SurfaceContainerHigh => "#C3EFFF";
    public string SurfaceContainerHighest => "#B4EBFE";
}
