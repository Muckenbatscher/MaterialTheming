using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_MediumContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#443400";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#86690B";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#3B3151";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#73678B";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#003B4C";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#37748B";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F3FAFF";
    public string SurfaceVariant => "#D6E5ED";
    public string OnSurface => "#0A1216";
    public string OnSurfaceVariant => "#2A383E";
    public string SurfaceDim => "#C0C8CC";
    public string SurfaceBright => "#F3FAFF";
    public string SurfaceTint => "#755B00";
    // Background
    public string Background => "#F3FAFF";
    public string OnBackground => "#151D20";
    // Outline
    public string Outline => "#46555B";
    public string OutlineVariant => "#616F76";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2A3235";
    public string InverseOnSurface => "#EAF2F7";
    public string InversePrimary => "#E7C361";
    // Primary Fixed
    public string PrimaryFixed => "#86690B";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#695200";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#73678B";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#5A4F71";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#37748B";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#175C71";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#EDF5FA";
    public string SurfaceContainer => "#E1E9EE";
    public string SurfaceContainerHigh => "#D6DEE3";
    public string SurfaceContainerHighest => "#CBD3D7";
}
