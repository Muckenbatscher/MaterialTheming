namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_MediumContrast_Spec2025_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#A6C8FF";
    public string OnPrimary => "#0C3765";
    public string PrimaryContainer => "#5476A8";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#B4CCBC";
    public string OnSecondary => "#263B2F";
    public string SecondaryContainer => "#637A6C";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#DDFFE4";
    public string OnTertiary => "#006038";
    public string TertiaryContainer => "#9AFDBF";
    public string OnTertiaryContainer => "#005732";
    // Error
    public string Error => "#FF9F99";
    public string OnError => "#60000A";
    public string ErrorContainer => "#C94947";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#060E1B";
    public string SurfaceVariant => "#15263E";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#A9BAD8";
    public string SurfaceDim => "#060E1B";
    public string SurfaceBright => "#192D48";
    public string SurfaceTint => "#A6C8FF";
    // Background
    public string Background => "#060E1B";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#8394B1";
    public string OutlineVariant => "#667692";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F9F9FF";
    public string InverseOnSurface => "#303947";
    public string InversePrimary => "#335686";
    // Primary Fixed
    public string PrimaryFixed => "#A6C8FF";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#98BAF0";
    public string OnPrimaryFixedVariant => "#002C58";
    // Secondary Fixed
    public string SecondaryFixed => "#DEF7E6";
    public string OnSecondaryFixed => "#192E23";
    public string SecondaryFixedDim => "#D0E8D8";
    public string OnSecondaryFixedVariant => "#374D40";
    // Tertiary Fixed
    public string TertiaryFixed => "#9AFDBF";
    public string OnTertiaryFixed => "#002A16";
    public string TertiaryFixedDim => "#8CEEB1";
    public string OnTertiaryFixedVariant => "#004E2C";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#091423";
    public string SurfaceContainer => "#0D1A2C";
    public string SurfaceContainerHigh => "#112035";
    public string SurfaceContainerHighest => "#15263E";
}
