using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class DarkMode_HighContrast_Spec2025_Purple : ITestTheme
{
    public string SourceColor => "#945CCD"; //Purple
    public bool IsDark => true;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#F2DFFF";
    public string OnPrimary => "#430077";
    public string PrimaryContainer => "#C489FF";
    public string OnPrimaryContainer => "#000000";
    // Secondary
    public string Secondary => "#F9DCFF";
    public string OnSecondary => "#4B0068";
    public string SecondaryContainer => "#CF88EC";
    public string OnSecondaryContainer => "#000000";
    // Tertiary
    public string Tertiary => "#FFDDDF";
    public string OnTertiary => "#5E011C";
    public string TertiaryContainer => "#FE7E8F";
    public string OnTertiaryContainer => "#000000";
    // Error
    public string Error => "#FFDDDF";
    public string OnError => "#5F001C";
    public string ErrorContainer => "#FF798C";
    public string OnErrorContainer => "#000000";
    // Surface
    public string Surface => "#1B0425";
    public string SurfaceVariant => "#391648";
    public string OnSurface => "#FFFFFF";
    public string OnSurfaceVariant => "#F9DCFF";
    public string SurfaceDim => "#1B0425";
    public string SurfaceBright => "#411C51";
    public string SurfaceTint => "#F2DFFF";
    // Background
    public string Background => "#1B0425";
    public string OnBackground => "#FFFFFF";
    // Outline
    public string Outline => "#CFADD9";
    public string OutlineVariant => "#B998C3";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#FFF7FB";
    public string InverseOnSurface => "#000000";
    public string InversePrimary => "#540093";
    // Primary Fixed
    public string PrimaryFixed => "#C489FF";
    public string OnPrimaryFixed => "#000000";
    public string PrimaryFixedDim => "#BA76FF";
    public string OnPrimaryFixedVariant => "#000000";
    // Secondary Fixed
    public string SecondaryFixed => "#F0C1FF";
    public string OnSecondaryFixed => "#000000";
    public string SecondaryFixedDim => "#EAAEFF";
    public string OnSecondaryFixedVariant => "#1C0029";
    // Tertiary Fixed
    public string TertiaryFixed => "#FF909D";
    public string OnTertiaryFixed => "#000000";
    public string TertiaryFixedDim => "#FA7C8D";
    public string OnTertiaryFixedVariant => "#000000";
    // Surface Container
    public string SurfaceContainerLowest => "#000000";
    public string SurfaceContainerLow => "#21072D";
    public string SurfaceContainer => "#290C36";
    public string SurfaceContainerHigh => "#31113F";
    public string SurfaceContainerHighest => "#391648";
}
