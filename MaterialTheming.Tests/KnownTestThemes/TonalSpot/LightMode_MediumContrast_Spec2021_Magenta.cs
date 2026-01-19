namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_MediumContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#592341";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#99597A";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#472F3A";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#816572";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#512D16";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#906348";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F8";
    public string SurfaceVariant => "#F1DEE4";
    public string OnSurface => "#160F12";
    public string OnSurfaceVariant => "#3F3338";
    public string SurfaceDim => "#D1C3C7";
    public string SurfaceBright => "#FFF8F8";
    public string SurfaceTint => "#884B6B";
    // Background
    public string Background => "#FFF8F8";
    public string OnBackground => "#21191D";
    // Outline
    public string Outline => "#5C4F54";
    public string OutlineVariant => "#78696F";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#372E32";
    public string InverseOnSurface => "#FCEDF1";
    public string InversePrimary => "#FCB0D5";
    // Primary Fixed
    public string PrimaryFixed => "#99597A";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#7D4161";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#816572";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#684D59";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#906348";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#744B32";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0F4";
    public string SurfaceContainer => "#F3E4E9";
    public string SurfaceContainerHigh => "#E8D9DD";
    public string SurfaceContainerHighest => "#DCCED2";
}
