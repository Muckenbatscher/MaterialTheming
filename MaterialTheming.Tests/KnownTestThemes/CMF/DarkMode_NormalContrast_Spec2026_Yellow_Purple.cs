namespace MaterialTheming.Tests.KnownTestThemes.CMF;

internal class DarkMode_NormalContrast_Spec2026_Yellow_Purple : ITestThemeSecondSourceColor
{
    public string SourceColor => "#B2B037"; //Yellow
    public string SecondSourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.CMF;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#C0BE44";
    public string OnPrimary => "#393900";
    public string PrimaryContainer => "#B2B037";
    public string OnPrimaryContainer => "#2F2E00";
    // Secondary
    public string Secondary => "#A2A06B";
    public string OnSecondary => "#222100";
    public string SecondaryContainer => "#333207";
    public string OnSecondaryContainer => "#B5B37B";
    // Tertiary
    public string Tertiary => "#BD84F8";
    public string OnTertiary => "#32005C";
    public string TertiaryContainer => "#925ACA";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#FE8B70";
    public string OnError => "#5A1001";
    public string ErrorContainer => "#5C1202";
    public string OnErrorContainer => "#FF8F74";
    // Surface
    public string Surface => "#0F0F04";
    public string SurfaceVariant => "#27270D";
    public string OnSurface => "#EAE7BF";
    public string OnSurfaceVariant => "#AFAD88";
    public string SurfaceDim => "#0F0F04";
    public string SurfaceBright => "#2E2D13";
    public string SurfaceTint => "#C0BE44";
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
    public string TertiaryFixed => "#925ACA";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#844DBD";
    public string OnTertiaryFixedVariant => "#FFFBFF";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#141404";
    public string SurfaceContainer => "#1B1A07";
    public string SurfaceContainerHigh => "#21210A";
    public string SurfaceContainerHighest => "#27270D";
}
