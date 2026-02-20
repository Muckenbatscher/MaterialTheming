namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class LightMode_HighContrast_Spec2026_Yellow_Magenta : ITestThemeSecondSourceColor
{
    public string SourceColor => "#B2B037"; //Yellow
    public string SecondSourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#262500";
    public string OnPrimary => "#E2DF62";
    public string PrimaryContainer => "#565500";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#262500";
    public string OnSecondary => "#DFDDA2";
    public string SecondaryContainer => "#555426";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#4B0033";
    public string OnTertiary => "#FFCCE3";
    public string TertiaryContainer => "#99176C";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#4F0407";
    public string OnError => "#FFCFCA";
    public string ErrorContainer => "#8E3430";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FEFAE3";
    public string SurfaceVariant => "#E7E4BD";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#25250B";
    public string SurfaceDim => "#DFDCB5";
    public string SurfaceBright => "#FEFAE3";
    public string SurfaceTint => "#262500";
    // Background
    public string Background => "#FEFAE3";
    public string OnBackground => "#000000";
    // Outline
    public string Outline => "#454427";
    public string OutlineVariant => "#555435";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#0F0F00";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#F6F473";
    // Primary Fixed
    public string PrimaryFixed => "#565500";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#4A4900";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#555426";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#49481C";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#99176C";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#890160";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F8F5D7";
    public string SurfaceContainer => "#F2EFCE";
    public string SurfaceContainerHigh => "#EDEAC7";
    public string SurfaceContainerHighest => "#E7E4BD";
}
