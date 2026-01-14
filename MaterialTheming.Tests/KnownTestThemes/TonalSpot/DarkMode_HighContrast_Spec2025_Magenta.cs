using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_HighContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFDCEA";
    public string OnPrimary => "#442034";
    public string PrimaryContainer => "#C995AD";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#FFDCEA";
    public string OnSecondary => "#3C2530";
    public string SecondaryContainer => "#BB9BA9";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#F9E0FF";
    public string OnTertiary => "#3C2448";
    public string TertiaryContainer => "#F0CEFD";
    public string OnTertiaryContainer => "#311A3D";
    // Error
    public string Error => "#FFDDDF";
    public string OnError => "#5F001C";
    public string ErrorContainer => "#FF798C";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#120D0F";
    public string SurfaceVariant => "#2E2328";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#F4E0E7";
    public string SurfaceDim => "#120D0F";
    public string SurfaceBright => "#35292E";
    public string SurfaceTint => "#FFDCEA";
    // Background
    public string Background => "#120D0F";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#C6B4BB";
    public string OutlineVariant => "#B19FA5";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F8";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#522C40";
    // Primary Fixed
    public string PrimaryFixed => "#F7BFD9";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#E8B2CB";
    public string OnPrimaryFixedVariant => "#19000E";
    // Secondary Fixed
    public string SecondaryFixed => "#FDD9E8";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#EECBDA";
    public string OnSecondaryFixedVariant => "#2E1923";
    // Tertiary Fixed
    public string TertiaryFixed => "#F0CEFD";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#E2C1EE";
    public string OnTertiaryFixedVariant => "#240D30";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#191115";
    public string SurfaceContainer => "#20171B";
    public string SurfaceContainerHigh => "#271D21";
    public string SurfaceContainerHighest => "#2E2328";
}
