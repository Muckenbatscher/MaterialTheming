using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_MediumContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#003C44";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#007886";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#003C44";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#187884";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#0C3765";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#4C6EA0";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F9F9FF";
    public string SurfaceVariant => "#D9E3F8";
    public string OnSurface => "#0C111A";
    public string OnSurfaceVariant => "#2D3747";
    public string SurfaceDim => "#C2C6D2";
    public string SurfaceBright => "#F9F9FF";
    public string SurfaceTint => "#006874";
    // Background
    public string Background => "#F9F9FF";
    public string OnBackground => "#171C24";
    // Outline
    public string Outline => "#495364";
    public string OutlineVariant => "#636D80";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2B313A";
    public string InverseOnSurface => "#ECF1FD";
    public string InversePrimary => "#4FD8EB";
    // Primary Fixed
    public string PrimaryFixed => "#007886";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#005E69";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#187884";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#005E69";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#4C6EA0";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#335685";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F0F3FF";
    public string SurfaceContainer => "#E4E8F4";
    public string SurfaceContainerHigh => "#D8DDE9";
    public string SurfaceContainerHighest => "#CDD1DE";
}
