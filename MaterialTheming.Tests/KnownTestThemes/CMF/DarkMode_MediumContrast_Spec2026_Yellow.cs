namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class DarkMode_MediumContrast_Spec2026_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => true;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#C0BE44";
    public string OnPrimary => "#2E2E00";
    public string PrimaryContainer => "#B2B037";
    public string OnPrimaryContainer => "#222200";
    // Secondary
    public string Secondary => "#BEBB83";
    public string OnSecondary => "#2E2E04";
    public string SecondaryContainer => "#787745";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#BFBD65";
    public string OnTertiary => "#2E2E00";
    public string TertiaryContainer => "#B1AF59";
    public string OnTertiaryContainer => "#222200";
    // Error
    public string Error => "#FF9F97";
    public string OnError => "#5A0D0E";
    public string ErrorContainer => "#BB554F";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#0F0F04";
    public string SurfaceVariant => "#27270D";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#BDBA95";
    public string SurfaceDim => "#0F0F04";
    public string SurfaceBright => "#2E2D13";
    public string SurfaceTint => "#C0BE44";
    // Background
    public string Background => "#0F0F04";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#979572";
    public string OutlineVariant => "#787756";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FEFBD2";
    public string InverseOnSurface => "#3A3929";
    public string InversePrimary => "#595800";
    // Primary Fixed
    public string PrimaryFixed => "#B2B037";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#A4A22A";
    public string OnPrimaryFixedVariant => "#121100";
    // Secondary Fixed
    public string SecondaryFixed => "#E8E5AA";
    public string OnSecondaryFixed => "#212100";
    public string SecondaryFixedDim => "#DAD79D";
    public string OnSecondaryFixedVariant => "#424115";
    // Tertiary Fixed
    public string TertiaryFixed => "#B1AF5A";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#A3A24E";
    public string OnTertiaryFixedVariant => "#121100";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#141404";
    public string SurfaceContainer => "#1B1A07";
    public string SurfaceContainerHigh => "#21210A";
    public string SurfaceContainerHighest => "#27270D";
}
