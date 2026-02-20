namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class DarkMode_NormalContrast_Spec2026_Yellow_Green : ITestThemeSecondSourceColor
{
    public string SourceColor => "#B2B037"; //Yellow
    public string SecondSourceColor => "#338745"; //Green
    public bool IsDark => true;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#B2B037";
    public string OnPrimary => "#2F2E00";
    public string PrimaryContainer => "#A4A22A";
    public string OnPrimaryContainer => "#222100";
    // Secondary
    public string Secondary => "#A2A06B";
    public string OnSecondary => "#222100";
    public string SecondaryContainer => "#333207";
    public string OnSecondaryContainer => "#B5B37B";
    // Tertiary
    public string Tertiary => "#5CAF68";
    public string OnTertiary => "#00270A";
    public string TertiaryContainer => "#308443";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#FB877F";
    public string OnError => "#570B0D";
    public string ErrorContainer => "#480005";
    public string OnErrorContainer => "#EE7D75";
    // Surface
    public string Surface => "#0F0F04";
    public string SurfaceVariant => "#27270D";
    public string OnSurface => "#EAE7BF";
    public string OnSurfaceVariant => "#AFAD88";
    public string SurfaceDim => "#0F0F04";
    public string SurfaceBright => "#2E2D13";
    public string SurfaceTint => "#B2B037";
    // Background
    public string Background => "#0F0F04";
    public string OnBackground => "#EAE7BF";
    // Outline
    public string Outline => "#787756";
    public string OutlineVariant => "#4A492C";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FEFBD2";
    public string InverseOnSurface => "#575644";
    public string InversePrimary => "#636200";
    // Primary Fixed
    public string PrimaryFixed => "#B2B037";
    public string OnPrimaryFixed => "#121100";
    public string PrimaryFixedDim => "#A4A22A";
    public string OnPrimaryFixedVariant => "#383700";
    // Secondary Fixed
    public string SecondaryFixed => "#E8E5AA";
    public string OnSecondaryFixed => "#424115";
    public string SecondaryFixedDim => "#DAD79D";
    public string OnSecondaryFixedVariant => "#5F5E2E";
    // Tertiary Fixed
    public string TertiaryFixed => "#308443";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#217737";
    public string OnTertiaryFixedVariant => "#A5FCAD";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#141404";
    public string SurfaceContainer => "#1B1A07";
    public string SurfaceContainerHigh => "#21210A";
    public string SurfaceContainerHighest => "#27270D";
}
