namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class DarkMode_NormalContrast_Spec2021_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#DBB9F9";
    public string OnPrimary => "#3E2459";
    public string PrimaryContainer => "#563B71";
    public string OnPrimaryContainer => "#F0DBFF";
    // Secondary
    public string Secondary => "#D0C1DA";
    public string OnSecondary => "#362C3F";
    public string SecondaryContainer => "#4D4357";
    public string OnSecondaryContainer => "#EDDDF6";
    // Tertiary
    public string Tertiary => "#F3B7BE";
    public string OnTertiary => "#4B252B";
    public string TertiaryContainer => "#653A41";
    public string OnTertiaryContainer => "#FFD9DD";
    // Error
    public string Error => "#FFB4AB";
    public string OnError => "#690005";
    public string ErrorContainer => "#93000A";
    public string OnErrorContainer => "#FFDAD6";
    // Surface
    public string Surface => "#151218";
    public string SurfaceVariant => "#4A454E";
    public string OnSurface => "#E8E0E8";
    public string OnSurfaceVariant => "#CCC4CE";
    public string SurfaceDim => "#151218";
    public string SurfaceBright => "#3C383E";
    public string SurfaceTint => "#DBB9F9";
    // Background
    public string Background => "#151218";
    public string OnBackground => "#E8E0E8";
    // Outline
    public string Outline => "#968E98";
    public string OutlineVariant => "#4A454E";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#E8E0E8";
    public string InverseOnSurface => "#332F35";
    public string InversePrimary => "#6E528A";
    // Primary Fixed
    public string PrimaryFixed => "#F0DBFF";
    public string OnPrimaryFixed => "#280D42";
    public string PrimaryFixedDim => "#DBB9F9";
    public string OnPrimaryFixedVariant => "#563B71";
    // Secondary Fixed
    public string SecondaryFixed => "#EDDDF6";
    public string OnSecondaryFixed => "#211829";
    public string SecondaryFixedDim => "#D0C1DA";
    public string OnSecondaryFixedVariant => "#4D4357";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFD9DD";
    public string OnTertiaryFixed => "#321017";
    public string TertiaryFixedDim => "#F3B7BE";
    public string OnTertiaryFixedVariant => "#653A41";
    // Surface Container
    public string SurfaceContainerLowest => "#100D12";
    public string SurfaceContainerLow => "#1E1A20";
    public string SurfaceContainer => "#221E24";
    public string SurfaceContainerHigh => "#2C292E";
    public string SurfaceContainerHighest => "#373339";
}
