using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_MediumContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#332D6D";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#6B65A8";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#233C21";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#597454";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#003F2D";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#3A7861";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F5";
    public string SurfaceVariant => "#F8DEC7";
    public string OnSurface => "#181007";
    public string OnSurfaceVariant => "#433324";
    public string SurfaceDim => "#D5C3B5";
    public string SurfaceBright => "#FFF8F5";
    public string SurfaceTint => "#5C5698";
    // Background
    public string Background => "#FFF8F5";
    public string OnBackground => "#231A11";
    // Outline
    public string Outline => "#614F3E";
    public string OutlineVariant => "#7D6957";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#392E25";
    public string InverseOnSurface => "#FFEEE0";
    public string InversePrimary => "#C6BFFF";
    // Primary Fixed
    public string PrimaryFixed => "#6B65A8";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#524D8E";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#597454";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#415B3D";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#3A7861";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#1E5F4A";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1E7";
    public string SurfaceContainer => "#F8E5D6";
    public string SurfaceContainerHigh => "#ECDACB";
    public string SurfaceContainerHighest => "#E0CEC0";
}
