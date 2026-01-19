namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_MediumContrast_Spec2021_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#5C2043";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#9D567B";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#1D3D26";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#53755A";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#293C0B";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#5E743E";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#740006";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#CF2C27";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FAFBEA";
    public string SurfaceVariant => "#E1E5CC";
    public string OnSurface => "#101209";
    public string OnSurfaceVariant => "#343827";
    public string SurfaceDim => "#C6C8B8";
    public string SurfaceBright => "#FAFBEA";
    public string SurfaceTint => "#8C486C";
    // Background
    public string Background => "#FAFBEA";
    public string OnBackground => "#1A1D13";
    // Outline
    public string Outline => "#505442";
    public string OutlineVariant => "#6B6F5B";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2F3227";
    public string InverseOnSurface => "#F1F2E2";
    public string InversePrimary => "#FFAFD6";
    // Primary Fixed
    public string PrimaryFixed => "#9D567B";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#813E62";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#53755A";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#3B5C43";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#5E743E";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#465B28";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F4F5E4";
    public string SurfaceContainer => "#E8E9D9";
    public string SurfaceContainerHigh => "#DDDECE";
    public string SurfaceContainerHighest => "#D1D3C3";
}
