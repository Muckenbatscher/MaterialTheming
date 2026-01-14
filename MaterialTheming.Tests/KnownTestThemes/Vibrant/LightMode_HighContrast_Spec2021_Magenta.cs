using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_HighContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#5A003D";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#8E0063";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#45212C";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#673D49";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#4E1C21";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#71383C";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F8";
    public string SurfaceVariant => "#F7DBE6";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#C9B3BB";
    public string SurfaceBright => "#FFF8F8";
    public string SurfaceTint => "#B4007F";
    // Background
    public string Background => "#FFF8F8";
    public string OnBackground => "#24181E";
    // Outline
    public string Outline => "#38272F";
    public string OutlineVariant => "#57444C";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#3B2C33";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#FFAFD6";
    // Primary Fixed
    public string PrimaryFixed => "#8E0063";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#660046";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#673D49";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#4D2732";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#71383C";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#562227";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFECF2";
    public string SurfaceContainer => "#F4DDE5";
    public string SurfaceContainerHigh => "#E5CFD7";
    public string SurfaceContainerHighest => "#D7C1C9";
}
