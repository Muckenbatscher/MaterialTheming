using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_HighContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#EAF0FF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#A0C4FF";
    public string OnPrimaryContainer => "#000B1E";
    // Secondary
    public string Secondary => "#EAF0FF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#A3C4FB";
    public string OnSecondaryContainer => "#000B1E";
    // Tertiary
    public string Tertiary => "#F9EBFF";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#D7B6F5";
    public string OnTertiaryContainer => "#15002C";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#16111B";
    public string SurfaceVariant => "#4D4357";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#16111B";
    public string SurfaceBright => "#554D59";
    public string SurfaceTint => "#A6C8FF";
    // Background
    public string Background => "#16111B";
    public string OnBackground => "#EADFED";
    // Outline
    public string Outline => "#F9EBFF";
    public string OutlineVariant => "#CCBDD6";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#EADFED";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#004889";
    // Primary Fixed
    public string PrimaryFixed => "#D5E3FF";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#A6C8FF";
    public string OnPrimaryFixedVariant => "#001129";
    // Secondary Fixed
    public string SecondaryFixed => "#D5E3FF";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#A6C8FF";
    public string OnSecondaryFixedVariant => "#001129";
    // Tertiary Fixed
    public string TertiaryFixed => "#F0DBFF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#DBB9F9";
    public string OnTertiaryFixedVariant => "#1D0137";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#231D28";
    public string SurfaceContainer => "#342E39";
    public string SurfaceContainerHigh => "#3F3944";
    public string SurfaceContainerHighest => "#4B4450";
}
