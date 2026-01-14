using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Vibrant;

internal class LightMode_NormalContrast_Spec2025_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Vibrant;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#006A2A";
    public string OnPrimary => "#CFFFCE";
    public string PrimaryContainer => "#63FC85";
    public string OnPrimaryContainer => "#005D24";
    // Secondary
    public string Secondary => "#006940";
    public string OnSecondary => "#CAFFDB";
    public string SecondaryContainer => "#7AF8B1";
    public string OnSecondaryContainer => "#005C37";
    // Tertiary
    public string Tertiary => "#006572";
    public string OnTertiary => "#D9F8FF";
    public string TertiaryContainer => "#00E3FF";
    public string OnTertiaryContainer => "#004D58";
    // Error
    public string Error => "#B02500";
    public string OnError => "#FFEFEC";
    public string ErrorContainer => "#F95630";
    public string OnErrorContainer => "#520C00";
    // Surface
    public string Surface => "#DCFFE5";
    public string SurfaceVariant => "#A8ECC0";
    public string OnSurface => "#063620";
    public string OnSurfaceVariant => "#38644A";
    public string SurfaceDim => "#9CE4B6";
    public string SurfaceBright => "#DCFFE5";
    public string SurfaceTint => "#006A2A";
    // Background
    public string Background => "#DCFFE5";
    public string OnBackground => "#063620";
    // Outline
    public string Outline => "#548064";
    public string OutlineVariant => "#89B898";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#001207";
    public string InverseOnSurface => "#79A789";
    public string InversePrimary => "#63FC85";
    // Primary Fixed
    public string PrimaryFixed => "#63FC85";
    public string OnPrimaryFixed => "#00481A";
    public string PrimaryFixedDim => "#53ED79";
    public string OnPrimaryFixedVariant => "#006829";
    // Secondary Fixed
    public string SecondaryFixed => "#7AF8B1";
    public string OnSecondaryFixed => "#00472A";
    public string SecondaryFixedDim => "#6BE9A4";
    public string OnSecondaryFixedVariant => "#00673E";
    // Tertiary Fixed
    public string TertiaryFixed => "#00E3FF";
    public string OnTertiaryFixed => "#003840";
    public string TertiaryFixedDim => "#00D4EE";
    public string OnTertiaryFixedVariant => "#005763";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#C7FDD8";
    public string SurfaceContainer => "#BBF6CE";
    public string SurfaceContainerHigh => "#B2F1C7";
    public string SurfaceContainerHighest => "#A8ECC0";
}
