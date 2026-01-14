using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.FruitSalad;

internal class LightMode_NormalContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.FruitSalad;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#006874";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#98F0FF";
    public string OnPrimaryContainer => "#004F58";
    // Secondary
    public string Secondary => "#006874";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#9EEFFD";
    public string OnSecondaryContainer => "#004F58";
    // Tertiary
    public string Tertiary => "#3D5F90";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#D5E3FF";
    public string OnTertiaryContainer => "#234776";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#F9F9FF";
    public string SurfaceVariant => "#D9E3F8";
    public string OnSurface => "#171C24";
    public string OnSurfaceVariant => "#3D4758";
    public string SurfaceDim => "#D5DAE6";
    public string SurfaceBright => "#F9F9FF";
    public string SurfaceTint => "#006874";
    // Background
    public string Background => "#F9F9FF";
    public string OnBackground => "#171C24";
    // Outline
    public string Outline => "#6D778A";
    public string OutlineVariant => "#BDC7DC";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2B313A";
    public string InverseOnSurface => "#ECF1FD";
    public string InversePrimary => "#4FD8EB";
    // Primary Fixed
    public string PrimaryFixed => "#98F0FF";
    public string OnPrimaryFixed => "#001F24";
    public string PrimaryFixedDim => "#4FD8EB";
    public string OnPrimaryFixedVariant => "#004F58";
    // Secondary Fixed
    public string SecondaryFixed => "#9EEFFD";
    public string OnSecondaryFixed => "#001F24";
    public string SecondaryFixedDim => "#82D3E0";
    public string OnSecondaryFixedVariant => "#004F58";
    // Tertiary Fixed
    public string TertiaryFixed => "#D5E3FF";
    public string OnTertiaryFixed => "#001C3B";
    public string TertiaryFixedDim => "#A6C8FF";
    public string OnTertiaryFixedVariant => "#234776";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F0F3FF";
    public string SurfaceContainer => "#E9EEFA";
    public string SurfaceContainerHigh => "#E4E8F4";
    public string SurfaceContainerHighest => "#DEE2EF";
}
