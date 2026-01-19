namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_NormalContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#884B6B";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#FFD8E8";
    public string OnPrimaryContainer => "#6C3353";
    // Secondary
    public string Secondary => "#725763";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#FDD9E8";
    public string OnSecondaryContainer => "#58404B";
    // Tertiary
    public string Tertiary => "#7F543A";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#FFDBC8";
    public string OnTertiaryContainer => "#643D25";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#FFF8F8";
    public string SurfaceVariant => "#F1DEE4";
    public string OnSurface => "#21191D";
    public string OnSurfaceVariant => "#504348";
    public string SurfaceDim => "#E5D6DB";
    public string SurfaceBright => "#FFF8F8";
    public string SurfaceTint => "#884B6B";
    // Background
    public string Background => "#FFF8F8";
    public string OnBackground => "#21191D";
    // Outline
    public string Outline => "#827379";
    public string OutlineVariant => "#D4C2C8";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#372E32";
    public string InverseOnSurface => "#FCEDF1";
    public string InversePrimary => "#FCB0D5";
    // Primary Fixed
    public string PrimaryFixed => "#FFD8E8";
    public string OnPrimaryFixed => "#380726";
    public string PrimaryFixedDim => "#FCB0D5";
    public string OnPrimaryFixedVariant => "#6C3353";
    // Secondary Fixed
    public string SecondaryFixed => "#FDD9E8";
    public string OnSecondaryFixed => "#291520";
    public string SecondaryFixedDim => "#E0BDCC";
    public string OnSecondaryFixedVariant => "#58404B";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFDBC8";
    public string OnTertiaryFixed => "#311302";
    public string TertiaryFixedDim => "#F3BB9A";
    public string OnTertiaryFixedVariant => "#643D25";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0F4";
    public string SurfaceContainer => "#F9EAEE";
    public string SurfaceContainerHigh => "#F3E4E9";
    public string SurfaceContainerHighest => "#EEDFE3";
}
