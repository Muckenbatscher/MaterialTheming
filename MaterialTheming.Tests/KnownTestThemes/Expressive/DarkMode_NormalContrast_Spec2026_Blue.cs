namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_NormalContrast_Spec2026_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#A6C8FF";
    public string OnPrimary => "#1B416F";
    public string PrimaryContainer => "#234776";
    public string OnPrimaryContainer => "#B7D2FF";
    // Secondary
    public string Secondary => "#B4CCBC";
    public string OnSecondary => "#304539";
    public string SecondaryContainer => "#152A1F";
    public string OnSecondaryContainer => "#92A99A";
    // Tertiary
    public string Tertiary => "#DDFFE4";
    public string OnTertiary => "#006C3F";
    public string TertiaryContainer => "#9AFDBF";
    public string OnTertiaryContainer => "#006239";
    // Error
    public string Error => "#FF716C";
    public string OnError => "#490006";
    public string ErrorContainer => "#8A1A1E";
    public string OnErrorContainer => "#FF9993";
    // Surface
    public string Surface => "#060E1B";
    public string SurfaceVariant => "#15263E";
    public string OnSurface => "#D9E6FF";
    public string OnSurfaceVariant => "#9BACCA";
    public string SurfaceDim => "#060E1B";
    public string SurfaceBright => "#192D48";
    public string SurfaceTint => "#A6C8FF";
    // Background
    public string Background => "#060E1B";
    public string OnBackground => "#D9E6FF";
    // Outline
    public string Outline => "#667692";
    public string OutlineVariant => "#384962";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F9F9FF";
    public string InverseOnSurface => "#4D5564";
    public string InversePrimary => "#3E6090";
    // Primary Fixed
    public string PrimaryFixed => "#A6C8FF";
    public string OnPrimaryFixed => "#002C58";
    public string PrimaryFixedDim => "#98BAF0";
    public string OnPrimaryFixedVariant => "#264A79";
    // Secondary Fixed
    public string SecondaryFixed => "#DEF7E6";
    public string OnSecondaryFixed => "#374D40";
    public string SecondaryFixedDim => "#D0E8D8";
    public string OnSecondaryFixedVariant => "#53695C";
    // Tertiary Fixed
    public string TertiaryFixed => "#9AFDBF";
    public string OnTertiaryFixed => "#004E2C";
    public string TertiaryFixedDim => "#8CEEB1";
    public string OnTertiaryFixedVariant => "#006E40";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#091423";
    public string SurfaceContainer => "#0D1A2C";
    public string SurfaceContainerHigh => "#112035";
    public string SurfaceContainerHighest => "#15263E";
}
