namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_MediumContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#003C44";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#007886";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#113B4A";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#4D7283";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#00395A";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#467194";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#EEFCFF";
    public string SurfaceVariant => "#D4E6E9";
    public string OnSurface => "#071315";
    public string OnSurfaceVariant => "#29393C";
    public string SurfaceDim => "#BBC9CC";
    public string SurfaceBright => "#EEFCFF";
    public string SurfaceTint => "#006875";
    // Background
    public string Background => "#EEFCFF";
    public string OnBackground => "#111D20";
    // Outline
    public string Outline => "#455558";
    public string OutlineVariant => "#5F7073";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#263235";
    public string InverseOnSurface => "#E6F3F6";
    public string InversePrimary => "#00DAF2";
    // Primary Fixed
    public string PrimaryFixed => "#007886";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#005E69";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#4D7283";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#345A6A";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#467194";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#2B597B";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#E9F6F9";
    public string SurfaceContainer => "#DDEBED";
    public string SurfaceContainerHigh => "#D2DFE2";
    public string SurfaceContainerHighest => "#C7D4D7";
}
