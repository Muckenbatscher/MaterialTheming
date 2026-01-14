using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_NormalContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FFAFD6";
    public string OnPrimary => "#551A3D";
    public string PrimaryContainer => "#703054";
    public string OnPrimaryContainer => "#FFD8E8";
    // Secondary
    public string Secondary => "#ABD0B1";
    public string OnSecondary => "#173721";
    public string SecondaryContainer => "#2D4E36";
    public string OnSecondaryContainer => "#C6ECCC";
    // Tertiary
    public string Tertiary => "#B6CF8F";
    public string OnTertiary => "#233606";
    public string TertiaryContainer => "#394D1B";
    public string OnTertiaryContainer => "#D2ECA9";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#12140B";
    public string SurfaceVariant => "#444937";
    public string OnSurface => "#E2E4D4";
    public string OnSurfaceVariant => "#C4C9B1";
    public string SurfaceDim => "#12140B";
    public string SurfaceBright => "#383A2F";
    public string SurfaceTint => "#FFAFD6";
    // Background
    public string Background => "#12140B";
    public string OnBackground => "#E2E4D4";
    // Outline
    public string Outline => "#8E937D";
    public string OutlineVariant => "#444937";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E2E4D4";
    public string InverseOnSurface => "#2F3227";
    public string InversePrimary => "#8C486C";
    // Primary Fixed
    public string PrimaryFixed => "#FFD8E8";
    public string OnPrimaryFixed => "#3B0327";
    public string PrimaryFixedDim => "#FFAFD6";
    public string OnPrimaryFixedVariant => "#703054";
    // Secondary Fixed
    public string SecondaryFixed => "#C6ECCC";
    public string OnSecondaryFixed => "#01210D";
    public string SecondaryFixedDim => "#ABD0B1";
    public string OnSecondaryFixedVariant => "#2D4E36";
    // Tertiary Fixed
    public string TertiaryFixed => "#D2ECA9";
    public string OnTertiaryFixed => "#111F00";
    public string TertiaryFixedDim => "#B6CF8F";
    public string OnTertiaryFixedVariant => "#394D1B";
    // Surface Container
    public string SurfaceContainerLowest => "#0D0F07";
    public string SurfaceContainerLow => "#1A1D13";
    public string SurfaceContainer => "#1E2117";
    public string SurfaceContainerHigh => "#292B21";
    public string SurfaceContainerHighest => "#33362B";
}
