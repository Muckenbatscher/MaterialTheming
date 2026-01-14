using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class DarkMode_MediumContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#E4E264";
    public string OnPrimary => "#282700";
    public string PrimaryContainer => "#B2B037";
    public string OnPrimaryContainer => "#222200";
    // Secondary
    public string Secondary => "#E2DFA4";
    public string OnSecondary => "#282700";
    public string SecondaryContainer => "#95935F";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#E7D5FF";
    public string OnTertiary => "#330A67";
    public string TertiaryContainer => "#BF9AF8";
    public string OnTertiaryContainer => "#2E0162";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#14140C";
    public string SurfaceVariant => "#484736";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#E0DDC6";
    public string SurfaceDim => "#14140C";
    public string SurfaceBright => "#46453B";
    public string SurfaceTint => "#CECC50";
    // Background
    public string Background => "#14140C";
    public string OnBackground => "#E6E3D5";
    // Outline
    public string Outline => "#B5B39D";
    public string OutlineVariant => "#93917D";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E6E3D5";
    public string InverseOnSurface => "#2B2A21";
    public string InversePrimary => "#4B4A00";
    // Primary Fixed
    public string PrimaryFixed => "#EAE869";
    public string OnPrimaryFixed => "#121200";
    public string PrimaryFixedDim => "#CECC50";
    public string OnPrimaryFixedVariant => "#393800";
    // Secondary Fixed
    public string SecondaryFixed => "#E8E5AA";
    public string OnSecondaryFixed => "#121200";
    public string SecondaryFixedDim => "#CCC990";
    public string OnSecondaryFixedVariant => "#39380C";
    // Tertiary Fixed
    public string TertiaryFixed => "#ECDCFF";
    public string OnTertiaryFixed => "#1A003D";
    public string TertiaryFixedDim => "#D6BAFF";
    public string OnTertiaryFixedVariant => "#452178";
    // Surface Container
    public string SurfaceContainerLowest => "#080803";
    public string SurfaceContainerLow => "#1E1E15";
    public string SurfaceContainer => "#29281F";
    public string SurfaceContainerHigh => "#34332A";
    public string SurfaceContainerHighest => "#3F3E34";
}
