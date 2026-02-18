namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_NormalContrast_Spec2026_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#CB97FF";
    public string OnPrimary => "#46007C";
    public string PrimaryContainer => "#C185FF";
    public string OnPrimaryContainer => "#360062";
    // Secondary
    public string Secondary => "#E097FD";
    public string OnSecondary => "#530C70";
    public string SecondaryContainer => "#692886";
    public string OnSecondaryContainer => "#F0BFFF";
    // Tertiary
    public string Tertiary => "#FF95A1";
    public string OnTertiary => "#680922";
    public string TertiaryContainer => "#FE7E8F";
    public string OnTertiaryContainer => "#570019";
    // Error
    public string Error => "#FF6E84";
    public string OnError => "#490013";
    public string ErrorContainer => "#A70138";
    public string OnErrorContainer => "#FFB2B9";
    // Surface
    public string Surface => "#1B0425";
    public string SurfaceVariant => "#391648";
    public string OnSurface => "#F9DCFF";
    public string OnSurfaceVariant => "#C1A0CB";
    public string SurfaceDim => "#1B0425";
    public string SurfaceBright => "#411C51";
    public string SurfaceTint => "#CB97FF";
    // Background
    public string Background => "#1B0425";
    public string OnBackground => "#F9DCFF";
    // Outline
    public string Outline => "#896B93";
    public string OutlineVariant => "#593E63";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF7FB";
    public string InverseOnSurface => "#674B71";
    public string InversePrimary => "#8231CE";
    // Primary Fixed
    public string PrimaryFixed => "#C185FF";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#B871FF";
    public string OnPrimaryFixedVariant => "#430077";
    // Secondary Fixed
    public string SecondaryFixed => "#F0C1FF";
    public string OnSecondaryFixed => "#550F72";
    public string SecondaryFixedDim => "#EAAEFF";
    public string OnSecondaryFixedVariant => "#743391";
    // Tertiary Fixed
    public string TertiaryFixed => "#FF909D";
    public string OnTertiaryFixed => "#39000D";
    public string TertiaryFixedDim => "#FA7C8D";
    public string OnTertiaryFixedVariant => "#711228";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#21072D";
    public string SurfaceContainer => "#290C36";
    public string SurfaceContainerHigh => "#31113F";
    public string SurfaceContainerHighest => "#391648";
}
