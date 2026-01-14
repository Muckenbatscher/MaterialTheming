using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_NormalContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#B4007F";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#FFD8E8";
    public string OnPrimaryContainer => "#8A0060";
    // Secondary
    public string Secondary => "#7E525E";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#FFD9E1";
    public string OnSecondaryContainer => "#643B46";
    // Tertiary
    public string Tertiary => "#8B4C51";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#FFDADA";
    public string OnTertiaryContainer => "#6E353A";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#FFF8F8";
    public string SurfaceVariant => "#F7DBE6";
    public string OnSurface => "#24181E";
    public string OnSurfaceVariant => "#54424A";
    public string SurfaceDim => "#EBD4DC";
    public string SurfaceBright => "#FFF8F8";
    public string SurfaceTint => "#B4007F";
    // Background
    public string Background => "#FFF8F8";
    public string OnBackground => "#24181E";
    // Outline
    public string Outline => "#87717A";
    public string OutlineVariant => "#DAC0CA";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#3B2C33";
    public string InverseOnSurface => "#FFECF2";
    public string InversePrimary => "#FFAFD6";
    // Primary Fixed
    public string PrimaryFixed => "#FFD8E8";
    public string OnPrimaryFixed => "#3C0028";
    public string PrimaryFixedDim => "#FFAFD6";
    public string OnPrimaryFixedVariant => "#8A0060";
    // Secondary Fixed
    public string SecondaryFixed => "#FFD9E1";
    public string OnSecondaryFixed => "#31101B";
    public string SecondaryFixedDim => "#F0B7C5";
    public string OnSecondaryFixedVariant => "#643B46";
    // Tertiary Fixed
    public string TertiaryFixed => "#FFDADA";
    public string OnTertiaryFixed => "#380B11";
    public string TertiaryFixedDim => "#FFB3B6";
    public string OnTertiaryFixedVariant => "#6E353A";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0F4";
    public string SurfaceContainer => "#FFE8F0";
    public string SurfaceContainerHigh => "#FAE2EB";
    public string SurfaceContainerHighest => "#F4DDE5";
}
