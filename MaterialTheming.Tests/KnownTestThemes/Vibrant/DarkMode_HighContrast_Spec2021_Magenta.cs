namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_HighContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#FFEBF2";
    public string OnPrimary => "#000000";
    public string PrimaryContainer => "#FFA9D4";
    public string OnPrimaryContainer => "#1F0013";
    // Secondary
    public string Secondary => "#FFEBEE";
    public string OnSecondary => "#000000";
    public string SecondaryContainer => "#ECB4C1";
    public string OnSecondaryContainer => "#1D020B";
    // Tertiary
    public string Tertiary => "#FFECEB";
    public string OnTertiary => "#000000";
    public string TertiaryContainer => "#FDAEB1";
    public string OnTertiaryContainer => "#210004";
    // Error
    public string Error => "#FFECE9";
    public string OnError => "#000000";
    public string ErrorContainer => "#FFAEA4";
    public string OnErrorContainer => "#220001";
    // Surface
    public string Surface => "#1C1016";
    public string SurfaceVariant => "#54424A";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#FFFFFF";
    public string SurfaceDim => "#1C1016";
    public string SurfaceBright => "#5C4C52";
    public string SurfaceTint => "#FFAFD6";
    // Background
    public string Background => "#1C1016";
    public string OnBackground => "#F4DDE5";
    // Outline
    public string Outline => "#FFEBF2";
    public string OutlineVariant => "#D6BCC6";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F4DDE5";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#8C0062";
    // Primary Fixed
    public string PrimaryFixed => "#FFD8E8";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#FFAFD6";
    public string OnPrimaryFixedVariant => "#2A001A";
    // Secondary Fixed
    public string SecondaryFixed => "#FFD9E1";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#F0B7C5";
    public string OnSecondaryFixedVariant => "#250611";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFDADA";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#FFB3B6";
    public string OnTertiaryFixedVariant => "#2A0208";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#291C22";
    public string SurfaceContainer => "#3B2C33";
    public string SurfaceContainerHigh => "#46373E";
    public string SurfaceContainerHighest => "#524249";
}
