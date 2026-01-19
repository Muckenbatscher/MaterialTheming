namespace MaterialTheming.Tests.KnownTestThemes.Fidelity;

internal class LightMode_NormalContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => false;
    public Variant Variant => Variant.Fidelity;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#984804";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#D77837";
    public string OnPrimaryContainer => "#481E00";
    // Secondary
    public string Secondary => "#805439";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#FDC2A0";
    public string OnSecondaryContainer => "#794E33";
    // Tertiary
    public string Tertiary => "#00677E";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#009EBF";
    public string OnTertiaryContainer => "#002E3A";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#FFF8F5";
    public string SurfaceVariant => "#F8DDCF";
    public string OnSurface => "#221A15";
    public string OnSurfaceVariant => "#554339";
    public string SurfaceDim => "#E8D7CE";
    public string SurfaceBright => "#FFF8F5";
    public string SurfaceTint => "#984804";
    // Background
    public string Background => "#FFF8F5";
    public string OnBackground => "#221A15";
    // Outline
    public string Outline => "#887367";
    public string OutlineVariant => "#DBC1B4";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#382E29";
    public string InverseOnSurface => "#FFEDE5";
    public string InversePrimary => "#FFB68B";
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
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF1EA";
    public string SurfaceContainer => "#FCEAE2";
    public string SurfaceContainerHigh => "#F6E5DC";
    public string SurfaceContainerHighest => "#F1DFD7";
}
