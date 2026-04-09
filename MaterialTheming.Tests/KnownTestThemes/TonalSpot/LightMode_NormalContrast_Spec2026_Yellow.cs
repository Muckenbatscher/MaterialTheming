namespace MaterialTheming.Tests.KnownTestThemes.TonalSpot;

internal class LightMode_NormalContrast_Spec2026_Yellow : ITestTheme
{
    public string SourceColor => "#B2B037"; //Yellow
    public bool IsDark => false;
    public Variant Variant => Variant.TonalSpot;
    public double ContrastLevelValue => 0.0;
    public SpecVersion SpecVersion => SpecVersion.Spec2026;

    // Primary
    public string Primary => "#686727";
    public string OnPrimary => "#FFFFFF";
    public string PrimaryContainer => "#E9E698";
    public string OnPrimaryContainer => "#555416";
    // Secondary
    public string Secondary => "#676648";
    public string OnSecondary => "#FFFFFF";
    public string SecondaryContainer => "#E7E4BF";
    public string OnSecondaryContainer => "#545337";
    // Tertiary
    public string Tertiary => "#7E5F2B";
    public string OnTertiary => "#FFFFFF";
    public string TertiaryContainer => "#FED494";
    public string OnTertiaryContainer => "#644715";
    // Error
    public string Error => "#AE4025";
    public string OnError => "#FFFFFF";
    public string ErrorContainer => "#FD795A";
    public string OnErrorContainer => "#6E1400";
    // Surface
    public string Surface => "#FEFCF7";
    public string SurfaceVariant => "#ECE9D5";
    public string OnSurface => "#39382B";
    public string OnSurfaceVariant => "#666556";
    public string SurfaceDim => "#E6E3D0";
    public string SurfaceBright => "#FEFCF7";
    public string SurfaceTint => "#686727";
    // Background
    public string Background => "#FEFCF7";
    public string OnBackground => "#39382B";
    // Outline
    public string Outline => "#838171";
    public string OutlineVariant => "#BCBAA8";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#0F0E08";
    public string InverseOnSurface => "#9F9D93";
    public string InversePrimary => "#F7F5A5";
    // Primary Fixed
    public string PrimaryFixed => "#E9E698";
    public string OnPrimaryFixed => "#424103";
    public string PrimaryFixedDim => "#DAD88C";
    public string OnPrimaryFixedVariant => "#5F5E1F";
    // Secondary Fixed
    public string SecondaryFixed => "#E7E4BF";
    public string OnSecondaryFixed => "#414126";
    public string SecondaryFixedDim => "#D9D6B1";
    public string OnSecondaryFixedVariant => "#5E5D40";
    // Tertiary Fixed
    public string TertiaryFixed => "#FED494";
    public string OnTertiaryFixed => "#4F3503";
    public string TertiaryFixedDim => "#EFC688";
    public string OnTertiaryFixedVariant => "#6E511E";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#FDF9EB";
    public string SurfaceContainer => "#F8F4E4";
    public string SurfaceContainerHigh => "#F2EEDD";
    public string SurfaceContainerHighest => "#ECE9D5";
}
