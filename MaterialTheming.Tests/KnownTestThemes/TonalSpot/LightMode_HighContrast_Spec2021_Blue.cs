namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_HighContrast_Spec2021_Blue : ITestTheme
{
    public string SourceColor => "#185FAA"; //Blue
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2021;

    // Primary
    public string Primary => "#002C58";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#264A79";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#222D3D";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#3F4A5B";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#392441";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#584160";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#600004";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#98000A";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#F9F9FF";
    public string SurfaceVariant => "#E0E2EC";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#000000";
    public string SurfaceDim => "#B7B8BF";
    public string SurfaceBright => "#F9F9FF";
    public string SurfaceTint => "#3D5F90";
    // Background
    public string Background => "#F9F9FF";
    public string OnBackground => "#191C20";
    // Outline
    public string Outline => "#292C33";
    public string OutlineVariant => "#464951";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#2E3035";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#A6C8FF";
    // Primary Fixed
    public string PrimaryFixed => "#264A79";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#053361";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#3F4A5B";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#293343";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#584160";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#402B48";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F0F0F7";
    public string SurfaceContainer => "#E1E2E9";
    public string SurfaceContainerHigh => "#D3D4DA";
    public string SurfaceContainerHighest => "#C5C6CD";
}
