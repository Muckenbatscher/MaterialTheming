namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_HighContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FFEBF2";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#D6BCC6";
    public string OnPrimaryContainer => "#14070E";
    // Secondary
    public string Secondary => "#FEEBF1";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#D0BEC4";
    public string OnSecondaryContainer => "#11090D";
    // Tertiary
    public string Tertiary => "#FFEBF2";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#DBBAC8";
    public string OnTertiaryContainer => "#17060F";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#151314";
    public string SurfaceVariant => "#4A4647";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#151314";
    public string SurfaceBright => "#534F50";
    public string SurfaceTint => "#DAC0CA";
    // Background
    public string Background => "#151314";
    public string OnBackground => "#E8E1E1";
    // Outline
    public string Outline => "#F6EEEF";
    public string OutlineVariant => "#C7C1C2";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E8E1E1";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#55434B";
    // Primary Fixed
    public string PrimaryFixed => "#F7DBE6";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#DAC0CA";
    public string OnPrimaryFixedVariant => "#1B0D14";
    // Secondary Fixed
    public string SecondaryFixed => "#F1DEE4";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#D4C2C8";
    public string OnSecondaryFixedVariant => "#180E13";
    // Tertiary Fixed
    public string TertiaryFixed => "#FDD9E8";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#E0BDCC";
    public string OnTertiaryFixedVariant => "#1E0B15";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#221F20";
    public string SurfaceContainer => "#333030";
    public string SurfaceContainerHigh => "#3E3A3B";
    public string SurfaceContainerHighest => "#4A4647";
}
