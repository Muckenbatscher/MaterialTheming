using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_MediumContrast_Spec2021_Magenta : ITestTheme
{
    public string SourceColor => "#E85DAE"; //Magenta
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#003B4F";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#127698";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#532C20";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#926152";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#393800";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#71702F";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFF8F7";
    public string SurfaceVariant => "#FADBE0";
    public string OnSurface => "#190E10";
    public string OnSurfaceVariant => "#453135";
    public string SurfaceDim => "#D6C2C4";
    public string SurfaceBright => "#FFF8F7";
    public string SurfaceTint => "#006685";
    // Background
    public string Background => "#FFF8F7";
    public string OnBackground => "#24191B";
    // Outline
    public string Outline => "#634D51";
    public string OutlineVariant => "#7F676B";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#3A2D2F";
    public string InverseOnSurface => "#FFECEE";
    public string InversePrimary => "#81D1F6";
    // Primary Fixed
    public string PrimaryFixed => "#127698";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#005C78";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#926152";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#76493C";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#71702F";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#585719";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFF0F1";
    public string SurfaceContainer => "#F9E3E6";
    public string SurfaceContainerHigh => "#EDD8DA";
    public string SurfaceContainerHighest => "#E1CDCF";
}
