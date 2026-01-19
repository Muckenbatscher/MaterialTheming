namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_HighContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#F9EBFF";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#D7B6F5";
    public string OnPrimaryContainer => "#15002C";
    // Secondary
    public string Secondary => "#F9EBFF";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#CCBDD6";
    public string OnSecondaryContainer => "#100818";
    // Tertiary
    public string Tertiary => "#FFEBEC";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#EFB3BA";
    public string OnTertiaryContainer => "#1E0307";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#151218";
    public string SurfaceVariant => "#4A454E";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#151218";
    public string SurfaceBright => "#534E55";
    public string SurfaceTint => "#DBB9F9";
    // Background
    public string Background => "#151218";
    public string OnBackground => "#E8E0E8";
    // Outline
    public string Outline => "#F7EDF8";
    public string OutlineVariant => "#C8C0CB";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E8E0E8";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#573C72";
    // Primary Fixed
    public string PrimaryFixed => "#F0DBFF";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#DBB9F9";
    public string OnPrimaryFixedVariant => "#1D0137";
    // Secondary Fixed
    public string SecondaryFixed => "#EDDDF6";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#D0C1DA";
    public string OnSecondaryFixedVariant => "#160D1F";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFD9DD";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#F3B7BE";
    public string OnTertiaryFixedVariant => "#25060C";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#221E24";
    public string SurfaceContainer => "#332F35";
    public string SurfaceContainerHigh => "#3E3A40";
    public string SurfaceContainerHighest => "#4A454C";
}
