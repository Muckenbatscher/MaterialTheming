namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_HighContrast_Spec2025_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 1.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#2C2C00";
    public string OnPrimary => "#EAE86E";
    public string PrimaryContainer => "#5B5A00";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#1B2A46";
    public string OnSecondary => "#D7E2FF";
    public string SecondaryContainer => "#495776";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#002665";
    public string OnTertiary => "#DAE2FF";
    public string TertiaryContainer => "#3254A1";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#570D00";
    public string OnError => "#FFDAD2";
    public string ErrorContainer => "#9F3015";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFFBFF";
    public string SurfaceVariant => "#EFED85";
    public string OnSurface => "#000000";
    public string OnSurfaceVariant => "#2C2C00";
    public string SurfaceDim => "#EAE86D";
    public string SurfaceBright => "#FFFBFF";
    public string SurfaceTint => "#2C2C00";
    // Background
    public string Background => "#FFFBFF";
    public string OnBackground => "#000000";
    // Outline
    public string Outline => "#4B4A00";
    public string OutlineVariant => "#5B5A00";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#0F0F00";
    public string InverseOnSurface => "#FFFFFF";
    public string InversePrimary => "#F0EE73";
    // Primary Fixed
    public string PrimaryFixed => "#5B5A00";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#4F4E00";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#495776";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#3D4B69";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#3254A1";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#244894";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFFCC6";
    public string SurfaceContainer => "#FAF7B0";
    public string SurfaceContainerHigh => "#F5F29B";
    public string SurfaceContainerHighest => "#EFED85";
}
