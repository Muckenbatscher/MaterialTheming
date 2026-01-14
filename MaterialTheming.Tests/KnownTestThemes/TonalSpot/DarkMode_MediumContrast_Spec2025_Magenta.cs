using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_MediumContrast_Spec2025_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#EEB7D0";
    public string OnPrimary => "#502A3E";
    public string PrimaryContainer => "#95677D";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#E0BDCC";
    public string OnSecondary => "#472F3A";
    public string SecondaryContainer => "#896D79";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#F9E0FF";
    public string OnTertiary => "#5B4267";
    public string TertiaryContainer => "#F0CEFD";
    public string OnTertiaryContainer => "#52395E";
    // Error
    public string Error => "#FF9DA8";
    public string OnError => "#5F001C";
    public string ErrorContainer => "#C44B5F";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#120D0F";
    public string SurfaceVariant => "#2E2328";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#C6B4BB";
    public string SurfaceDim => "#120D0F";
    public string SurfaceBright => "#35292E";
    public string SurfaceTint => "#EEB7D0";
    // Background
    public string Background => "#120D0F";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#A08F95";
    public string OutlineVariant => "#817177";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F8";
    public string InverseOnSurface => "#3E3639";
    public string InversePrimary => "#73485D";
    // Primary Fixed
    public string PrimaryFixed => "#F7BFD9";
    public string OnPrimaryFixed => "#19000E";
    public string PrimaryFixedDim => "#E8B2CB";
    public string OnPrimaryFixedVariant => "#4B263A";
    // Secondary Fixed
    public string SecondaryFixed => "#FDD9E8";
    public string OnSecondaryFixed => "#2E1923";
    public string SecondaryFixedDim => "#EECBDA";
    public string OnSecondaryFixedVariant => "#503844";
    // Tertiary Fixed
    public string TertiaryFixed => "#F0CEFD";
    public string OnTertiaryFixed => "#240D30";
    public string TertiaryFixedDim => "#E2C1EE";
    public string OnTertiaryFixedVariant => "#493055";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#191115";
    public string SurfaceContainer => "#20171B";
    public string SurfaceContainerHigh => "#271D21";
    public string SurfaceContainerHighest => "#2E2328";
}
