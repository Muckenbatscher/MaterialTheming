namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class DarkMode_HighContrast_Spec2026_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => true;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#D9E6FF";
    public string OnPrimary => "#002C58";
    public string PrimaryContainer => "#A6C8FF";
    public string OnPrimaryContainer => "#001128";
    // Secondary
    public string Secondary => "#D3EBDB";
    public string OnSecondary => "#1B3025";
    public string SecondaryContainer => "#92A99A";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#DDFFE4";
    public string OnTertiary => "#004023";
    public string TertiaryContainer => "#9AFDBF";
    public string OnTertiaryContainer => "#00361D";
    // Error
    public string Error => "#FFDEDB";
    public string OnError => "#60000A";
    public string ErrorContainer => "#FF7C76";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#060E1B";
    public string SurfaceVariant => "#15263E";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#D9E6FF";
    public string SurfaceDim => "#060E1B";
    public string SurfaceBright => "#192D48";
    public string SurfaceTint => "#D9E6FF";
    // Background
    public string Background => "#060E1B";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#A9BAD8";
    public string OutlineVariant => "#94A4C2";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#F9F9FF";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#0F3967";
    // Primary Fixed
    public string PrimaryFixed => "#A6C8FF";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#98BAF0";
    public string OnPrimaryFixedVariant => "#000000";
    // Secondary Fixed
    public string SecondaryFixed => "#DEF7E6";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#D0E8D8";
    public string OnSecondaryFixedVariant => "#192E23";
    // Tertiary Fixed
    public string TertiaryFixed => "#9AFDBF";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#8CEEB1";
    public string OnTertiaryFixedVariant => "#002A16";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#091423";
    public string SurfaceContainer => "#0D1A2C";
    public string SurfaceContainerHigh => "#112035";
    public string SurfaceContainerHighest => "#15263E";
}
