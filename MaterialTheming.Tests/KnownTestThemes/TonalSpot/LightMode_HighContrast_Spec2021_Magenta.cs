namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_HighContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#4D1937";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#6F3655";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#3C2630";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#5B424E";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#45240D";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#674027";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F8";
    public string SurfaceVariant => "#F1DEE4";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#C3B5BA";
    public string SurfaceBright => "#FFF8F8";
    public string SurfaceTint => "#884B6B";
    // Background
    public string Background => "#FFF8F8";
    public string OnBackground => "#21191D";
    // Outline
    public string Outline => "#34292E";
    public string OutlineVariant => "#52464B";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#372E32";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#FCB0D5";
    // Primary Fixed
    public string PrimaryFixed => "#6F3655";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#541F3E";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#5B424E";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#432C37";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#674027";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#4D2A13";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FCEDF1";
    public string SurfaceContainer => "#EEDFE3";
    public string SurfaceContainerHigh => "#DFD1D5";
    public string SurfaceContainerHighest => "#D1C3C7";
}
