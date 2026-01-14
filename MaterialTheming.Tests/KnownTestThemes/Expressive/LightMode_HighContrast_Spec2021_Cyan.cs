using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_HighContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#382A00";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#5B4600";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#302746";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#4E4465";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#00313F";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#005065";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F3FAFF";
    public string SurfaceVariant => "#D6E5ED";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#B2BABE";
    public string SurfaceBright => "#F3FAFF";
    public string SurfaceTint => "#755B00";
    // Background
    public string Background => "#F3FAFF";
    public string OnBackground => "#151D20";
    // Outline
    public string Outline => "#202E34";
    public string OutlineVariant => "#3D4B52";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2A3235";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#E7C361";
    // Primary Fixed
    public string PrimaryFixed => "#5B4600";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#403100";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#4E4465";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#372D4D";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#005065";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#003847";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#EAF2F7";
    public string SurfaceContainer => "#DCE4E8";
    public string SurfaceContainerHigh => "#CED6DA";
    public string SurfaceContainerHighest => "#C0C8CC";
}
