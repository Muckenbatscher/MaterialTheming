namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_MediumContrast_Spec2026_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#3F2578";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#775EB4";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#3C2C63";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#75649E";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#592341";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#99597A";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F8";
    public string SurfaceVariant => "#FDD9E8";
    public string OnSurface => "#190E13";
    public string OnSurfaceVariant => "#472F3A";
    public string SurfaceDim => "#D7C1C9";
    public string SurfaceBright => "#FFF8F8";
    public string SurfaceTint => "#684FA4";
    // Background
    public string Background => "#FFF8F8";
    public string OnBackground => "#24181E";
    // Outline
    public string Outline => "#654B57";
    public string OutlineVariant => "#816572";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#3B2C33";
    public string InverseOnSurface => "#FFECF2";
    public string InversePrimary => "#D0BCFF";
    // Primary Fixed
    public string PrimaryFixed => "#775EB4";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#5E4599";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#75649E";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#5C4B84";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#99597A";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#7D4161";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0F4";
    public string SurfaceContainer => "#FAE2EB";
    public string SurfaceContainerHigh => "#EED7DF";
    public string SurfaceContainerHighest => "#E2CCD4";
}
