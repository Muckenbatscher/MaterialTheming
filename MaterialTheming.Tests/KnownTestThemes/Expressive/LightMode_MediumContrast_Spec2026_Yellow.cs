namespace MaterialTheming.Tests.KnownTestThemes.Expressive;

internal class LightMode_MediumContrast_Spec2026_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.Expressive;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#3E3D00";
    public string OnPrimary => "#D5D35C";
    public string PrimaryContainer => "#7A7800";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#394865";
    public string OnSecondary => "#D7E2FF";
    public string SecondaryContainer => "#667594";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#1F4491";
    public string OnTertiary => "#D9E1FF";
    public string TertiaryContainer => "#5272C1";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#8A2006";
    public string OnError => "#FFDAD1";
    public string ErrorContainer => "#C74C2F";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FFFBFF";
    public string SurfaceVariant => "#EFED85";
    public string OnSurface => "#2C2C00";
    public string OnSurfaceVariant => "#4B4A00";
    public string SurfaceDim => "#EAE86D";
    public string SurfaceBright => "#FFFBFF";
    public string SurfaceTint => "#3E3D00";
    // Background
    public string Background => "#FFFBFF";
    public string OnBackground => "#2C2C00";
    // Outline
    public string Outline => "#69670A";
    public string OutlineVariant => "#868429";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#0F0F00";
    public string InverseOnSurface => "#C9C79E";
    public string InversePrimary => "#F0EE73";
    // Primary Fixed
    public string PrimaryFixed => "#7A7800";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#6D6B00";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#667594";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#5A6887";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#5272C1";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#4465B3";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FFFCC6";
    public string SurfaceContainer => "#FAF7B0";
    public string SurfaceContainerHigh => "#F5F29B";
    public string SurfaceContainerHighest => "#EFED85";
}
