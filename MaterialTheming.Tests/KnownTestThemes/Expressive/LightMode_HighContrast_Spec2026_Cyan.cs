namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_HighContrast_Spec2026_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#00282E";
    public string OnPrimary => "#70EBFF";
    public string PrimaryContainer => "#005B66";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#2B1E3C";
    public string OnSecondary => "#E6D2FB";
    public string SecondaryContainer => "#5A4C6D";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#37075D";
    public string OnTertiary => "#EBD0FF";
    public string TertiaryContainer => "#683E8F";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#510007";
    public string OnError => "#FFCFCB";
    public string ErrorContainer => "#9A2728";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F2FBFF";
    public string SurfaceVariant => "#B4EBFE";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#002832";
    public string SurfaceDim => "#A6E3F8";
    public string SurfaceBright => "#F2FBFF";
    public string SurfaceTint => "#00282E";
    // Background
    public string Background => "#F2FBFF";
    public string OnBackground => "#000000";
    // Outline
    public string Outline => "#064959";
    public string OutlineVariant => "#1F5969";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#001016";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#61E6FB";
    // Primary Fixed
    public string PrimaryFixed => "#005B66";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#004E58";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#5A4C6D";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#4E4061";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#683E8F";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#5C3282";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#E3F7FF";
    public string SurfaceContainer => "#D3F3FF";
    public string SurfaceContainerHigh => "#C3EFFF";
    public string SurfaceContainerHighest => "#B4EBFE";
}
