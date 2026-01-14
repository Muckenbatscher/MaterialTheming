using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_NormalContrast_Spec2021_Cyan : ITestTheme
{
    public string SourceColor => "#00BCD1"; //Cyan
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#755B00";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#FFDF90";
    public string OnPrimaryContainer => "#584400";
    // Secondary
    public string Secondary => "#64597C";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#EADDFF";
    public string OnSecondaryContainer => "#4C4163";
    // Tertiary
    public string Tertiary => "#25667C";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#BAEAFF";
    public string OnTertiaryContainer => "#004D62";
    // Error
    public string Error => "#BA1A1A";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FFDAD6";
    public string OnErrorContainer => "#93000A";
    // Surface
    public string Surface => "#F3FAFF";
    public string SurfaceVariant => "#D6E5ED";
    public string OnSurface => "#151D20";
    public string OnSurfaceVariant => "#3B494F";
    public string SurfaceDim => "#D3DBE0";
    public string SurfaceBright => "#F3FAFF";
    public string SurfaceTint => "#755B00";
    // Background
    public string Background => "#F3FAFF";
    public string OnBackground => "#151D20";
    // Outline
    public string Outline => "#6B7980";
    public string OutlineVariant => "#BAC9D0";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2A3235";
    public string InverseOnSurface => "#EAF2F7";
    public string InversePrimary => "#E7C361";
    // Primary Fixed
    public string PrimaryFixed => "#FFDF90";
    public string OnPrimaryFixed => "#241A00";
    public string PrimaryFixedDim => "#E7C361";
    public string OnPrimaryFixedVariant => "#584400";
    // Secondary Fixed
    public string SecondaryFixed => "#EADDFF";
    public string OnSecondaryFixed => "#1F1635";
    public string SecondaryFixedDim => "#CEC0E8";
    public string OnSecondaryFixedVariant => "#4C4163";
    // Tertiary Fixed
    public string TertiaryFixed => "#BAEAFF";
    public string OnTertiaryFixed => "#001F29";
    public string TertiaryFixedDim => "#93CFE8";
    public string OnTertiaryFixedVariant => "#004D62";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#EDF5FA";
    public string SurfaceContainer => "#E7EFF4";
    public string SurfaceContainerHigh => "#E1E9EE";
    public string SurfaceContainerHighest => "#DCE4E8";
}
