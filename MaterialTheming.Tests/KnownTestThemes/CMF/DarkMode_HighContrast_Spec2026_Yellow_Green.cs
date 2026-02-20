namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class DarkMode_HighContrast_Spec2026_Yellow_Green : ITestThemeSecondSourceColor
{
    public string SourceColor => "#B2B037"; //Yellow
    public string SecondSourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#EDEB6C";
    public string OnPrimary => "#2E2E00";
    public string PrimaryContainer => "#B2B037";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#EBE8AC";
    public string OnSecondary => "#2E2E03";
    public string SecondaryContainer => "#A8A670";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#A2F9AA";
    public string OnTertiary => "#003411";
    public string TertiaryContainer => "#62B56E";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFDEDB";
    public string OnError => "#5A0D0E";
    public string ErrorContainer => "#F5827A";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#0F0F04";
    public string SurfaceVariant => "#27270D";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#EAE7BF";
    public string SurfaceDim => "#0F0F04";
    public string SurfaceBright => "#2E2D13";
    public string SurfaceTint => "#EDEB6C";
    // Background
    public string Background => "#0F0F04";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#BDBA95";
    public string OutlineVariant => "#A7A581";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FEFBD2";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#3B3A00";
    // Primary Fixed
    public string PrimaryFixed => "#B2B037";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#AAA830";
    public string OnPrimaryFixedVariant => "#000000";
    // Secondary Fixed
    public string SecondaryFixed => "#E8E5AA";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#DAD79D";
    public string OnSecondaryFixedVariant => "#212100";
    // Tertiary Fixed
    public string TertiaryFixed => "#62B56E";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#62B56E";
    public string OnTertiaryFixedVariant => "#000000";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#141404";
    public string SurfaceContainer => "#1B1A07";
    public string SurfaceContainerHigh => "#21210A";
    public string SurfaceContainerHighest => "#27270D";
}
