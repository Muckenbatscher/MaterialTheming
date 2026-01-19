namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_MediumContrast_Spec2025_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#D7C2B8";
    public string OnPrimary => "#41332C";
    public string PrimaryContainer => "#827168";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#C2B6B1";
    public string OnSecondary => "#312B27";
    public string SecondaryContainer => "#7C736E";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#FFEEDB";
    public string OnTertiary => "#634C2B";
    public string TertiaryContainer => "#FFDDB1";
    public string OnTertiaryContainer => "#5A4423";
    // Error
    public string Error => "#FFA089";
    public string OnError => "#591001";
    public string ErrorContainer => "#BA573F";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#100E0D";
    public string SurfaceVariant => "#2A2522";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#C0B7B3";
    public string SurfaceDim => "#100E0D";
    public string SurfaceBright => "#312B28";
    public string SurfaceTint => "#D7C2B8";
    // Background
    public string Background => "#100E0D";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#9A928E";
    public string OutlineVariant => "#7B7470";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF8F6";
    public string InverseOnSurface => "#3B3736";
    public string InversePrimary => "#61524A";
    // Primary Fixed
    public string PrimaryFixed => "#F4DED3";
    public string OnPrimaryFixed => "#281D16";
    public string PrimaryFixedDim => "#E5D0C6";
    public string OnPrimaryFixedVariant => "#4A3C35";
    // Secondary Fixed
    public string SecondaryFixed => "#ECE0DB";
    public string OnSecondaryFixed => "#241E1B";
    public string SecondaryFixedDim => "#DED2CD";
    public string OnSecondaryFixedVariant => "#453E3A";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFDDB1";
    public string OnTertiaryFixed => "#2D1C02";
    public string TertiaryFixedDim => "#F0CFA4";
    public string OnTertiaryFixedVariant => "#513C1C";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#151311";
    public string SurfaceContainer => "#1C1917";
    public string SurfaceContainerHigh => "#231F1D";
    public string SurfaceContainerHighest => "#2A2522";
}
