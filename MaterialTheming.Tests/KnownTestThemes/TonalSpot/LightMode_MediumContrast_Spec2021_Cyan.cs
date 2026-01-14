using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_MediumContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#003C44";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#197885";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#223A3E";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#597176";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#2A3553";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#616C8D";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F5FAFC";
    public string SurfaceVariant => "#DBE4E6";
    public string OnSurface => "#0C1213";
    public string OnSurfaceVariant => "#2F3839";
    public string SurfaceDim => "#C2C7C9";
    public string SurfaceBright => "#F5FAFC";
    public string SurfaceTint => "#006875";
    // Background
    public string Background => "#F5FAFC";
    public string OnBackground => "#171D1E";
    // Outline
    public string Outline => "#4B5456";
    public string OutlineVariant => "#656F71";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2B3133";
    public string InverseOnSurface => "#ECF2F3";
    public string InversePrimary => "#82D3E1";
    // Primary Fixed
    public string PrimaryFixed => "#197885";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#005E69";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#597176";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#41595D";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#616C8D";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#495473";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#EFF5F6";
    public string SurfaceContainer => "#E3E9EA";
    public string SurfaceContainerHigh => "#D8DEDF";
    public string SurfaceContainerHighest => "#CDD3D4";
}
