namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class DarkMode_NormalContrast_Spec2021_Orange : ITestTheme
{
    public string SourceColor => "#D77837"; //Orange
    public bool IsDark => true;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#DEC1B1";
    public string OnPrimary => "#3F2C21";
    public string PrimaryContainer => "#574236";
    public string OnPrimaryContainer => "#FBDCCC";
    // Secondary
    public string Secondary => "#D7C2B8";
    public string OnSecondary => "#3A2E27";
    public string SecondaryContainer => "#52443C";
    public string OnSecondaryContainer => "#F4DED3";
    // Tertiary
    public string Tertiary => "#E5BFA9";
    public string OnTertiary => "#432B1C";
    public string TertiaryContainer => "#5C4131";
    public string OnTertiaryContainer => "#FFDBC8";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#161311";
    public string SurfaceVariant => "#4A4644";
    public string OnSurface => "#E9E1DE";
    public string OnSurfaceVariant => "#CCC5C2";
    public string SurfaceDim => "#161311";
    public string SurfaceBright => "#3C3837";
    public string SurfaceTint => "#DEC1B1";
    // Background
    public string Background => "#161311";
    public string OnBackground => "#E9E1DE";
    // Outline
    public string Outline => "#958F8D";
    public string OutlineVariant => "#4A4644";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E9E1DE";
    public string InverseOnSurface => "#33302E";
    public string InversePrimary => "#705A4D";
    // Primary Fixed
    public string PrimaryFixed => "#FBDCCC";
    public string OnPrimaryFixed => "#28180E";
    public string PrimaryFixedDim => "#DEC1B1";
    public string OnPrimaryFixedVariant => "#574236";
    // Secondary Fixed
    public string SecondaryFixed => "#F4DED3";
    public string OnSecondaryFixed => "#241913";
    public string SecondaryFixedDim => "#D7C2B8";
    public string OnSecondaryFixedVariant => "#52443C";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFDBC8";
    public string OnTertiaryFixed => "#2B1609";
    public string TertiaryFixedDim => "#E5BFA9";
    public string OnTertiaryFixedVariant => "#5C4131";
    // Surface Container
    public string SurfaceContainerLowest => "#100E0C";
    public string SurfaceContainerLow => "#1E1B19";
    public string SurfaceContainer => "#221F1D";
    public string SurfaceContainerHigh => "#2D2928";
    public string SurfaceContainerHighest => "#383432";
}
