using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class DarkMode_MediumContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#79EDFF";
    public string OnPrimary => "#002A30";
    public string PrimaryContainer => "#009FB1";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#98E9F7";
    public string OnSecondary => "#002A30";
    public string SecondaryContainer => "#499CA9";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#CBDDFF";
    public string OnTertiary => "#00264C";
    public string TertiaryContainer => "#7092C6";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFD2CC";
    public string OnError => "#540003";
    public string ErrorContainer => "#FF5449";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#0E141C";
    public string SurfaceVariant => "#3D4758";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#D2DDF2";
    public string SurfaceDim => "#0E141C";
    public string SurfaceBright => "#40454E";
    public string SurfaceTint => "#4FD8EB";
    // Background
    public string Background => "#0E141C";
    public string OnBackground => "#DEE2EF";
    // Outline
    public string Outline => "#A8B2C7";
    public string OutlineVariant => "#8691A4";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#DEE2EF";
    public string InverseOnSurface => "#252A33";
    public string InversePrimary => "#005059";
    // Primary Fixed
    public string PrimaryFixed => "#98F0FF";
    public string OnPrimaryFixed => "#001417";
    public string PrimaryFixedDim => "#4FD8EB";
    public string OnPrimaryFixedVariant => "#003C44";
    // Secondary Fixed
    public string SecondaryFixed => "#9EEFFD";
    public string OnSecondaryFixed => "#001417";
    public string SecondaryFixedDim => "#82D3E0";
    public string OnSecondaryFixedVariant => "#003C44";
    // Tertiary Fixed
    public string TertiaryFixed => "#D5E3FF";
    public string OnTertiaryFixed => "#001128";
    public string TertiaryFixedDim => "#A6C8FF";
    public string OnTertiaryFixedVariant => "#0C3765";
    // Surface Container
    public string SurfaceContainerLowest => "#04080F";
    public string SurfaceContainerLow => "#191E26";
    public string SurfaceContainer => "#232831";
    public string SurfaceContainerHigh => "#2E333C";
    public string SurfaceContainerHighest => "#393E47";
}
