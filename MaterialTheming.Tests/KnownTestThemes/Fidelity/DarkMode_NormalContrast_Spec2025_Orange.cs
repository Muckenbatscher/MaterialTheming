using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class DarkMode_NormalContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#FFB68B";
    public string OnPrimary => "#522300";
    public string PrimaryContainer => "#D77837";
    public string OnPrimaryContainer => "#481E00";
    // Secondary
    public string Secondary => "#F4BA98";
    public string OnSecondary => "#4B270F";
    public string SecondaryContainer => "#653D23";
    public string OnSecondaryContainer => "#E1A988";
    // Tertiary
    public string Tertiary => "#61D5F7";
    public string OnTertiary => "#003542";
    public string TertiaryContainer => "#009EBF";
    public string OnTertiaryContainer => "#002E3A";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#1A120D";
    public string SurfaceVariant => "#554339";
    public string OnSurface => "#F1DFD7";
    public string OnSurfaceVariant => "#DBC1B4";
    public string SurfaceDim => "#1A120D";
    public string SurfaceBright => "#423731";
    public string SurfaceTint => "#FFB68B";
    // Background
    public string Background => "#1A120D";
    public string OnBackground => "#F1DFD7";
    // Outline
    public string Outline => "#A38C80";
    public string OutlineVariant => "#554339";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F1DFD7";
    public string InverseOnSurface => "#382E29";
    public string InversePrimary => "#984804";
    // Primary Fixed
    public string PrimaryFixed => "#FFDBC8";
    public string OnPrimaryFixed => "#321300";
    public string PrimaryFixedDim => "#FFB68B";
    public string OnPrimaryFixedVariant => "#743400";
    // Secondary Fixed
    public string SecondaryFixed => "#FFDBC8";
    public string OnSecondaryFixed => "#311301";
    public string SecondaryFixedDim => "#F4BA98";
    public string OnSecondaryFixedVariant => "#653D23";
    // Tertiary Fixed
    public string TertiaryFixed => "#B4EBFF";
    public string OnTertiaryFixed => "#001F28";
    public string TertiaryFixedDim => "#61D5F7";
    public string OnTertiaryFixedVariant => "#004E5F";
    // Surface Container
    public string SurfaceContainerLowest => "#140C08";
    public string SurfaceContainerLow => "#221A15";
    public string SurfaceContainer => "#271E19";
    public string SurfaceContainerHigh => "#322823";
    public string SurfaceContainerHighest => "#3D332D";
}
