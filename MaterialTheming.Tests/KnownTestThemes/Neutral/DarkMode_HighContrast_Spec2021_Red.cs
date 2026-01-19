namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_HighContrast_Spec2021_Red : ITestTheme
{
    public string SourceColor => "#D2463D"; //Red
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FFECE9";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#DBBBB7";
    public string OnPrimaryContainer => "#160706";
    // Secondary
    public string Secondary => "#FFECE9";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#D4BEBB";
    public string OnSecondaryContainer => "#130908";
    // Tertiary
    public string Tertiary => "#FFECE9";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#E3B9B4";
    public string OnTertiaryContainer => "#190605";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#161312";
    public string SurfaceVariant => "#4A4645";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#161312";
    public string SurfaceBright => "#544F4E";
    public string SurfaceTint => "#DFBFBB";
    // Background
    public string Background => "#161312";
    public string OnBackground => "#E9E1DF";
    // Outline
    public string Outline => "#F7EEED";
    public string OutlineVariant => "#C8C1C0";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E9E1DF";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#594240";
    // Primary Fixed
    public string PrimaryFixed => "#FDDBD7";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#DFBFBB";
    public string OnPrimaryFixedVariant => "#1D0D0B";
    // Secondary Fixed
    public string SecondaryFixed => "#F5DDDA";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#D8C2BF";
    public string OnSecondaryFixedVariant => "#190E0D";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFDAD6";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#E7BDB8";
    public string OnTertiaryFixedVariant => "#200B09";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#221F1E";
    public string SurfaceContainer => "#332F2F";
    public string SurfaceContainerHigh => "#3F3A3A";
    public string SurfaceContainerHighest => "#4A4645";
}
