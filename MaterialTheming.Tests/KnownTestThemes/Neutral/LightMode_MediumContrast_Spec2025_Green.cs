using MaterialTheming.MaterialDesign;

namespace MaterialTheming.Tests.KnownTestThemes.Neutral;

internal class LightMode_MediumContrast_Spec2025_Green : ITestTheme
{
    public string SourceColor => "#338745"; //Green
    public bool IsDark => false;
    public Variant Variant => Variant.Neutral;
    public double ContrastLevelValue => 0.5;
    public SpecVersion SpecVersion => SpecVersion.Spec2025;

    // Primary
    public string Primary => "#3E453D";
    public string OnPrimary => "#D5DCD1";
    public string PrimaryContainer => "#6F776D";
    public string OnPrimaryContainer => "#FFFFFF";
    // Secondary
    public string Secondary => "#414440";
    public string OnSecondary => "#D9DAD5";
    public string SecondaryContainer => "#737571";
    public string OnSecondaryContainer => "#FFFFFF";
    // Tertiary
    public string Tertiary => "#2D4938";
    public string OnTertiary => "#C2E1CA";
    public string TertiaryContainer => "#5E7B68";
    public string OnTertiaryContainer => "#FFFFFF";
    // Error
    public string Error => "#792713";
    public string OnError => "#FFCFC4";
    public string ErrorContainer => "#BA573F";
    public string OnErrorContainer => "#FFFFFF";
    // Surface
    public string Surface => "#FBF9F6";
    public string SurfaceVariant => "#E3E3DE";
    public string OnSurface => "#232422";
    public string OnSurfaceVariant => "#424340";
    public string SurfaceDim => "#DADAD5";
    public string SurfaceBright => "#FBF9F6";
    public string SurfaceTint => "#3E453D";
    // Background
    public string Background => "#FBF9F6";
    public string OnBackground => "#232422";
    // Outline
    public string Outline => "#5E5F5C";
    public string OutlineVariant => "#7A7B77";
    // Shadow
    public string Shadow => "#000000";
    public string Scrim => "#000000";
    // Inverse
    public string InverseSurface => "#0E0E0D";
    public string InverseOnSurface => "#C6C4C2";
    public string InversePrimary => "#F4FCF0";
    // Primary Fixed
    public string PrimaryFixed => "#6F776D";
    public string OnPrimaryFixed => "#FFFFFF";
    public string PrimaryFixedDim => "#636A61";
    public string OnPrimaryFixedVariant => "#FFFFFF";
    // Secondary Fixed
    public string SecondaryFixed => "#737571";
    public string OnSecondaryFixed => "#FFFFFF";
    public string SecondaryFixedDim => "#666964";
    public string OnSecondaryFixedVariant => "#FFFFFF";
    // Tertiary Fixed
    public string TertiaryFixed => "#5E7B68";
    public string OnTertiaryFixed => "#FFFFFF";
    public string TertiaryFixedDim => "#526F5C";
    public string OnTertiaryFixedVariant => "#FFFFFF";
    // Surface Container
    public string SurfaceContainerLowest => "#FFFFFF";
    public string SurfaceContainerLow => "#F5F3F0";
    public string SurfaceContainer => "#EFEEEA";
    public string SurfaceContainerHigh => "#E9E8E4";
    public string SurfaceContainerHighest => "#E3E3DE";
}
